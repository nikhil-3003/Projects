// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// wwwroot/js/books.js
$("#addBookForm").submit(function(e) {
    e.preventDefault();
    $.ajax({
        url: '/Books/AddBook',
        type: 'POST',
        data: $(this).serialize(),
        success: function(response) {
            alert(response.message);
            if (response.success) location.reload();
        },
        error: function() {
            alert("Something went wrong!");
        }
    });
});
