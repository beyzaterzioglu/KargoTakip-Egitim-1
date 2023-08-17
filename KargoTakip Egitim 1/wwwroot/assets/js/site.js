// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const sAlert = Swal.mixin({
    customClass: {
        confirmButton: 'btn btn-dark mx-1',
        cancelButton: 'btn btn-light mx-1'
    },
    confirmButtonText: 'Evet',
    cancelButtonText: `İptal`,
    buttonsStyling: false
})