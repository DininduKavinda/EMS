﻿var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/jobtitle/getAll'
        },
        columns: [
            { data: 'jt_name' },
            { data: 'baseSalary' },
            { data: 'salaryType.st_name' },
            { data: 'empoyeeEPF' },
            { data: 'empoyeerEPF' },
            { data: 'empoyeerETF' },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/admin/jobtitle/upsert?id=${data}" class="btn btn-warning mx-2">Edit</a>
                    <a onClick=Delete('/admin/jobtitle/delete?id=${data}') class="btn btn-danger mx-2">Delete</a>
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
                type: 'DELETE',
                success: function (data) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
            })
        }
    })
}
