export class BookingsPage extends HTMLElement{
  constructor(){
    super();
    this.root = this.attachShadow({ mode: "open" });
    
    const styles = document.createElement("style");
    this.root.appendChild(styles);

    async function loadCSS() {
      const request = await fetch("/pages/bookings-page/bookings-page.css");
      const css = await request.text();
      styles.textContent = css;
    }

    loadCSS();
  }
  
  connectedCallback(){
    const template = document.getElementById("bookings-page-template");
    const content = template.content.cloneNode(true);
    this.root.appendChild(content);
  }
}

customElements.define("bookings-page", BookingsPage);