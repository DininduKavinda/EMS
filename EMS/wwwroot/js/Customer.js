var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/user/customer/getAll'
        },
        columns: [
            { data: 'id' },
            { data: 'customer_Shop_Name' },
            { data: 'customer_Name' },
            { data: 'customer_Address' },
            { data: 'customer_Contact_No' },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="/user/customer/upsert?id=${data}" data-toggle="modal" data-target="#insertModel${data}" class="btn btn-warning mx-2">Edit</a>
                    <a onClick=Delete('/user/customer/delete?id=${data}') class="btn btn-danger mx-2">Delete</a>
                    </div>

                    <div class="modal fade" id="exampleModal${data}" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                </div>
                                <div class="modal-body">
                                    <input type="text" value="${data}" />
                                </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                    <button type="button" class="btn btn-primary">Save changes</button>
                                </div>
                            </div>
                        </div>
                    </div>

                    `;
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
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}