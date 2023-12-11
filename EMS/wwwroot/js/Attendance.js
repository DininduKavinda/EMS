var dataTable;
$(document).ready(function () {
    loadDataTable();
});  
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/attendance/getAll'
        },
        columns: [
            {
                data: 'attendance_date',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the date part from the datetime string
                        var datePart = data.split('T')[0];
                        return datePart;
                    }
                    return data; // Return the full datetime for other types
                }
            },
            { data: 'employee.emp_full_name' },
            {
                data: 'attendance_in_time',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the time part from the datetime string
                        var timePart = data.split('T')[1];
                        return timePart;
                    }
                    return data; // Return the full datetime for other types
                }
            },
            {
                data: 'attendance_in_image',
                render: function (data, type, row) {
                    return '<img src="' + data + '" alt="Employee Image" width="70" height="50">';
                }
            },
            {
                data: 'attendance_out_time',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the time part from the datetime string
                        var timePart = data.split('T')[1];
                        return timePart;
                    }
                    return data; // Return the full datetime for other types
                }
            },
            {
                data: 'attendance_out_image',
                render: function (data, type, row) {
                    if (data === 'empty' || data === null) {
                        return `<a href="/admin/attendance/create?id=${row.id}" class="btn btn-success mx-2"> Sign Me </a>`;
                    } else {
                        return `<img src="${data}" alt="Employee Image" width="70" height="50">`;
                    }
                }
            },   
        ]
    });
}
