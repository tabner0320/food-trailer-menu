const welcomeScreen =
    document.getElementById("welcomeScreen");

const websiteContent =
    document.getElementById("websiteContent");

const enterMenuButton =
    document.getElementById("enterMenuButton");

const menuContainer =
    document.getElementById("menuContainer");


enterMenuButton.addEventListener("click", () => {
    welcomeScreen.style.display = "none";

    websiteContent.classList.remove("hidden");

    loadMenu();
});


async function loadMenu() {
    try {
        menuContainer.innerHTML =
            "<p>Loading menu...</p>";

        const response =
            await fetch("/api/menu");

        if (!response.ok) {
            throw new Error(
                `Unable to load menu. Status: ${response.status}`
            );
        }

        const menuItems =
            await response.json();

        displayMenu(menuItems);
    }
    catch (error) {
        console.error(error);

        menuContainer.innerHTML = `
            <div class="menu-card">
                <h3>Menu unavailable</h3>

                <p>
                    We could not load the menu right now.
                    Please try again.
                </p>
            </div>
        `;
    }
}


function displayMenu(menuItems) {
    menuContainer.innerHTML = "";

    if (!Array.isArray(menuItems) ||
        menuItems.length === 0) {

        menuContainer.innerHTML = `
            <div class="menu-card">
                <h3>No menu items available</h3>
            </div>
        `;

        return;
    }


    menuItems.forEach((item) => {
        const card =
            document.createElement("article");

        card.classList.add("menu-card");

        card.innerHTML = `
            <span class="menu-category">
                ${item.category}
            </span>

            <h3>${item.name}</h3>

            <p class="menu-price">
                $${Number(item.price).toFixed(2)}
            </p>

            <p class="
                availability
                ${
                    item.isAvailable
                        ? "available"
                        : "unavailable"
                }
            ">
                ${
                    item.isAvailable
                        ? "✓ Available"
                        : "Unavailable"
                }
            </p>
        `;

        menuContainer.appendChild(card);
    });
}