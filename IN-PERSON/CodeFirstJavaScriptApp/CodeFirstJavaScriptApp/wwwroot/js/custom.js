$(document).ready(function () {
    ShowEmployeeData();
});

function ShowEmployeeData() {
    var url = $('#urlEmployeeData').val();
    $.ajax({
        url: url,
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.id + '</td>';
                object += '<td>' + item.name + '</td>';
                object += '<td>' + item.state + '</td>';
                object += '<td>' + item.city + '</td>';
                object += '<td>' + item.salary + '</td>';
                object += '<td><a href="#" class="btn btn-primary" onclick="Edit(' + item.id + ')">Edit</a> || <a href="#" class="btn btn-danger" onclick="Delete(' + item.id + ');">Delete</a></td>';
                object += '</tr>';
            });
            $('#table_data').html(object);
        },
        error: function () {
            alert("Data can't get");
        }
    });
}

$('#btnAddEmployee').click(function () {
    ClearTextBox();
    $('#EmployeeModal').modal('show');
    $('#empId').hide();
    $('#AddEmployee').css('display', 'block');
    $('#btnUpdate').css('display', 'none');
    $('#employeeHeading').text('Add Employee');
});

function AddEmployee() {
    var objData = {
        Name: $('#Name').val(),
        State: $('#State').val(),
        City: $('#City').val(),
        Salary: $('#Salary').val()
    };

    $.ajax({
        url: '/Employee/AddEmployee',
        type: 'Post',
        data: objData,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function () {
            alert('Data Saved');
            ClearTextBox();
            ShowEmployeeData();
            HideModalPopUp();
        },
        error: function () {
            alert("Data can't Saved!");
        }
    });
}

function ClearTextBox() {
    $('#Name').val('');
    $('#State').val('');
    $('#City').val('');
    $('#Salary').val('');
    $('#EmployeeId').val('');
}

function HideModalPopUp() {
    $('#EmployeeModal').modal('hide');
}

function Delete(id) {
    if (confirm('Are you sure, You want to delete this record?')) {
        $.ajax({
            url: '/Employee/Delete?id=' + id,
            success: function () {
                alert('Record Deleted!');
                ShowEmployeeData();
            },
            error: function () {
                alert("Data can't be deleted!");
            }
        });
    }
}

function Edit(id) {
    $.ajax({
        url: '/Employee/Edit?id=' + id,
        type: 'Get',
        contentType: 'application/json;charset=utf-8',
        dataType: 'json',
        success: function (response) {
            $('#EmployeeModal').modal('show');
            $('#EmployeeId').val(response.id);
            $('#Name').val(response.name);
            $('#State').val(response.state);
            $('#City').val(response.city);
            $('#Salary').val(response.salary);
            $('#AddEmployee').css('display', 'none');
            $('#btnUpdate').css('display', 'block');
            $('#employeeHeading').text('Update Record');
        },
        error: function () {
            alert('Data not found');
        }
    });
}

function UpdateEmployee() {
    var objData = {
        Id: $('#EmployeeId').val(),
        Name: $('#Name').val(),
        State: $('#State').val(),
        City: $('#City').val(),
        Salary: $('#Salary').val()
    };

    $.ajax({
        url: '/Employee/Update',
        type: 'Post',
        data: objData,
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        dataType: 'json',
        success: function () {
            alert('Data Updated');
            HideModalPopUp();
            ShowEmployeeData();
            ClearTextBox();
        },
        error: function () {
            alert("Data can't Saved!");
        }
    });
}