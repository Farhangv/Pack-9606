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
    function addRow(text, dueDate)
    {
        $("<tr></tr>")
        .append($("<td></td>").text(text).addClass("todo-text"))
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
    function refreshTable()
    {
        $("#todo-table tbody").children().remove();
        $.getJSON("/Todo/GetTodoList", null, function (data) {
            for (var i = 0; i < data.length; i++) {
                addRow(data[i].Name, data[i].DueDate);
            }
        });
    }

    $(function () {
        $(document).ajaxStart(function () {
            $("#loader").fadeIn(300);
        });
        $(document).ajaxComplete(function () {
            $("#loader").fadeOut(300);

        });

        refreshTable();
        $("#submit").on("click", function () {
            if ($(this).hasClass("edit-mode")) { //Edit-Mode
                saveEditedRow();
            }
            else { //Add-Mode
                var todoText = $("#todo").val();
                var dueDate = $("#date").val();
                $("#todo").val("");
                $("#date").val("");

                $.ajax({
                    url: "/Todo/Insert",
                    method: "POST",
                    data: {"name" : todoText, "duedate": dueDate}
                }).done(function (response) {
                    $("#server-message").fadeIn(1000)
                        .text(response);
                    setTimeout(function () {
                        $("#server-message").fadeOut(1000)
                    }, 3000);
                });
                refreshTable();

            }

            //$("#todo-table").append($tr);
        });

    });
})();