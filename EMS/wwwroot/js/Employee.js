var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/product/getAll'
        },
        columns: [
            { data: 'brand.brand_Name' },
            { data: 'color.color_Name'},
            { data: 'size.size_Name' },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/admin/employee/upsert?id=${data}" class="btn btn-warning mx-2">Edit</a>
                    <a onClick=Delete('/admin/employee/delete?id=${data}') class="btn btn-danger mx-2">Delete</a>
                    </div>`;
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
                type:'DELETE',
                success: function (data) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
            })
        }
    })
}
