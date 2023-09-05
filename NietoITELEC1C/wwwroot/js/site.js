// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//const toggleButton = document.getElementById("theme");
//const htmlElement = document.documentElement;

//toggleButton.addEventListener("change", function () {
//    if (this.checked) {
//        htmlElement.classList.add("dark");
//    } else {
//        htmlElement.classList.remove("dark");
//    }
//});

const toggleButtonN = document.getElementById("night");
const htmlElement = document.documentElement;

toggleButtonN.addEventListener("change", function () {
    if (this.checked) {
        htmlElement.classList.add("dark");
    } else {
        htmlElement.classList.remove("dark");
    }
});

// Initial theme setup based on the current period
const initialPeriod = getPeriod();
if (initialPeriod === "evening") {
    htmlElement.classList.add("dark");
}

//Column swap
const column1 = document.getElementById("column1");
const column2 = document.getElementById("column2");
const toggleButton = document.getElementById("toggleButton");

let isColumn1Visible = true;

toggleButton.addEventListener("click", () => {
    if (isColumn1Visible) {
        column1.style.transform = "translateX(100%)";
        column2.style.transform = "translateX(-100%)";
    } else {
        column1.style.transform = "translateX(0)";
        column2.style.transform = "translateX(0)";
    }

    isColumn1Visible = !isColumn1Visible;
});