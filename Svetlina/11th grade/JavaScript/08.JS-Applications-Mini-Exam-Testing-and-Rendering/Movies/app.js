import { html, render } from './node_modules/lit-html/lit-html.js';
import { movies } from './movieSeeder.js';

const movieTemplate = (movie) => html`
  <li class="cards_item">
    <div class="card">
      <div class="card_image">
        <img src="./images/${movie.imageLocation}.jpg">
      </div>
      <div class="card_content">
        <h2 class="card_title">${movie.title}</h2>
        <button class="showBtn">Read More</button>
        <div class="movie" style="display:none" id="${movie.id}">
          <p class="card_text">${movie.description}</p>
        </div>
      </div>
    </div>
  </li>
`;

const toggleDescription = (event) => {
  const btn = event.target;
  const movieElement = btn.parentNode.querySelector('.movie');
  const display = movieElement.style.display;

  if (display === 'none') {
    movieElement.style.display = 'block';
    btn.textContent = 'Read Less';
  } else {
    movieElement.style.display = 'none';
    btn.textContent = 'Read More';
  }
};

const movieListTemplate = (movies) => html`
  <ul>
    ${movies.map(movieTemplate)}
  </ul>
`;

const section = document.getElementById('allMovies');

render(movieListTemplate(movies), section);

section.addEventListener('click', (event) => {
  if (event.target.classList.contains('showBtn')) {
    toggleDescription(event);
  }
});
