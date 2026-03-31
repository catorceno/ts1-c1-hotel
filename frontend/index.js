import Router from './services/Router.js';
import './pages/bookings-page/BookingsPage.js';
import './pages/contact-services-page/ContactServicesPage.js';

const routes = [
    { path: "/", component: "bookings-page" },
    { path: "/services", component: "contact-services-page" },
];

window.addEventListener("DOMContentLoaded", () => {
    Router.init(routes);
});
