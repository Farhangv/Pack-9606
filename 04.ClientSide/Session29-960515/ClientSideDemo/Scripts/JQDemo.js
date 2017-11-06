/// <reference path="jquery-1.12.4.js" />
(function () {
    //var mainDiv = document.getElementById("main");
    //$(mainDiv).text("Hello");
    //$("#main").text("Hello");

    //$("#submit").on("click", function () {
    //    var inputName = $("#name").val();
    //    $("#result").text("سلام " + inputName);
    //});

    $("#submit").on("click", function () {
        var todoText = $("#todo").val();
        var dueDate = $("#date").val();
        //debugger;
        //var $tr =
        //Chainig
        $("<tr></tr>")
            .append($("<td></td>").text(todoText))
            .append($("<td></td>").text(dueDate))
            .append($("<td></td>")
                .append(
                    $("<button>").addClass("btn btn-danger btn-xs")
                    .html("<span class='glyphicon glyphicon-remove'></span>")
                    .on("click", function () {
                        //context:button
                        //$(this).parent().parent().remove();
                        $(this).parentsUntil("tbody").remove();
                        //$(this).parent().parent().siblings().remove();
                    })
                )
                .append($("<button>").addClass("btn btn-primary btn-xs")
                .html("<span class='glyphicon glyphicon-pencil'></span>"))
            )
            .appendTo($("#todo-table tbody"));


        //$("#todo-table").append($tr);
    });
})();