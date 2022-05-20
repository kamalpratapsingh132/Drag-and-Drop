$(document).ready(function () {

    void loadData();
    hello();
});






function loadData() {

    $.ajax({
        url: 'Doctor_Staff/Show',
        type: "GET",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {

               /* html += '<ul >';*/
                /*html += '<td>' + item.id + '</td>';*/
                html += '<li class="ui-state-default">' + '<a href="https://www.google.com/" >' + item.name + '</a>' + '</li>';
            
                //html += '<td>' + item.Email + '</td>';
                //html += '<td>' + item.Password + '</td>';             
               /* html += '</ul>';*/
            });
            $('.tbody').html(html)
            //$('#PateintTable').dataTable({
            //});
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }

    });
}
















//function loadData() {

//    $.ajax({
//        url: 'Doctor_Staff/Show',
//        type: "GET",
//        dataType: "json",
//        success: function (result) {
//            var html = '';
//            $.each(result, function (key, item) {

//                html += '<tr>';
//                /*html += '<td>' + item.id + '</td>';*/
//                html += '<td>' + '<a href="https://www.google.com/" >'+ item.name + '</a>'+'</td>';
//                html += '<td>' + '</td>';
//                html += '<td>' + '</td>';
//                html += '<td>' + '</td>';
//                //html += '<td>' + item.Email + '</td>';
//                //html += '<td>' + item.Password + '</td>';             
//                html += '</tr>';
//            });
//            $('.tbody').html(html)
//            $('#PateintTable').dataTable({
//            });
//        },
//        error: function (errormessage) {
//            alert(errormessage.responseText);
//        }

//    });
//}


function Add() {
    var obj = {

        Name: $('#Name').val(),
        Email: parseInt($('#Email').val()),
        Password: $('#Password').val(),

    };
    $.ajax({
        type: "POST",
        url: '/Doctor_Staff/Create_Patient',
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(obj),
        success: function () {
            loadData();
            $('#Name').val("");
            $('#Email').val("");
            $('#Password').val("");
            alert('Record Added');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}


//function allowDrop(ev) {
//    ev.preventDefault();
//}

//function drag(ev) {
//    ev.dataTransfer.setData("text", ev.target.id);
//}

//function drop(ev) {
//    ev.preventDefault();
//    var data = ev.dataTransfer.getData("text");
//    ev.target.appendChild(document.getElementById(data));
//}


function hello() {
    $(".connectedSortable").sortable({
        connectWith: ".connectedSortable"
    }).disableSelection();
}