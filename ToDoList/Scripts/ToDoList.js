var ToDoList = {

    init: function () {
        $("#btn").on("click", function () {
            var data = $("#content").val();
            $.ajax({
                url: "/ToDoList/Insert",
                type: "POST",
                dataType: "json",
                data: {
                    content: data
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

        $(".item").on("dblclick", function () {
            var data = $(this).attr("fld_id");
            $li = $(this);
            $.ajax({
                url: "/ToDoList/Delete",
                type: "POST",
                dataType: "json",
                data: {
                    fld_id: data
                },
                success: function (data) {
                    $li.fadeOut();
                },
                error: function (data) {
                    alert(data.responseText);
                }
            }).done();
            
        });
    }
}