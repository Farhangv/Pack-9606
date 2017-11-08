/// <reference path="jquery-1.12.4.js" />

(function () {

    $(function () {
        $("#submit").on("click", function () {
            var username = $("#username").val();
            var password = $("#password").val();

            $.ajax({
                url: "/Authentication.aspx",
                method: "POST",
                data: { "username": username, "password" : password }
            }).done(function (response) {
                $("div#server-response").html(response);
            });
        });
    });
})();