$(document).ready(function () {
    $(".deleteitem").click(function (e) {
        e.preventDefault();
        let href = $(this).attr("href");
        $.confirm({
            title: 'Delete',
            content: 'Delete data?',
            buttons: {
                'Yes': {
                    btnClass: "btn-danger",
                    action: function () {
                        location.href = href;
                    }
                },
                'No': function () {

                }
            }
        });
    });
});