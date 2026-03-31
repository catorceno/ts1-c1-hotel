const Router = {
  routes: [],

  init(routes) {
    this.routes = routes;

    document.querySelectorAll("a.nav__link").forEach((a) => {
      a.addEventListener("click", (event) => {
        event.preventDefault();
        const href = event.target.getAttribute("href");
        Router.go(href);
      });
    });

    window.addEventListener("popstate", (event) => {
      Router.go(event.state.route, false);
    });

    Router.go(location.pathname);
  },

  go(route, addToHistory = true){
    if(addToHistory){
      history.pushState({ route }, "", route);
    }

    const match = this.routes.find((r) => r.path === route);

    if(match) {
      const pageElement = document.createElement(match.component);
      const main = document.querySelector("main");
      main.innerHTML = "";
      main.appendChild(pageElement);
    }

    window.scrollTo(0, 0);
  },
};

export default Router;