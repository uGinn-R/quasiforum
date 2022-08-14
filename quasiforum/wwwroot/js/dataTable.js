$(document).ready(function () {
    $('#dataTable').DataTable({
        "responsive": true, "sorting": false, "columnDefs": [
            { "width": "20%", "targets": 0 }
        ]});
});