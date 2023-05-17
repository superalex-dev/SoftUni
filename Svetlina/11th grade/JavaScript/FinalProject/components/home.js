import { html, render } from 'https://unpkg.com/lit-html?module';

const homeTemplate = () => html`
  <section id="home">
    <h1>Welcome to Airline Ticket Purchasing</h1>
    <p>Find and book your flights easily!</p>
  </section>
`;

export const renderHome = () => {
  const appContainer = document.getElementById('app-container');
  render(homeTemplate(), appContainer);
};
