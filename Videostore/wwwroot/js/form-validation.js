$(function () {
    $("form[name='movieCreate']").validate({
        success: "valid",
        onkeyup: true,
        focusInvalid: true,
        errorClass: "error", // adding error class on element -> define error class in css
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
        },

        // Validation rules

        rules: {
            title: {
                required: true,
                minlength: 4
            },
            runTime: {
                required: true,
                minlength: 2
            },
            genre: {
                required: true,
                minlength: 5
            },
            rating: {
                required: false,
                number: true,
                digits: true,
            },
            description: {
                required: false,
                minlength: 10
            }
        },

        // Validation error messages

        messages: {
            title: {
                required: "Please enter movie title!",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            runTime: {
                required: "Please enter movie runtime!",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            genre: {
                required: "Please enter genre!",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            rating: {
                required: "Please enter the rating!",
                number: "Please enter numbers only!",
                digits: "Only digits are allowed in this field!",
            },
            description: {
                required: "Please enter description!",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },

        },

        submitHandler: function (form) {
            form.submit();
        }
    });

});