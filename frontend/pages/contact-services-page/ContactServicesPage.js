export class ContactServicesPage extends HTMLElement{
    constructor(){
        super();
        this.root = this.attachShadow({ mode: "open" });
    }
    connectedCallback(){
      const template = document.getElementById("contact-services-page-template");
      const content = template.content.cloneNode(true);
      this.root.appendChild(content);
    }
}

customElements.define("contact-services-page", ContactServicesPage);