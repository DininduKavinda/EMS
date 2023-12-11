var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/leave/getAll'
        },
        columns: [
            { data: 'employee.emp_Cid' },
            { data: 'employee.emp_full_name' },
            { data: 'employee.emp_contact_info' },
            {
                data: 'leave_Apply_Date',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the date part from the datetime string
                        var datePart = data.split('T')[0];
                        return datePart;
                    }
                    return data; // Return the full datetime for other types
                }
            },
            {
                data: 'leaveType.leave_Type_Name',
                render: function (data, type, row) {
                    return '<label class="badge bg-info rounded-1 fw-semibold">' + data + ' </label>';
                }
            },
            {
                data: 'leave_Acommencement_Date',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the date part from the datetime string
                        var datePart = data.split('T')[0];
                        return datePart;
                    }
                    return data; // Return the full datetime for other types
                }
            },
            {
                data: 'leave_Return_Date',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the date part from the datetime string
                        var datePart = data.split('T')[0];
                        return datePart;
                    }
                    return data; // Return the full datetime for other types
                }
            },
            {
                data: 'leave_Approved_by',
                render: function (data, type, row) {
                    if (data == 0) {
                        return '<label class="badge bg-danger rounded-3 fw-semibold">Not Approved</label>';
                    } else {
                        return '<label class="badge bg-success rounded-3 fw-semibold">Approved</label>';
                    }
                }
            },    
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/admin/leave/upsert?id=${data}" class="btn btn-success mx-2">View</a>
                    </div>`;
                }
            }
        ]
    });
}
