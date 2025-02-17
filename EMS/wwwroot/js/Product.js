﻿var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/user/product/getAll'
        },
        columns: [
            { data: 'brand.brand_Name' },
            { data: 'color.color_Name'},
            { data: 'size.size_Name' },
            {
                data: 'id',
                render: function (data) {
                    return `
                    <div class="w-75 btn-group" role="group">
                    <a href="#" data-id="${data}" data-toggle="modal" data-target="#exampleModal" class="btn btn-warning mx-2  edit-button">Edit</a>
                    <a onClick=Delete('/user/product/delete?id=${data}') class="btn btn-danger mx-2">Delete</a>
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
                    dataTable.ajax.reload();
                    toastr.success(data.message); 
                }
            })
        }
    })
}
$(document).on('click', '.edit-button', function () {
    var id = $(this).data('id');
    $.ajax({
        url: '/user/product/getById?id=' + id,
        type: 'GET',
        success: function (result) {
            $("#exampleModal input[name='Product.Id']").val(result.data.id);
            $("#exampleModal select[name='Product.BrandId']").val(result.data.brandId);
            $("#exampleModal select[name='Product.ColorId']").val(result.data.colorId);
            $("#exampleModal select[name='Product.SizeId']").val(result.data.sizeId);
            $("#exampleModal").modal({ backdrop: 'static' });
        },
        error: function (error) {
            console.log(error);
            $("#exampleModal").modal('close');
        }
    });
});
