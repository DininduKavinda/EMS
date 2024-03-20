var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/distribution/vehicleMaintain/getAll'
        },
        columns: [
            { data: 'vehicleName' },
            { data: 'vehicleNumber' },
            { data: 'vehicleType.name' },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/distribution/vehicleMaintain/lisenceUpsert?id=${data}" class="btn btn-success mx-2">Lisence</a>
                    </div>`;
                }
            },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/distribution/vehicleMaintain/insuranceUpsert?id=${data}" class="btn btn-warning mx-2">Insurance</a>
                    </div>`;
                }
            },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/distribution/vehicleMaintain/vehicelMaintainUpsert?id=${data}" class="btn btn-info mx-2">Maintain</a>
                    </div>`;
                }
            },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/distribution/vehicleMaintain/serviceUpsert?id=${data}" class="btn btn-secondary mx-2">Service</a>
                    </div>`;
                }
            },
            { data: 'status' }
        ]
    });
}
