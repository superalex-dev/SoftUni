const baseUrl = 'http://localhost:3030/jsonstore/bus/businfo/';

function getInfo() {
  const stopId = document.getElementById('stopId').value;
  const stopNameEl = document.getElementById('stopName');
  const busesListEl = document.getElementById('buses');

  stopNameEl.textContent = '';
  busesListEl.innerHTML = '';

  fetch(baseUrl + stopId)
    .then(response => response.json())
    .then(data => {
      stopNameEl.textContent = data.name;

      Object.entries(data.buses).forEach(([busId, time]) => {
        const li = document.createElement('li');
        li.textContent = `Bus ${busId} arrives in ${time}`;
        busesListEl.appendChild(li);
      });
    })
    .catch(() => {
      stopNameEl.textContent = 'Error';
    });
}

document.getElementById('submit').addEventListener('click', getInfo);
