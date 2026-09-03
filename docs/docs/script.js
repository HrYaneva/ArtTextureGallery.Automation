document.addEventListener("DOMContentLoaded", () => {
    const cta = document.querySelector(".cta");
    cta.addEventListener("click", () => {
        window.scrollTo({
            top: document.querySelector("#intro").offsetTop,
            behavior: "smooth"
        });
    });
});
