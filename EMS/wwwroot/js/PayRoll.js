var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/payroll/getAll',
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
                    var workDays = row.payRoll ? row.payRoll.workDays : null;

                    if (workDays != null) {
                        return workDays;
                    } else {
                        // Get the current date
                        var currentDate = new Date();

                        // Calculate the first day of the current month
                        var firstDayOfCurrentMonth = new Date(currentDate.getFullYear(), currentDate.getMonth(), 1);

                        // Filter the attendanceList for records in the past month
                        var attendanceListPastMonth = row.attendanceList.filter(function (attendance) {
                            // Assuming attendance_date is a string in the format 'YYYY-MM-DD'
                            var attendanceDate = new Date(attendance.attendance_date);
                            return attendanceDate >= firstDayOfCurrentMonth;
                        });

                        // Return the count of attendance records for the past month
                        return attendanceListPastMonth.length;
                    }
                }
            },
            {
                data: null,
                render: function (data, type, row) {
                    if (row.employee.jobTitle.salaryTypeID === 1) {              
                        var epfSum = row.employee.jobTitle.baseSalary * row.attendanceList.length;
                        return epfSum;
                    } else {
                        var epfSum = row.employee.jobTitle.baseSalary - row.employee.jobTitle.empoyeeEPF;
                        return epfSum;
                    }
                },
            },
            
            { data: 'payRoll.advanced' },        
            { data: 'payRoll.allowances' },  
            { data: 'payRoll.netSalary' },  
            { data: 'payRoll.createdBy' },
            { data: 'payRoll.approvedBy' },
            { data: 'payRoll.payedDate' }, 
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/admin/payroll/upsert?id=${data}" class="btn btn-info mx-2">Payments</a>
                    </div>`;
                }
            }
        ]
    });
}
