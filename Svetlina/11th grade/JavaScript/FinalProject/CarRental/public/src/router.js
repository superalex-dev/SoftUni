class Router {
  constructor(routes) {
    this.routes = routes;
    this._loadInitialRoute();
  }

  loadRoute(...urlSegments) {
    const path = `/${urlSegments.join('/')}`.replace(/\/\//g, '/');
    const route = this.routes[path] || this.routes['*'];
    route(path);
  }

  _loadInitialRoute() {
    const path = window.location.pathname;
    const urlSegments = path.split('/').filter((segment) => segment !== '');
    this.loadRoute(...urlSegments);
  }

  init() {
    window.addEventListener('load', () => this._loadInitialRoute());
    window.addEventListener('hashchange', () => this.loadRoute());
  }
}
