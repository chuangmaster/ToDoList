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

        $(".ckb").on("click", function () {
            var data1 = $(this).attr("fld_id");
            var data2 = $(this).is(":checked");
            $ckb = $(this);
            $.ajax({
                url: "/ToDoList/Update",
                type: "POST",
                dataType: "json",
                data: {
                    fld_id: data1,
                    fld_status: data2
                },
                success: function (data) {
                    $ckb.closest("li").toggleClass("strike");
                },
                error: function (data) {
                    alert(data.responseText);
                }
            }).done();
        });
    }
}