function solve() {
    document.querySelector('form').addEventListener('submit', function (event) {
        event.preventDefault();
        const creator = document.getElementById('creator').value;
        const title = document.getElementById('title').value;
        const content = document.getElementById('content').value;
        const article = document.createElement('article');
        article.innerHTML = `
        <h1>${title}</h1>
        <p>Creator: ${creator}</p>
        <p>${content}</p>
        <div class="buttons">
            <button class="btn delete">Delete</button>
        </div>`;


        const publications = document.querySelector('main section');
        publications.appendChild(article);

        const deleteBtn = article.querySelector('.btn.delete');
        deleteBtn.addEventListener('click', function (e) {
            article.remove();
        });
    });
}
