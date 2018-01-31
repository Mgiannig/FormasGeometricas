$(document).ready(function () {
    $(".clear-filter").click(clearFilter);
    $("#mostrar-filtros").click(mostrarfiltros_click);
    //$(".chosen-select").chosen({ search_contains: true, width: '100%' });
    $("#openProfile").click(usuario_Profile);
});

function mostrarfiltros_click() {
    var navbarHeight = $("#navbar").height();

    var interval = setInterval(function () {
        setBodyPadding(navbarHeight);
    }, 1);

    $("#filters").toggleClass("active ");
    $("#filters-meta").slideToggle(300, function () {
        $("#filter-caret").toggleClass("fa-caret-up fa-caret-down");
        clearInterval(interval);
        setBodyPadding(navbarHeight);
    });
}

function setBodyPadding(navbarHeight) {
    var headingHeight = $(".heading").height();
    $('body').css("padding-top", headingHeight + navbarHeight);
}
// 
function clearFilter(event) {
    var form = $(event.currentTarget).closest("form");
    form.find("input").not(".no-clear-filter, radioFilter, [name='__RequestVerificationToken']").val('');
    form.find("select").not(".no-clear-filter").val('');

    //$(".radioFilterFalse").val("False");
    //$(".radioFilterTrue").val("True");
    $(".radioFilterAll").prop("checked", true);
}

function updateValidators(formId) {
    var form = $("#" + formId);
    form.removeData("validator");
    form.removeData("unobtrusiveValidation");
    $.validator.unobtrusive.parse(form);
    form.validate();
}

function ajax_OnFailure(xhr, status, error) {
    alert(error);
}

function ChangePassword_click() {
    var form = $("#form-password-userLogueado");
    form.validate();
    if (form.valid()) {
        $.ajax(
            {
                url: passwordChangeUsuarioLogueado,
                type: "POST",
                data: form.serialize(),
                success: function (response) {
                    if (response != 'ok') {
                        $("#alert-message").remove();
                        $("#passwordConfirmModal").prepend(response);
                    } else {
                        $("#form-password-userLogueado")[0].reset();
                        $("#alert-message").remove();
                        $("#modalUsuarioChangePassword").modal('hide');
                        $("#modalUsuarioPasswordCambiada").modal('show');
                    }
                },
                error: function (err, a, q) {
                    alert("Error: " + err);
                }
            });
    }
}


function usuario_Profile(event) {
    usuarioLogueado = $("#openProfile").data("id")
    window.location.href = detailUsuarioURL + '/' + usuarioLogueado;
}