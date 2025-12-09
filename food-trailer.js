const grid = document.getElementById("menuGrid");
const filterButtons = Array.from(document.querySelectorAll(".filter-btn"));
const searchInput = document.getElementById("menuSearch");

// Year in footer
document.getElementById("year").textContent = new Date().getFullYear();

function applyFilters() {
  const active =
    filterButtons.find(b => b.getAttribute("aria-pressed") === "true")?.dataset
      .filter || "all";
  const query = (searchInput.value || "").toLowerCase();

  for (const card of grid.querySelectorAll(".menu-card")) {
    const category = card.dataset.category;              // meals/sides/drinks
    const tags = (card.dataset.tags || "").toLowerCase();
    const text = card.textContent.toLowerCase();
    const matchesCategory = active === "all" || category === active;
    const matchesSearch = !query || text.includes(query) || tags.includes(query);
    card.style.display = matchesCategory && matchesSearch ? "" : "none";
  }
}

filterButtons.forEach(btn => {
  btn.addEventListener("click", () => {
    filterButtons.forEach(b => b.setAttribute("aria-pressed", "false"));
    btn.setAttribute("aria-pressed", "true");
    applyFilters();
  });
});

searchInput.addEventListener("input", applyFilters);

// Initial render
applyFilters();
