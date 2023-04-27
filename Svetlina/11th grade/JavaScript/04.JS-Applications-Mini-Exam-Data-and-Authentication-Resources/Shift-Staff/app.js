const server = 'http://localhost:3030/jsonstore/shift';

async function loadShiftStaff() {
    const response = await fetch(server);
    const data = await response.json();
    const tableBody = document.getElementById('staff');
    tableBody.innerHTML = '';

    Object.keys(data).forEach((key) => {
        const row = document.createElement('tr');
        const personName = data[key].person;
        const personCell = document.createElement('td');
        personCell.textContent = personName;
        row.appendChild(personCell);

        const deleteButton = document.createElement('button');
        deleteButton.textContent = 'Delete';
        deleteButton.addEventListener('click', async () => {
            await deleteShiftEntry(key);
        });

        const deleteCell = document.createElement('td');
        deleteCell.appendChild(deleteButton);
        row.appendChild(deleteCell);

        tableBody.appendChild(row);
    });
}

async function deleteShiftEntry(key) {
    const response = await fetch(`${server}/${key}`, {
        method: 'DELETE',
    });
    const data = await response.json();
    console.log(`Deleted shift entry with key ${key}:`, data);
    await loadShiftStaff();
}

async function addShiftEntry(personName) {
    const response = await fetch(server, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify({ person: personName }),
    });
    const data = await response.json();
    console.log('Added new shift entry:', data);
    await loadShiftStaff();
}


document.getElementById('btnLoad').addEventListener('click', loadShiftStaff);
document.getElementById('btnAdd').addEventListener('click', async () => {
    const personName = document.getElementById('person').value;
    await addShiftEntry(personName);
    document.getElementById('person').value = '';
});