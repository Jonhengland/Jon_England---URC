$(document).ready(function () {

});

function search_for_students() {
    console.log("Entered function");
    var skills = document.getElementById("skills-input").value;
    var data = { desiredSkills = skills };
    var searchResults = document.getElementById("search-results");

    $.post("API/SearchForStudents", data)
        .done(function (result) {
            searchResults.innerHTML = result
        })
        .fail(function (result) {
            console.log("oops");
        })
        .always(function () {

        });
}

function ping_server() {
    var data = {};
    var label = document.getElementById("ping-status");

    $.post("API/Ping", data)
        .done(function (result) {
            label.innerHTML = result.message
        })
        .fail(function (result) {
            console.log("oops");
        })
        .always(function () {

        });
}

$("#ping-button").click(ping_server);
$("#search-button").click(search_for_students);


