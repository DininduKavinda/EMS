var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/distribution/vehicleMaintain/getVehiclelMaintain'
        },
        columns: [
            { data: 'maintain_Reason' },
            { data: 'maintain_Date' },
            { data: 'maintain_Cost' },
            { data: 'maintain_Details' },
            { data: 'maintain_Status' },
            { data: 'maintain_By' },
            { data: 'maintainImage' },
            { data: 'id', }
             
        ]
    });
}