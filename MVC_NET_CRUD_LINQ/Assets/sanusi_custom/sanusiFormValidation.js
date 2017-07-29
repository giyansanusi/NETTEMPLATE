//Sanusi Form Validation V 1.00
//Author : Muhammad Giyan Sanusi
//20 May 2017

//make sure scripts run when page fully loaded
$(document).ready(function () {
    
    //REALTIME VALIDATION

    // Standard Input
    $('input#focusedinput').on('input', function () {
        var input = $(this);
        var is_name = input.val();
        
        if (is_name)
        {
            input.removeClass("invalid").addClass("valid");
            $("#focusedinputtext").empty();
            $("#focusedinputtext").append("Splendid!");
            $("#focusedinputtext").css("color", "#00ff00");
        }
        else
        {
            input.removeClass("valid").addClass("invalid");
            $("#focusedinputtext").empty();
            $("#focusedinputtext").append("Required!");
            $("#focusedinputtext").css("color", "#ff0000");
        }
    });

    // Password
    $('input#inputPassword').on('input', function () {
        var input = $(this);
        var is_name = input.val();

        if (is_name) {
            input.removeClass("invalid").addClass("valid");
            $("#inputPasswordText").empty();
            $("#inputPasswordText").append("Splendid!");
            $("#inputPasswordText").css("color", "#00ff00");
        }
        else {
            input.removeClass("valid").addClass("invalid");
            $("#inputPasswordText").empty();
            $("#inputPasswordText").append("Required!");
            $("#inputPasswordText").css("color", "#ff0000");
        }
    });


    //CheckBox
    $('input#checkbox').change(function () {
        if ($(this).is(':checked')) {
            $("#checkBoxText").empty();
            $("#checkBoxText").append("Checked");
            $("#checkBoxText").css("color", "#00ff00");
        } else {
            $("#checkBoxText").empty();
            $("#checkBoxText").append("Unchecked");
            $("#checkBoxText").css("color", "#ff0000");
        }
    });

    //Dropdown
    $('#dropdown').change(function () {
        var val = $('#dropdown').val();

        $("#dropdownText").empty();
        $("#dropdownText").append(val);

    });

    //Multiple Select
    $('#multipleSelect').change(function () {
        var val = $('#multipleSelect').val();

        $('#multipleSelectText').empty();
        $('#multipleSelectText').append(val);
    });

    //Radiobutton
    $('#radioption1').change(function () {
        $('#radioption2').prop('checked', false);
        $('#radioptionText').empty();
        $('#radioptionText').append("radioption1");
    });

    $('#radioption2').change(function () {
        $('#radioption1').prop('checked', false);
        $('#radioptionText').empty();
        $('#radioptionText').append("radioption2");
    });





    //VALIDATION WHEN SUBMIT

    //check data using Ajax


});