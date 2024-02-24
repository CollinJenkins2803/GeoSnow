'use strict';

/**
 * navbar toggle
 */
const navToggleBtn = document.querySelector("[data-nav-toggle-btn]");
const header = document.querySelector("[data-header]");

navToggleBtn.addEventListener("click", function () {
    this.classList.toggle("active");
    header.classList.toggle("active");
});


initializeNavToggle();

/** Use Location */
function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition, showError);
    } else {
        alert("Geolocation is not supported by this browser.");
    }
}

function showPosition(position) {
    document.getElementById("latTxt").value = position.coords.latitude;
    document.getElementById("longTxt").value = position.coords.longitude;
    getAddress(position.coords.latitude, position.coords.longitude);
}

async function getAddress(lat, long) {
    try {
        const response = await fetch(`https://nominatim.openstreetmap.org/reverse?lat=${lat}&lon=${long}&format=json`);
        const data = await response.json();
        if (data.address) {
            displayAddress(data.address);
        } else {
            alert("Address not found.");
        }
    } catch (error) {
        alert("Error fetching address: " + error.message);
    }
}

function displayAddress(address) {
    let location = address.city || address.town || address.village || "Unknown location";
    document.getElementById("locInp").value = location + ', ' + address.state;
}

function addLocationFormListen() {
    document.getElementById('locationForm').addEventListener('submit', function(e) {
        e.preventDefault();
        let userInput = document.getElementById('locInp').value;
        let latitude = document.getElementById('latTxt').value;
        let longitude = document.getElementById('longTxt').value;
        if (latitude && longitude) {
            this.submit();
        } else {
            getCoordinates(userInput);
        }
    });
}

async function getCoordinates(address) {
    try {
        const response = await fetch(`https://nominatim.openstreetmap.org/search?format=json&q=${address}`);
        const data = await response.json();
        if (data.length > 0) {
            const coords = { lat: data[0].lat, lon: data[0].lon };
            displayCoordinates(coords);
        } else {
            alert("No results found for the given address.");
        }
    } catch (error) {
        alert("Error fetching coordinates: " + error.message);
    }
}

function displayCoordinates(coords) {
    document.getElementById('results').innerHTML = `Coordinates: ${coords.lat}, ${coords.lon}`;
    document.getElementById('latTxt').value = coords.lat;
    document.getElementById('longTxt').value = coords.lon;
}

function showError(error) {
    switch (error.code) {
        case error.PERMISSION_DENIED:
            alert("User denied the request for Geolocation.");
            break;
        case error.POSITION_UNAVAILABLE:
            alert("Location information is unavailable.");
            break;
        case error.TIMEOUT:
            alert("The request to get user location timed out.");
            break;
        case error.UNKNOWN_ERROR:
            alert("An unknown error occurred.");
            break;
    }
}
