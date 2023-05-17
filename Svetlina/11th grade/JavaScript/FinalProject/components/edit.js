import { html, render } from 'https://unpkg.com/lit-html?module';

const editTemplate = () => html`
  <section id="edit">
    <h2>Edit Product</h2>
    <p>This is the edit page for logged-in users.</p>
  </section>
`;

export const renderEdit = () => {
  const appContainer = document.getElementById('app-container');
  render(editTemplate(), appContainer);
};
