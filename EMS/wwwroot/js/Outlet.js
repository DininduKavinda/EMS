var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/user/outlet/getAll'
        },
        columns: [
            { data: 'outlet_Name' },
            { data: 'outlet_Address' },
            { data: 'contact_number' },
            { data: 'email' },
            { data: 'openingHours' },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/user/outlet/upsert?id=${data}" data-id="${data}" data-toggle="modal" data-target="#exampleModal" class="btn btn-warning mx-2  edit-button">Edit</a>
                    <a onClick=Delete('/user/outlet/delete?id=${data}') class="btn btn-danger mx-2">Delete</a>
                    </div>
                    `;
                }
            }
        ]
    });
}
function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}
$(document).on('click', '.edit-button', function () {
    var id = $(this).data('id');
    $.ajax({
        url: '/user/outlet/getById?id=' + id,
        type: 'GET',
        success: function (result) {
            $("#exampleModal input[name='Id']").val(result.data.id);
            $("#exampleModal input[name='Outlet_Name']").val(result.data.outlet_Name);
            $("#exampleModal input[name='Outlet_Address']").val(result.data.outlet_Address);
            $("#exampleModal input[name='Contact_number']").val(result.data.contact_number);
            $("#exampleModal input[name='Email']").val(result.data.email);
            $("#exampleModal input[name='OpeningHours']").val(result.data.openingHours);
            $("#exampleModal").modal({ backdrop: 'static' });
        },
        error: function (error) {
            console.log(error);
            $("#exampleModal").modal('close');
        }
    });
});

