var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/payRoll/getAll',
            dataSrc: 'data'
        },
        columns: [
            { data: 'employee.emp_Cid' },
            { data: 'employee.department.department_Name' },
            { data: 'employee.emp_full_name' },
            { data: 'payedDate' },
            { data: 'employee.jobTitle.jt_name' },
            { data: 'employee.jobTitle.baseSalary' },
            { data: 'employee.jobTitle.empoyeeEPF' },
            { data: 'workDays' },
            {
                data: null,
                render: function (data, type, row) {
                    if (row.employee.jobTitle.salaryTypeID === 1) {
                        var epfSum = row.employee.jobTitle.baseSalary * row.workDays;
                        return epfSum;
                    } else {
                        var epfSum = row.employee.jobTitle.baseSalary - row.employee.jobTitle.empoyeeEPF;
                        return epfSum;
                    }
                },
            },

            { data: 'advanced' },
            { data: 'allowances' },
            { data: 'netSalary' },
            {
                data: 'id',
                render: function (data, type, row) {
                    return `
                        <div class="w-75 btn-group" role="group">
                            <a href="/admin/payRoll/payments?id=${data}" class="btn btn-success mx-2">
                            PaySlip
                            </a>
                        </div>`;
                }
            }
        ]
    });
}