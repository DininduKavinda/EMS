var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/distribution/distributionPoint/getAll'
        },
        columns: [
            { data: 'name' },
            { data: 'address' },
            { data: 'description' },   
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/distribution/distributionPoint/upsert?id=${data}" data-id="${data}" data-toggle="modal" data-target="#exampleModal" class="btn btn-warning mx-2  edit-button">Edit</a>
                    <a onClick=Delete('/distribution/distributionPoint/delete?id=${data}') class="btn btn-danger mx-2">Delete</a>
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
        url: '/distribution/distributionPoint/getById?id=' + id,
        type: 'GET',
        success: function (result) {
            $("#exampleModal input[name='Id']").val(result.data.id);
            $("#exampleModal input[name='Name']").val(result.data.name);
            $("#exampleModal input[name='Address']").val(result.data.address);
            $("#exampleModal input[name='Description']").val(result.data.description);
            $("#exampleModal").modal({ backdrop: 'static' });
        },
        error: function (error) {
            console.log(error);
            $("#exampleModal").modal('close');
        }
    });
});

