$('input[type="checkbox"]').on('change', function () {
    console.log("hola");
    $('input[name="' + this.name + '"]').not(this).prop('checked', false);
});

function ObtenerSeleccionados() {
    var selected = new Array();
    console.log("hola");
    var chkFrec = "";
    var chkTen = "";

    var chkCantFrec = 0;
    var chkCantTen = 0;

    var totFrec = document.getElementById('ContentPlaceHolder1_txtCantPregFrec').value;
    var totTen = document.getElementById('ContentPlaceHolder1_txtCantPregTen').value;




    $("input:checkbox:checked").each(function () {
        console.log($(this).attr('id'));
        var idAtr = $(this).attr('id');


        if (idAtr.includes('Frec')) {
            chkFrec += idAtr.substring(4, 8) + ",";
            chkCantFrec++;
        } else {
            chkTen += idAtr.substring(3, 8) + ",";
            chkCantTen++;
        }

    });
    console.log(totFrec + ' - ' + totTen);
    console.log(chkCantFrec + ' - ' + chkCantTen);
    console.log(chkFrec + ' - ' + chkTen);

    if (totFrec == chkCantFrec && totTen == chkCantTen) {
        console.log("true");
        document.getElementById('ContentPlaceHolder1_txtCantPregFrec12').value = chkFrec;
        document.getElementById('ContentPlaceHolder1_txtCantPregTen12').value = chkTen;
        return true;
    } else {
        var mensaje = document.getElementById('lblMensajes');
        mensaje.innerHTML = "Por favor completar todos los items.";
        mensaje.style.visibility = 'visible';
        console.log("false");
        return false;
    }
}