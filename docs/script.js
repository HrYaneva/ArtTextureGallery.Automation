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

// THEME TOGGLE (Dark / Light)
const themeBtn = document.querySelector(".theme-toggle");

// Load saved theme
if (localStorage.getItem("theme") === "light") {
    document.body.classList.add("light-mode");
    themeBtn.textContent = "☀️";
}

// Toggle theme
themeBtn.addEventListener("click", () => {
    document.body.classList.toggle("light-mode");

    if (document.body.classList.contains("light-mode")) {
        localStorage.setItem("theme", "light");
        themeBtn.textContent = "☀️";
    } else {
        localStorage.setItem("theme", "dark");
        themeBtn.textContent = "🌙";
    }
});

// PREMIUM LOADING ANIMATION
window.addEventListener("load", () => {
    const loader = document.getElementById("loader");
    setTimeout(() => {
        loader.classList.add("hide");
    }, 600);
});
