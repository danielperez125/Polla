var PollaMetodos = PollaMetodos || {};

PollaMetodos.Login = function (usuario, contraseña) {
    $.ajax({
        url: "/Polla/Login",
        type: 'POST',
        dataType: 'html',
        data: 'Usuarios=' + usuario + '&Contraseña=' + contraseña,
    }).done(function (msg) {        
        $("#ContenedorDatos").html(msg);
        PollaScripts.CenterGeneralContainer('ContenedorDatos');
    });
}
