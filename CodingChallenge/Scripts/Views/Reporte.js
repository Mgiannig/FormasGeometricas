$(document).ready(function () {
    $(".del-forma").click(deleteForma_Click);
    $("#btnAgregarForma").click(butAgregarForma);
    drpOnchange()

});


function drpOnchange() {
    $('.dropDownTipoFigura').change(function (event) {
        var formaId = $(event.currentTarget).data("id");
        console.log(this.value)
        if (this.value === "4") {
            
            $("#ladoB-" + formaId).show();
            $("#ladoC-" + formaId).show();
            $("#ladoD-" + formaId).show();
            $("#altura-" + formaId).show();
        }
        else {
            $("#ladoB-" + formaId).hide();
            $("#ladoC-" + formaId).hide();
            $("#ladoD-" + formaId).hide();
            $("#altura-" + formaId).hide();
        }
        
        
    });
}

function butAgregarForma() {
    var urlToPost = formaAddUrl;

    $.ajax({
        url: urlToPost,
        success: function (html) {
            $("#formaList").append(html);
            FormaAdded();
            drpOnchange();
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            $("#mensajeForma").html(errorThrown);
            $("#mensajeForma").show();
        }
    });
}

function FormaAdded() {
    $(".del-forma").unbind("click");
    $(".del-forma").click(deleteForma_Click);
}

function deleteForma_Click(event) {
    var r = confirm("¿Eliminar forma?");
    if (r === true) {
        var formaId = $(event.currentTarget).data("id");
        $("#li-forma-" + formaId).remove();
    }
}

