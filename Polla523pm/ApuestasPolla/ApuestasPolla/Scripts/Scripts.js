var PollaScripts = PollaScripts || {};

PollaScripts.ValidarInputs = function () {
    var Val1 = '';
    var Val2 = '';

    if ($('#usuario').val() == '') {
        $('#usuario').addClass('Error');
        Val1 = 'El campo Usuario está vacío. <br/>';
    }
    else {
        $('#usuario').removeClass('Error');
    }
    if ($('#contraseña').val() == '') {
        $('#contraseña').addClass('Error');
        Val1 += 'El campo Contraseña está vacío. <br/>';
    }
    else {
        $('#contraseña').removeClass('Error');
    }
    if (Val1 != '') {
        $('#LabelError').html(Val1);
        $('#LabelError').fadeIn(1000);
        Val1 = '';
        return false;
    }
    else {
        $('#LabelError').html('');
        $('#LabelError').fadeOut(1000);
        return true;
    }
}

PollaScripts.CenterGeneralContainer = function (id) {
    var IdJquery = "#" + id;
    var containerWidth = parseInt($(IdJquery).width()) / 2;
    var containerHeight = parseInt($(IdJquery).height()) / 2;
    var centerWidthValue = (window.innerWidth / 2) - containerWidth;
    var centerHeightValue = (window.innerHeight / 2) - containerHeight;

    if (centerWidthValue < 0) {
        centerWidthValue = centerWidthValue * -1;
    }

    if (centerHeightValue < 0) {
        centerHeightValue = centerHeightValue * -1;
    }
    $(IdJquery).css('margin-left', centerWidthValue + 'px');
    $(IdJquery).css('margin-top', centerHeightValue + 'px');

}