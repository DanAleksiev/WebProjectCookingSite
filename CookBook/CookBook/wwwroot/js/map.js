function initMap() {
    const myLatLng = { lat: -25.363, lng: 131.044 };
    const map = new google.maps.Map(document.getElementById("map"), {
        zoom: 4,
        center: myLatLng,
    });

    new google.maps.AdvancedMarkerElement({
        position: myLatLng,
        map,
        title: "Hello World!",
    });
}

window.initMap = initMap;