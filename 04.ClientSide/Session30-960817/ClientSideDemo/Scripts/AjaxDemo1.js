/// <reference path="jquery-1.12.4.js" />

(function () {
    //$(document).on("ready", function () {

    //});
    //$(document).ready(function () {

    //});
    $(function () {
        $("#get-data").on("click", function () {
            $("div#result").load("/JQDemo.html");
        });
    });
})();