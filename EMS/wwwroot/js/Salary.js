var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/salary/getAll',
             dataSrc: 'data'
        },
        columns: [
            { data: 'employee.emp_Cid' },
            { data: 'employee.department.department_Name' },
            { data: 'employee.emp_full_name' },
            { data: 'employee.emp_NIC' },
            { data: 'employee.jobTitle.jt_name' },
            { data: 'employee.jobTitle.baseSalary' },
            { data: 'employee.jobTitle.salaryType.st_name' },
            { data: 'employee.jobTitle.empoyeeEPF' },
            {
                data: null,
                render: function (data, type, row) {
                    // Calculate the sum of employeeEPF and empoyeeEPF
                    var epfSum = row.employee.jobTitle.empoyeerEPF + row.employee.jobTitle.empoyeerETF;
                    return epfSum;
                }
            },           
            {
                data: null,
                render: function (data, type, row) {
                    // Check if salaryTypeID is equal to 1
                    if (row.employee.jobTitle.salaryTypeID === 1) {
                        // Calculate the sum of employeeEPF and empoyeeEPF, considering max basesalary*26
                        var epfSum = Math.min(row.employee.jobTitle.baseSalary * 26);
                        return epfSum;
                    } else {
                        // Calculate the sum of employeeEPF and empoyeeEPF
                        var epfSum = row.employee.jobTitle.baseSalary - row.employee.jobTitle.empoyeeEPF;
                        return epfSum;
                    }
                }
            },
            {
                data: null,
                render: function (data, type, row) {
                    var currentDate = new Date();
                    var lastMonthDate = new Date(currentDate);
                    lastMonthDate.setMonth(currentDate.getMonth() - 1);

                    var attendanceCount = row.attendanceList.reduce(function (count, attendance) {
                        var attendanceDate = new Date(attendance.attendance_date);

                        if (
                            attendanceDate.getFullYear() === lastMonthDate.getFullYear() &&
                            attendanceDate.getMonth() === lastMonthDate.getMonth()
                        ) {
                            return count + 1;
                        } else {
                            return count;
                        }
                    }, 0);

                    return attendanceCount;
                }
            },
            {
                data: 'employee.id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/admin/salary/upsert?id=${data}" class="btn btn-info mx-2">Prapare</a>
                    </div>`;
                }
            }
        ]
    });
}