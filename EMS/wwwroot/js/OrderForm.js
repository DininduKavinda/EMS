var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/user/orderform/getAll',
            dataSrc: 'data'
        },
        columns: [
            { data: 'orderForm_No' },
            { data: 'customer.customer_Shop_Name' },
            { data: 'salesExecutive.employee.emp_full_name' },
            { data: 'customer.customer_Address' },
            { data: 'customer.customer_Road' },
            { data: 'salesExecutive.sale_Exe_Route' },
            {
                data: 'orderForm_Date',
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
                data: 'orderRequired_Date',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the date part from the datetime string
                        var datePart = data.split('T')[0];
                        return datePart;
                    }
                    return data; // Return the full datetime for other types
                } },
            {
                data: 'orderForm_EnteredDate',
                render: function (data, type, row) {
                    if (type === 'display') {
                        // Extract the date part from the datetime string
                        var datePart = data.split('T')[0];
                        return datePart;
                    }
                    return data; // Return the full datetime for other types
                } },
            {
                data: 'status.statusName',
                render: function (data, type, row) {
                        return `<span class="badge bg-success">${data}</span>`;
                }
            },
           
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/user/orderForm/upsert?id=${data}" class="btn btn-info mx-2">View</a>
                    </div>`;
                }
            }
        ]
    });
}