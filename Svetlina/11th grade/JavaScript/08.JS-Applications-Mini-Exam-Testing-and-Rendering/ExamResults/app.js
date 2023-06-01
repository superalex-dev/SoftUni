import { html, render } from './node_modules/lit-html/lit-html.js';
import { students } from './students.js';

const searchButton = document.querySelector('.searchButton');
const searchTerm = document.querySelector('.searchTerm');
const mainElement = document.querySelector('main');

searchButton.addEventListener('click', search);

function search() {
    const searchText = searchTerm.value.toLowerCase();

    const updatedStudents = students.map(student => {
        const isActive = student.name.toLowerCase().startsWith(searchText);
        return { ...student, active: isActive };
    });

    render(template(updatedStudents), mainElement);
}

const template = (students) => html`
    <table class="styled-table">
        <thead>
        <tr>
            <th>Name</th>
            <th>Points</th>
        </tr>
        </thead>
        <tbody>
        ${students.map(student => html`
            <tr>
                <td class="${student.active ? 'active' : ''}">${student.name}</td>
            </tr>
        `)}
        </tbody>
    </table>
    <div class="search">
        <input type="text" class="searchTerm">
        <button class="searchButton">Search</button>
    </div>
`;

render(template(students), mainElement);
