window.addEventListener('load', solution);

function solution() {
    let submitButton = document.querySelector('#submitBTN');
    let editButton = document.querySelector('#editBTN');
    let continueButton = document.querySelector('#continueBTN');
    let fullNameInput = document.querySelector('#fname');
    let emailInput = document.querySelector('#email');
    let phoneNumberInput = document.querySelector('#phone');
    let guestsInput = document.querySelector('#guests');
    let timeInput = document.querySelector('#time');
    let infoPreviewList = document.querySelector('#infoPreview');
    let blockDiv = document.querySelector('#block');

    editButton.disabled = true;
    continueButton.disabled = true;

    submitButton.addEventListener('click', function() {
        if (fullNameInput.value.trim() === '' || phoneNumberInput.value.trim() === '') {
            return;
        }

        infoPreviewList.appendChild(createListItem('Full Name', fullNameInput.value));
        infoPreviewList.appendChild(createListItem('Email', emailInput.value));
        infoPreviewList.appendChild(createListItem('Phone Number', phoneNumberInput.value));
        infoPreviewList.appendChild(createListItem('Number of Guests', guestsInput.value));
        infoPreviewList.appendChild(createListItem('Reservation Time', timeInput.value));
        
        [fullNameInput, emailInput, phoneNumberInput, guestsInput, timeInput].forEach(input => input.value = '');

        submitButton.disabled = true;
        editButton.disabled = false;
        continueButton.disabled = false;
    });

    editButton.addEventListener('click', function() {
        let items = Array.from(infoPreviewList.children);
        fullNameInput.value = items[0].textContent.replace('Full Name: ', '');
        emailInput.value = items[1].textContent.replace('Email: ', '');
        phoneNumberInput.value = items[2].textContent.replace('Phone Number: ', '');
        guestsInput.value = items[3].textContent.replace('Number of Guests: ', '');
        timeInput.value = items[4].textContent.replace('Reservation Time: ', '');

        submitButton.disabled = false;
        editButton.disabled = true;
        continueButton.disabled = true;

        infoPreviewList.innerHTML = '';
    });

    continueButton.addEventListener('click', function() {
        blockDiv.innerHTML = '';
        let thankYouMessage = document.createElement('h3');
        thankYouMessage.textContent = 'Thank you for your reservation!';
        blockDiv.appendChild(thankYouMessage);
    });

    function createListItem(label, value) {
        let listItem = document.createElement('li');
        listItem.textContent = `${label}: ${value}`;
        return listItem;
    }
}