var ToDoList = {

    init: function () {
        $("#btn").on("click", function () {
            var data = "content=" + $("#content").val();
            $.ajax({
                url: "/ToDoList/Insert",
                type: "POST",
                dataType: "json",
                data: {
                    content: $("#content").val()
                },
                success: function (data) {
                    location.reload();
                },
                error: function (data) {
                    alert(data.responseText);
                }
            }).done();
            $("#content").val("");
        });
    }
}