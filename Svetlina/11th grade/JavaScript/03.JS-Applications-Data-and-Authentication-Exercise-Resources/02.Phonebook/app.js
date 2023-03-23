async function attachEvents() {
    const phonebook = document.getElementById('phonebook');
    const btnLoad = document.getElementById('btnLoad');
    const personName = document.getElementById('person');
    const personPhone = document.getElementById('phone');
    const btnCreate = document.getElementById('btnCreate');

    btnLoad.addEventListener('click', loadContacts);
    btnCreate.addEventListener('click', createContact);

    async function loadContacts() {
        phonebook.innerHTML = '';
        try {
            const response = await fetch('http://localhost:3030/jsonstore/phonebook');
            if (!response.ok) {
                throw new Error('Unable to fetch contacts.');
            }
            const contacts = await response.json();
            for (const [id, contact] of Object.entries(contacts)) {
                const li = document.createElement('li');
                li.textContent = `${contact.person}: ${contact.phone}`;

                const deleteBtn = document.createElement('button');
                deleteBtn.textContent = 'Delete';

                deleteBtn.addEventListener('click', async () => {
                    try {
                        const response = await fetch(`http://localhost:3030/jsonstore/phonebook/${id}`, {
                            method: 'DELETE'
                        });
                        if (!response.ok) {
                            throw new Error('Unable to delete contact.');
                        }
                        loadContacts();
                    } catch (err) {
                        displayError(err);
                    }
                });

                li.append(deleteBtn);
                phonebook.append(li);
            }
        } catch (err) {
            displayError(err);
        }

        async function createContact() {
            try {
                const response = await fetch('http://localhost:3030/jsonstore/phonebook', {
                    method: 'POST',
                    headers: {'Content-Type': 'application/json'},
                    body: JSON.stringify({person: personName.value, phone: personPhone.value})
                });
                if (!response.ok) {
                    throw new Error('Unable to create contact.');
                }
                personName.value = '';
                personPhone.value = '';
                loadContacts();
            } catch (err) {
                displayError(err);
            }
        }

        function displayError(err) {
            const li = document.createElement('li');
            li.textContent = 'Error: ' + err;
            phonebook.append(li);
        }
    }
}
attachEvents();