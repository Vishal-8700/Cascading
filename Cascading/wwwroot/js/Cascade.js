
$(document).ready(function () {
    GetCountry();
    $('#country').change(function () {
        var id = $(this).val();
        $('#State').empty();
        $('#State').append('<Option>Select State</Option>');
        $('#City').empty();
        //  $('#City').append();
        $('#City').append('<Option>Select City</Option>');
        $.ajax({
            url: '/Cascade/State/'+id,
            success: function (result) {
                $.each(result, function (i, data) {
                    debugger;
                    $('#State').append('<option value=' + data.id + '>' + data.name + '</option>');

                });

            }
        });
    });
    $('#State').change(function () {
        var id = $(this).val();
        $('#City').empty();
        //  $('#City').append();
        $('#City').append('<Option>Select City</Option>');
        $.ajax({
            url: '/Cascade/City/' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#City').append('<Option value=' + data.id + '>' + data.name + '</Option>');
                });
            }

        });
    });
});
function GetCountry() {
    
    $.ajax({
        url: '/Cascade/Country',
        success: function (result) {
            $.each(result, function (i, data) {

                $('#country').append('<option value=' + data.id + '>' + data.name + '</option>');

            });

        }
    });
}



//function GetCity() {
//    $('#State').change(function () {
//        var id = $(this).val();
//        $('#City').empty();
//        //  $('#City').append();
//        $('#City').append('<Option>Select City</Option>');
//        $.ajax({
//            url: 'Cascade/City/' + id,
//            success: function (result) {
//                $.each(result, function (i, data) {
//                    $('#city').append('<Options value=' + data.id + '>' + data.name + '</Options >');
//                });
//            }

//        });
//    });
//}