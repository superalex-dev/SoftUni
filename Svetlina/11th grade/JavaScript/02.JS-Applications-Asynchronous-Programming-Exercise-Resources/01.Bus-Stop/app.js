const stopNameElement = document.getElementById('stopName');
const busesListElement = document.getElementById('buses');

document.getElementById('submit').addEventListener('click', loadBusInfo);

function loadBusInfo() {
  const stopId = document.getElementById('stopId').value;
  const url = `http://localhost:3030/jsonstore/bus/businfo/${stopId}`;
  
  busesListElement.innerHTML = '';
  
  fetch(url)
    .then(response => response.json())
    .then(data => {
      const { name, buses } = data[stopId];
      stopNameElement.textContent = name;
      
      for (const [busId, time] of Object.entries(buses)) {
        const listItem = document.createElement('li');
        listItem.textContent = `Bus ${busId} arrives in ${time} minutes`;
        busesListElement.appendChild(listItem);
      }
    })
    .catch(() => {
      stopNameElement.textContent = 'Error';
    });
}
