const inputField = document.getElementById('text-input');
const submitButton = document.getElementById('submit-btn');

submitButton.addEventListener('click', () => {
    const text = inputField.value;

    const li = document.createElement('li');
    li.innerText = text;

    const ol = document.querySelector('ol');
    ol.appendChild(li);
});

const ol = document.querySelector('ol');

ol.addEventListener('click', (event) => {
    if (event.target.tagName === 'LI') {
        event.target.remove();
    }
});
