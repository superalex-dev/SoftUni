//<!DOCTYPE html>
// <html lang="en">
//
// <head>
//     <meta charset="UTF-8">
//     <meta name="viewport" content="width=device-width, initial-scale=1.0">
//     <meta http-equiv="X-UA-Compatible" content="ie=edge">
//     <title>Rent A Car</title>
//     <link rel="stylesheet" href="./styles.css">
// </head>
//
// <body>
//     <button id="loadCars">Load All Cars</button>
//     <table>
//         <tbody>
//             <!-- <tr>
//                 <td>Nissan</td>
//                 <td>Armada</td>
//                 <td>
//                     <button>Edit</button>
//                     <button>Delete</button>
//                 </td>
//             </tr> -->
//         </tbody>
//     </table>
//
//     <form>
//         <h3>Add Available Car</h3>
//         <label>Make</label>
//         <input type="text" name="make" placeholder="Honda...">
//         <label>Model</label>
//         <input type="text" name="model" placeholder="Civic...">
//         <button>Submit</button>
//     </form>
//     <script src="./app.js"></script>
// </body>
//
// </html>
//
// using this provided skeleton, do folowing
// 2. Rent A Car
// For the solution of the following task, use the provided server in the lesson’s resources archive.
// GET and POST requests should go to http://localhost:3030/jsonstore/cars
// Using the provided skeleton, write the missing functionalities.
// First task is to "GET" all cars. Load all cars by clicking the button [Load All Cars]
// Create Car
// Write functionality to create a new car, when the submit button is clicked. Before sending the request be sure the
// fields are not empty (make validation of the input). To create a car, you have to send a "POST" request and the JSON
// body should be in the following format:
// {
// make: 'car brand',
// model: 'model of a car'
// }
// Update Car
// By clicking the edit button of a car, change the form like this:
// The HTTP command "PUT" modifies an existing HTTP resource. The URL is:
// http://localhost:3030/jsonstore/cars/:id
// The JSON body should be in the following format:
// {
// make: 'Changed car brand',
// model: 'Changed model of a car'
// }
// Delete Car
// By clicking the delete button you have to delete the car, without any confirmation. To delete a car use [DELETE]
// command and send REQUEST: http://localhost:3030/jsonstore/cars/:id

const getCars = async () => {
    const response = await fetch('http://localhost:3030/jsonstore/cars');
    const data = await response.json();
    return data;
}

const loadCars = async () => {
    const cars = await getCars();
    const table = document.querySelector('table tbody');
    table.innerHTML = '';
    Object.values(cars).map(createRow).forEach(r => table.appendChild(r));
}

const createRow = (car) => {
    const result = document.createElement('tr');
    result.innerHTML = `
    <td>${car.make}</td>
    <td>${car.model}</td>
    <td>
        <button>Edit</button>
        <button>Delete</button>
    </td>
    `;
    const editBtn = result.querySelector('button');
    editBtn.addEventListener('click', () => editCar(car._id, car.make, car.model));
    const deleteBtn = editBtn.nextElementSibling;
    deleteBtn.addEventListener('click', () => deleteCar(car._id));
    return result;
}

const editCar = (id, make, model) => {
    document.querySelector('input[name="make"]').value = make;
    document.querySelector('input[name="model"]').value = model;
    document.querySelector('button').textContent = 'Save';
    document.querySelector('button').addEventListener('click', () => updateCar(id));

}

const updateCar = async (id) => {
    const make = document.querySelector('input[name="make"]').value;
    const model = document.querySelector('input[name="model"]').value;
    if (make == '' || model == '') {
        return alert('All fields are required!');
    }
    const response = await fetch(`http://localhost:3030/jsonstore/cars/${id}`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ make, model })
    });
    if (response.ok) {
        document.querySelector('input[name="make"]').value = '';
        document.querySelector('input[name="model"]').value = '';
        document.querySelector('button').textContent = 'Submit';
        loadCars();
    }
}

const deleteCar = async (id) => {
    const response = await fetch(`http://localhost:3030/jsonstore/cars/${id}`, {
        method: 'delete'
    });
    if (response.ok) {
        loadCars();
    }

}

const createCar = async () => {
    const make = document.querySelector('input[name="make"]').value;
    const model = document.querySelector('input[name="model"]').value;
    if (make == '' || model == '') {
        return alert('All fields are required!');
    }
    const response = await fetch('http://localhost:3030/jsonstore/cars', {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ make, model })
    });
    if (response.ok) {
        document.querySelector('input[name="make"]').value = '';
        document.querySelector('input[name="model"]').value = '';
        loadCars();
    }
}

document.getElementById('loadCars').addEventListener('click', loadCars);
document.querySelector('form').addEventListener('submit', (e) => {
    e.preventDefault();
    createCar();
});

