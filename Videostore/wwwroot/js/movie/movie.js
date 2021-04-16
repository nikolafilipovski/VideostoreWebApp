////$("#addNewActor").click(function () {

////    var data = {
////        Name: $("#actorName").val(),
////        Nationality: $("#actorNationality").val(),
////        DateOfBirth: $("#actorBirthday").val()
////    };

////    $.ajax({
////        type: "POST",
////        url: "/Actor/CreateActorAJAX",
////        data: data,
////        dataType: "json",
////        success: function (data) {
////            if (data.data == '') {
////                $('#actorModal').modal('toggle');
////                setTimeout(() => {
////                    alert("Error: Actor has NOT been added! Please enter data in all the fields!");
////                }, 500);
////            } else {
////                $("#actorID").append("<option value=" + data.data.id + ">" + data.data.Name + "</option>");
////                $("#actorID").val(data.data.id);
////                var newOptionSelected = $("#actorID option:selected").text();
////                $("#actorName").val(newOptionSelected);
////                $('#actorModal').modal('toggle');
////            }
////        },
////        error: function () { alert("Error Adding New Actor!"); }
////    });
////});

////$("#actorID").change(function () {
////    var optionSelected = $("option:selected", this);
////    var optionName = optionSelected.text();
////    $("#actorName").val(optionName);
////});
