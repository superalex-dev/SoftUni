function addToCart(price) {
    console.log("here")

    if (localStorage.getItem(price)) {
        localStorage[price]++;
    } else {
        localStorage.setItem(price, 1);
    }
}

function displayItems() {
    let start = document.getElementById('cart-start');

    let products = {
        499: "AC Compressor",
        80: "Headlight",
        8999: "Engine",
        149: "Alternator",
        99: "Battery",
        249: "Door",
        119: "Steering Wheel",
        109: "Starter"
    }

    let storage = localStorage;

    if (storage.length > 0) {
        document.getElementById("empty-shopping-cart-message").innerHTML = '';
    }

    let totalPrice = 0;

    for (const [key, value] of Object.entries(products)) {
        if (storage[`${key}`]) {
            let currentProductPrice = key * storage[`${key}`];

            let el = document.createElement('p');
            el.innerHTML = `<strong>${products[`${key}`]}</strong> - Quantity - <strong>${storage[`${key}`]}</strong> - price is <strong>$${currentProductPrice}</strong>`;

            start.appendChild(el);
            totalPrice += currentProductPrice;
        }
    }

    if(storage.length > 0){
        let totalHtml = document.createElement("h1");
        totalHtml.innerHTML = `Total: <strong>$${totalPrice}</strong>`;
        totalHtml.setAttribute("style", "font-family: 'Playfair Display', serif; margin-top: 5rem; margin-bottom: 5rem;");
        totalHtml.setAttribute("id", "total-price");
        start.appendChild(totalHtml);

        let PSButton = document.createElement("button");
        PSButton.innerHTML = "I'll come and get them from your store.";
        PSButton.setAttribute("class", "options-buttons");
        PSButton.setAttribute("onclick", "buyProducts()");

        let CButton = document.createElement("button");
        CButton.innerHTML = "Deliver it to my address with a courier. ($14.99 if you live outside of Bulgaria)";
        CButton.setAttribute("style", "font-size: 0.9rem;");
        CButton.setAttribute("class", "options-buttons");
        CButton.setAttribute("onclick", "buyProducts()");

        let holidayOptionButton = document.createElement("button");
        holidayOptionButton.innerHTML = "Wrap my parts in holiday wrapping :) ($4.99)";
        holidayOptionButton.setAttribute("style", "font-size: 0.9rem; background-color: green; margin-left: 15%;");
        holidayOptionButton.setAttribute("class", "options-buttons");
        holidayOptionButton.setAttribute("onclick", `wrap(${totalPrice + 4.99})`);

        start.appendChild(CButton);
        start.appendChild(PSButton);
        start.appendChild(holidayOptionButton); 
    }
}

function buyProducts() {
    localStorage.clear();
    alert("Thank you for choosing Autoportal!")
    window.location.reload();
}

function wrap(totalPrice){
    document.getElementById('total-price').innerHTML = `Total: <strong>$${totalPrice}</strong> with holiday wrapping :)`;
}