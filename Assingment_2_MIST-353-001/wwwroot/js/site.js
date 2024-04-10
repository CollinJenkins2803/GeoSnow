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
    document.getElementById('locationForm').addEventListener('submit', async function (e) {
        e.preventDefault();
        let latitude = document.getElementById('latTxt').value;
        let longitude = document.getElementById('longTxt').value;
        let startDate = document.getElementById('startDateInp').value;
        let endDate = document.getElementById('endDateInp').value;
        let radius = document.getElementById('radiusDrop').value;

        // Use previously fetched coordinates or fetch based on the user input.
        if (!latitude || !longitude) {
            let userInput = document.getElementById('locInp').value;
            await getCoordinates(userInput); // This function should set latTxt and longTxt values.
            latitude = document.getElementById('latTxt').value;
            longitude = document.getElementById('longTxt').value;
        }

        // Construct the correct URL.
        const searchURL = `https://localhost:7113/Shared/SearchResults?latitude=${latitude}&longitude=${longitude}&startDate=${startDate}&endDate=${endDate}&radius=${radius}`;
        window.open(searchURL, '_blank'); // Redirect to the constructed URL.
      //window.location.href = searchURL;
    });
}


async function getCoordinates(address) {
    try {
        const response = await fetch(`https://nominatim.openstreetmap.org/search?format=json&q=${address}`);
        const data = await response.json();
        if (data.length > 0) {
            document.getElementById('latTxt').value = data[0].lat;
            document.getElementById('longTxt').value = data[0].lon;
        } else {
            alert("No results found for the given address.");
        }
    } catch (error) {
        alert("Error fetching coordinates: " + error.message);
    }
}

//function displayCoordinates(coords) {
//    document.getElementById('results').innerHTML = `Coordinates: ${coords.lat}, ${coords.lon}`;
//    document.getElementById('latTxt').value = coords.lat;
//   document.getElementById('longTxt').value = coords.lon;
//}

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
    async function displayResortDetails(ResortID) {
        const response = await fetch(`https://localhost:7293/api/Resort/${ResortID}`);
        const data = await response.json();
        document.getElementById('ResortName').innerHTML = data[0].name;
        document.getElementById('ResortName').style.visibility = "visible";

        document.getElementById('ResortAddress').innerHTML = data[0].address + ", " + data[0].city + ", " + data[0].state + ", " + data[0].zipcode + ", " + data[0].country;
        document.getElementById('ResortAddress').style.visibility = 'visible';

        document.getElementById('ResortContact').innerHTML = data[0].phone + ", " + data[0].email;
        document.getElementById('ResortContact').style.visibility = 'visible';

    }

    async function displaySearchResults(latitude, longitude, startDate, endDate, radius) {
        const response = await fetch(`https://localhost:7293/api/Resort/searchByRadiusDateRange?latitude=${latitude}&longitude=${longitude}&startDate=${startDate}&endDate=${endDate}&radius=${radius}`);
        const data = await response.json();
        let innerHtml = "";
        if (Array.isArray(data)) { // Check if data is an array
            for (let i = 0; i < data.length; i++) {
                // Make sure the property names here are correct
                innerHtml += `<div class="card"><a href="https://localhost:7113/Resort?ResortID=${data[i].ResortID}">${data[i].name}</a></div>`;
            }
        } else {
            // Handle cases where data might not be an array
            console.error('Data is not in the expected format', data);
        }
        document.getElementById('ResortResults').innerHTML = innerHtml;
        document.getElementById('ResortResults').style.visibility = 'visible';
    }

document.getElementById('newsletterForm').addEventListener('submit', async function (e) {
    e.preventDefault();

    const email = document.getElementById('newsletterEmail').value;
    const messageElement = document.getElementById('newsletterMessage');

    try {
        // Check if the email is already subscribed
        const checkResponse = await fetch(`https://localhost:7293/api/Newsletter/check-subscription?email=${email}`);
        const isSubscribed = await checkResponse.json();

        if (isSubscribed) {
            messageElement.textContent = 'This email is already subscribed.';
        } else {
            // Add the subscriber
            const addResponse = await fetch(`https://localhost:7293/api/Newsletter/add-subscriber?email=${email}`, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({ email: email })
            });

            if (addResponse.ok) {
                messageElement.textContent = 'Thank you for subscribing!';
            } else {
                messageElement.textContent = 'There was an error subscribing. Please try again.';
            }
        }
    } catch (error) {
        console.error('Error subscribing to newsletter:', error);
        messageElement.textContent = 'There was an error subscribing. Please try again.';
    }
});

/*
async function addForumPost(resortId, posterName, postTitle, postContent) {
    const response = await fetch(`https://localhost:7293/api/Forum/add-forum-post`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ resortId, posterName, postTitle, postContent })
    });
    console.log(await response.text());
    return response.ok;
}*/

async function addForumPost(resortId, posterName, postTitle, postContent) {
    try {
        const response = await fetch('https://localhost:7293/api/Forum/add-forum-post', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                ResortID: resortId,
                PosterName: posterName,
                Title: postTitle,
                Content: postContent
            })
        });
        return response.ok;
    } catch (error) {
        console.error('Error adding forum post:', error);
        return false;
    }
}


async function deleteForumPost(postID) {
    const response = await fetch(`https://localhost:7293/api/Forum/delete-forum-post/${postID}`, {
        method: 'DELETE'
    });
   
    return response.ok;
}

