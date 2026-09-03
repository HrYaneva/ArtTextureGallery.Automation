document.querySelector(".cta")?.addEventListener("click", () => {
    document.querySelector("#gallery").scrollIntoView({ behavior: "smooth" });
});

// SCROLL ANIMATIONS
const observer = new IntersectionObserver(entries => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.classList.add("show");
        }
    });
});

document.querySelectorAll(".section, .card").forEach(el => {
    observer.observe(el);
});

// LIGHTBOX
document.querySelectorAll(".card img").forEach(img => {
    img.addEventListener("click", () => {
        const lightbox = document.createElement("div");
        lightbox.classList.add("lightbox");
        lightbox.innerHTML = `
            <img src="${img.src}" class="lightbox-img">
        `;
        document.body.appendChild(lightbox);

        lightbox.addEventListener("click", () => {
            lightbox.remove();
        });
    });
});
