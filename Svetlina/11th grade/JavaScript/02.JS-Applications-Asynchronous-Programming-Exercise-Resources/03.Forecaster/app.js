function attachEvents() {
    const locationInput = document.getElementById('location');
    const submitButton = document.getElementById('submit');
    const currentDiv = document.getElementById('current');
    const upcomingDiv = document.getElementById('upcoming');
    const forecastDiv = document.getElementById('forecast');

    submitButton.addEventListener('click', async () => {
        const locationName = locationInput.value;
        let locationCode = '';

        try {
            const locationsResponse = await fetch('http://localhost:3030/jsonstore/forecaster/locations');
            const locations = await locationsResponse.json();
            const location = locations.find(l => l.name === locationName);
            if (!location) {
                forecastDiv.style.display = 'block';
                currentDiv.innerHTML = '<div class="label">Error</div>';
                upcomingDiv.innerHTML = '';
                return;
            }
            locationCode = location.code;

            const currentResponse = await fetch(`http://localhost:3030/jsonstore/forecaster/today/${locationCode}`);
            const current = await currentResponse.json();

            let symbol = '';
            switch (current.forecast.condition) {
                case 'Sunny':
                    symbol = '☀';
                    break;
                case 'Partly sunny':
                    symbol = '⛅';
                    break;
                case 'Overcast':
                    symbol = '☁';
                    break;
                case 'Rain':
                    symbol = '☂';
                    break;
            }

            currentDiv.innerHTML = `<div class="label">Current conditions</div>
            <span class="condition symbol">${symbol}</span>
            <span class="condition">
                <span class="forecast-data">${current.name}</span>
                <span class="forecast-data">${current.forecast.low}°/${current.forecast.high}°</span>
                <span class="forecast-data">${current.forecast.condition}</span>
            </span>`;

            const upcomingResponse = await fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${locationCode}`);
            const upcoming = await upcomingResponse.json();

            const upcomingSpan = document.createElement('div');
            upcomingSpan.classList.add('forecast-data');

            for (const forecast of upcoming.forecast) {
                switch (forecast.condition) {
                    case 'Sunny':
                        symbol = '☀';
                        break;
                    case 'Partly sunny':
                        symbol = '⛅';
                        break;
                    case 'Overcast':
                        symbol = '☁';
                        break;
                    case 'Rain':
                        symbol = '☂';
                        break;
                }

                const span = document.createElement('span');
                span.classList.add('upcoming');
                span.innerHTML = `<span class="symbol">${symbol}</span>
                <span class="forecast-data">${forecast.low}°/${forecast.high}°</span>
                <span class="forecast-data">${forecast.condition}</span>`;
                upcomingSpan.appendChild(span);
            }

            upcomingDiv.innerHTML = `<div class="label">Three-day forecast</div>`;
            upcomingDiv.appendChild(upcomingSpan);
        } catch (error) {
            forecastDiv.style.display = 'block';
            currentDiv.innerHTML = '<div class="label">Error</div>';
            upcomingDiv.innerHTML = '';
        }
    });
}

attachEvents();
