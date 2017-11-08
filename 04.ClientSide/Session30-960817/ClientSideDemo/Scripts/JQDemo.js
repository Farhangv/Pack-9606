/// <reference path="jquery-1.12.4.js" />
(function () {

    function beginEditRow()
    {
        $("tr.editable").siblings().each(function () {
            $(this).children().last().children("button").addClass("disabled")
                .attr("disabled","disabled");
        });
        
        $("#todo").val(
            $("tr.editable").children(".todo-text").text());
        $("#date").val(
            $("tr.editable").children(".due-date").text());
        $("#submit").addClass("edit-mode");
    }
    function saveEditedRow()
    {

        $("tr.editable").children(".todo-text").text(
            $("#todo").val());
        $("tr.editable").children(".due-date").text(
            $("#date").val());
        $("#todo").val("");
        $("#date").val("");
        $("#submit").removeClass("edit-mode");
        $("tr.editable").siblings().each(function () {
            $(this).children().last().children("button").removeClass("disabled")
                .removeAttr("disabled");
        });

        $("tr.editable").removeClass("editable");

    }

    $("#submit").on("click", function () {
        if ($(this).hasClass("edit-mode")) { //Edit-Mode
            saveEditedRow();
        }
        else { //Add-Mode
            var todoText = $("#todo").val();
            var dueDate = $("#date").val();
            $("#todo").val("");
            $("#date").val("");
            //debugger;
            //var $tr =
            //Chainig
            $("<tr></tr>")
                .append($("<td></td>").text(todoText).addClass("todo-text"))
                .append($("<td></td>").text(dueDate).addClass("due-date"))
                .append($("<td></td>")
                    .append(//Remove
                        $("<button>").addClass("btn btn-danger btn-xs")
                        .html("<span class='glyphicon glyphicon-remove'></span>")
                        .on("click", function () {
                            //context:button
                            //$(this).parent().parent().remove();
                            $(this).parentsUntil("tbody").remove();
                            //$(this).parent().parent().siblings().remove();
                        })
                    )
                    .append(//Edit
                        $("<button>").addClass("btn btn-primary btn-xs")
                        .html("<span class='glyphicon glyphicon-pencil'></span>")
                        .on("click", function () {
                            $(this).parent().parent().addClass("editable");
                            beginEditRow();
                        })
                    )
                )
                .appendTo($("#todo-table tbody"));
        }

        //$("#todo-table").append($tr);
    });
})();