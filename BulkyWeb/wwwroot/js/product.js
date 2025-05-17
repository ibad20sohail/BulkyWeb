$(document).ready(function () {
    loadDataTable();
});
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall'},
        "column": [
        { data: 'title', "width": "10%" },
        { data: 'isbn', "width": "10%" },
        { data: 'author', "width": "10%" },
        { data: 'listPrice', "width": "10%" },
        { data: 'category.name', "width": "10%" }
    ]
    });
}