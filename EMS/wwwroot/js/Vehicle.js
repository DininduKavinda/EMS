var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/distribution/vehicle/getAll'
        },
        columns: [
            { data: 'vehicleName' },
            { data: 'vehicleNumber' },
            { data: 'vehicleType_Id' },
            { data: 'description' },
            { data: 'status' },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/distribution/vehicle/upsert?id=${data}" data-id="${data}" data-toggle="modal" data-target="#exampleModal" class="btn btn-warning mx-2  edit-button">Edit</a>
                    <a onClick=Delete('/distribution/vehicle/delete?id=${data}') class="btn btn-danger mx-2">Delete</a>
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
        url: '/distribution/vehicle/getById?id=' + id,
        type: 'GET',
        success: function (result) {
            $("#exampleModal input[name='Id']").val(result.data.id);
            $("#exampleModal select[name='Vehicle.VehicleType_Id']").val(result.data.vehicleType_Id);
            $("#exampleModal input[name='Vehicle.VehicleName']").val(result.data.vehicleName);
            $("#exampleModal input[name='Vehicle.VehicleNumber']").val(result.data.vehicleNumber);
            $("#exampleModal input[name='Vehicle.Description']").val(result.data.description);
            $("#exampleModal input[name='Vehicle.Status']").val(result.data.status);
            $("#exampleModal").modal({ backdrop: 'static' });
        },
        error: function (error) {
            console.log(error);
            $("#exampleModal").modal('close');
        }
    });
});

