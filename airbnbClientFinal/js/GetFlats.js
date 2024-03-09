$(document).ready(function() {
    let port = 7244;
    server = `https://localhost:${port}/`;
    GetFlats();
});
function GetFlats() {
    api = server + "api/Flats";
    ajaxCall("GET", api, "", getSCB, getECB);
}
// success callback function
function getSCB(FlatList) {
    console.log(FlatList);
    str = "";
    tmpID = 0;
    for (var i = 0; i < FlatList.length; i++) {
        str += `<div id="DivFlat"><p>Flat Id is: ${FlatList[i].id}</p><p>Flat city is: ${FlatList[i].city}</p><p>Flat address is: ${FlatList[i].address}</p></p><p>Flat price is: ${FlatList[i].price}</p></p><p>Flat number of rooms is: ${FlatList[i].numOfRooms}</p><button id="OrderVacationBTN" onclick="OrderVacation(${FlatList[i].id})">Order Vacation</button></div>`;
        tmpID = FlatList[i].id;
    }
    document.getElementById("ph").innerHTML = str;

}
// error callback function
function getECB(errorFromServer) {
    console.log(errorFromServer);
}
function SubmitFlat() {
    let f = {
        Id: $("#IdTB").val(),
        City: $("#CityTB").val(),
        Address: $("#AddressTB").val(),
        Price: Number($("#PriceTB").val()),
        NumOfRooms: $("#numOfRoomsTB").val()
    };

    if (f.Id == "" || f.City == "" || f.Address == "" || f.Price == "" || f.NumOfRooms == "") {
        alert("All data are required!");
        return;
    }



    if (f.Address.length > 25) {
        alert("The address cannot exceed 25 characters");
        return;
    }


    if (Number(f.NumOfRooms) > 8) {
        alert("Number of rooms cannot exceed 8.");
        return;
    }


    api = server + "api/Flats";

    ajaxCall("POST", api, JSON.stringify(f), postSCB, postECB);
    GetFlats();
}
// success callback function
function postSCB(objectFromServer) {
    console.log(objectFromServer);
}
// error callback function
function postECB(errorFromServer) {
    console.log(errorFromServer);
}
function OrderVacation(x) {
    sessionStorage.setItem("FlatID", `${x}`);
    window.location.href = 'VacationPage.html';
}
