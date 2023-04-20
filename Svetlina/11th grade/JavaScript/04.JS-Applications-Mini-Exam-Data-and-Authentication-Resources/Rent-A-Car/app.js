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

