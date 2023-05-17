import { renderHome } from './components/home.js';
import { renderLogin } from './components/login.js';
import { renderRegister } from './components/register.js';
import { renderCatalog } from './components/catalog.js';
import { renderEdit } from './components/edit.js';
import { renderLogout } from './components/logout.js';
import { renderProfile } from './components/profile.js';
import { renderNotFound } from './components/not-found.js';
import { renderError } from './components/error.js';
import { renderAdmin } from './components/admin.js';

const routes = {
  '#home': renderHome,
  // Add other routes for login, register, catalog, edit, and logout
};

const handleRoute = () => {
  const currentRoute = window.location.hash;
  const renderFunction = routes[currentRoute] || renderHome;
  renderFunction();
};

window.addEventListener('hashchange', handleRoute);
window.addEventListener('DOMContentLoaded', handleRoute);
