$("#actorID").change(function () {
    var optionSelected = $("option:selected", this);
    var optionName = optionSelected.text();
    $("#actorName").val(optionName);
});

$("#directorID").change(function () {
    var optionSelected = $("option:selected", this);
    var optionName = optionSelected.text();
    $("#directorName").val(optionName);
});

$("#addActor").click(function () {

    var data = {
        Name: $("#actorName").val(),
        Nationality: $("#actorNationality").val(),
        Birthday: $("#actorBirthday").val()
    };

    $.ajax({
        type: "POST",
        url: "/Actor/CreateActorAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            $("#actorID").append("<option value = " + data.id + ">" + data.name + "</option>");
        },
        error: function () {
            alert("Error adding new actor!");
        }
    });

})

$("#addDirector").click(function () {

    var data = {
        Name: $("#directorName").val(),
        Nationality: $("#directorNationality").val(),
        Birthday: $("#directorBirthday").val()
    };

    $.ajax({
        type: "POST",
        url: "/Director/CreateDirectorAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            $("#directorID").append("<option value = " + data.id + ">" + data.name + "</option>");
        },
        error: function () {
            alert("Error adding new director!");
        }
    });

})

