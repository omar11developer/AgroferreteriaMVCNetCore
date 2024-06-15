$(document).ready(function () {
   

   
    $('#searchQuery').on('input', function () {
        var searchOption = $('input[name="searchOption"]:checked').val();
        var query = $(this).val().toLowerCase();

        $('#userTable .user-row').each(function () {
            var showRow = false;

            if (searchOption === 'Nombre') {
                var name = $(this).find('.user-name').text().toLowerCase();
                if (name.includes(query)) {
                    showRow = true;
                }
            } else if (searchOption === 'Documento') {
                var document = $(this).find('.user-document').text().toLowerCase();
                if (document.includes(query)) {
                    showRow = true;
                }
            } else if (searchOption === 'Correo') {
                var email = $(this).find('.user-email').text().toLowerCase();
                if (email.includes(query)) {
                    showRow = true;
                }
            }

            if (showRow) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
    });
});

