function calculate(fromCity, toCity) {
    let request = {
        origin: fromCity,
        destination: toCity,
        travelMode: google.maps.TravelMode.DRIVING,
    }

    directionsService.route(request, function (result, status) {
        if (status == google.maps.DirectionsStatus.OK) {
            const distance = document.querySelector('#distance');
            const duration = document.querySelector('#duration');
            distance.innerHTML = "Mesafe: " + result.routes[0].legs[0].distance.text;
            duration.innerHTML = "Süre: " + result.routes[0].legs[0].duration.text;
            directionsDisplay.setDirections(result);
        }
    })
}

let myLocation = {
    lat: 41.0082,
    lng: 28.9784
}

let mapOptions = {
    center: myLocation,
    zoom: 7,
    mapTypeId: google.maps.MapTypeId.ROADMAP
}

let map = new google.maps.Map(document.getElementById('googleMap'), mapOptions);

var directionsService = new google.maps.DirectionsService();
var directionsDisplay = new google.maps.DirectionsRenderer();

directionsDisplay.setMap(map);

var parentElement = document.querySelector("#items");
var rowChildren = document.querySelectorAll(".car-item");
rowChildren.forEach(function (element, index) {
    element.addEventListener("click", function () {
        calculate(element.children[1].outerText, element.children[2].outerText)
    });
});