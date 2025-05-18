$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        ajax: {
            url: '/admin/product/getall', // Replace with your API URL
        },
        columns: [
            { data: 'title' },
            { data: 'isbn' },
            { data: 'author' },
            { data: 'price' },
            { data: 'category.name' },
            {
                data: 'id',
                render: function (data) {
                    return `<div class="w-75 btn-group"><a href="/admin/product/edit?id=${data}" class='btn btn-primary mx-2'>Edit</a>
                    <a href="/admin/product/delete?id=${data}" class='btn btn-danger mx-2'>Delete</a></div>`;
                }
            }
        ]
    });
}