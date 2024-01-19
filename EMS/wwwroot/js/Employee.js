var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/employee/getAll'
        },
        columns: [
            { data: 'emp_Cid' },
            { data: 'department.department_Name'},
            { data: 'emp_full_name' },
            {
                data: 'emp_DateOfBirth',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the date part from the datetime string
                        var datePart = data.split('T')[0];
                        return datePart;
                    }
                    return data; // Return the full datetime for other types
                }            },
            { data: 'emp_NIC' },
            { data: 'jobTitle.jt_name' },
            { data: 'emp_contact_info' },
            {
                data: 'emp_start_date',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the date part from the datetime string
                        var datePart = data.split('T')[0];
                        return datePart;
                    }
                    return data; // Return the full datetime for other types
                }            },        
            {
                data: 'emp_Is_active',
                render: function (data, type, row) {
                    if (data === 0) {
                        return '<button class="btn btn-danger">Deactivate</button>';
                    } else {
                        return '<button class="btn btn-success">Activate</button>';
                    }
                }
            },
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
