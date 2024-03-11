$(document).on('click', '.edit-button', function () {
    var id = $(this).data('id');
    $.ajax({
        url: '/user/orderform/getById?id=' + id,
        type: 'GET',
        success: function (result) {
            $("#exampleModal input[name='OrderFormProducts.Id']").val(result.data.id);
            $("#exampleModal select[name='OrderFormProducts.ProductId']").val(result.data.productId);
            $("#exampleModal input[name='OrderFormProducts.Required_Quantity']").val(result.data.required_Quantity);
            $("#exampleModal input[name='OrderFormProducts.Send_Quantity']").val(result.data.send_Quantity);
            $("#exampleModal input[name='OrderFormProducts.OrderForm_Id']").val(result.data.orderForm_Id);
            $("#exampleModal").modal({ backdrop: 'static' });
        },
        error: function (error) {
            console.log(error);
            $("#exampleModal").modal('close');
        }
    });
});