window.onload = function () {
    var rutaAbsoluta = self.location.href;
    var posicionUltimaBarra = rutaAbsoluta.lastIndexOf("/");
    var rutaRelativa = rutaAbsoluta.substring(posicionUltimaBarra + "/".length, rutaAbsoluta.length);

    switch (rutaRelativa) {
        case 'frmIndex.aspx':
            var elemento = document.getElementById("dvIndex");
            elemento.className += " active";
            break;
        case 'frmConsejos.aspx':
            var elemento = document.getElementById("dvConsejos");
            elemento.className += " active";
            break;
        case 'frmPerfil.aspx':
            var elemento = document.getElementById("dvPerfil");
            elemento.className += " active";
            break;
    }


};