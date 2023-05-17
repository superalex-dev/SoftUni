import { html, render } from 'https://unpkg.com/lit-html?module';

const catalogTemplate = () => html`
  <section id="catalog">
    <h2>Catalog</h2>
    <p>This is the catalog page for logged-in users.</p>
  </section>
`;

export const renderCatalog = () => {
  const appContainer = document.getElementById('app-container');
  render(catalogTemplate(), appContainer);
};