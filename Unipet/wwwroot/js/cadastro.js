
$(document).ready(function () {
	var i = 1;
    $('#addPet').click(function (e) {
		e.preventDefault();
        //var ph = 'opção ' + i.toString();
        $('#meusPets').append(
			'<div id=' + "pet" + i + '>\
				<div class="row">\
					<div class="mb-3"> <h5>' + "PET" + i + '</h5></div>\ <a href="#" class="remove"><i class="fas fa-trash-alt" title="Excluir"></i></a>\ <a href="#" class="salva"><i class="fas fa-save" title="Salvar"></i></a>\
						<div class="col-md-12 mb-3">\
							<img src="@Url.Content("~/img/sem_foto.png")" alt="" width="350">\
							<label for=' + "inputFotoPet" + i + ' class="form-label" style="margin-right: 10px; margin-left: -8px;">Foto: </label>\
							<input type="file" id="NovaFotoPet" name="NovaFotoPet" class="form-control-file" accept=".jpg, .jpge, .png, .gif" />\
						</div>\
						<div class="col-md-6 mb-3">\
							<label for=' + "inputNomePet" + i + ' class="form-label">Nome</label>\
							<input type="tel" class="form-control" id=' + "inputNomePet" + i + '>\
						</div>\
						<div class="col-md-6 mb-3">\
							<label for=' + "inputTamanhoPet" + i + ' class="form-label">Tamanho</label>\
							<input type="tel" class="form-control" id=' + "inputTamanhoPet" + i + '>\
						</div>\
						<div class="col-md-6 mb-3">\
							<label for=' + "inputEspeciePet" + i + ' class="form-label">Espécie</label>\
							<select class="form-select" id=' + "inputEspeciePet" + i + '>\
								<option selected></option>\
								<option>Cachorro</option>\
								<option>Gato</option>\
								<option>Coelho</option>\
								<option>Porco</option>\
							</select>\
						</div>\
						<div class="col-md-6 mb-3">\
							<label for=' + "inputRacaPet" + i + ' class="form-label">Raça</label>\
							<select class="form-select" id=' + "inputRacaPet" + i + '>\
								<option selected></option>\
								<option>Sem raça definida</option>\
								<option>Raça 1</option>\
								<option>Raça 2</option>\
							</select>\
						</div>\
						<div class="col-md-6 mb-3">\
							<label for=' + "inputGeneroPet" + i + ' class="form-label">Gênero</label>\
							<select class="form-select" id=' + "inputGeneroPet" + i + '>\
								<option selected></option>\
								<option>Fêmea</option>\
								<option>Macho</option>\
							</select>\
						</div>\
						<div class="col-md-6 mb-3">\
							<label for=' + "inputNascimentoPet" + i + ' class="form-label">Data de Nascimento</label>\
							<input type="datetime" class="form-control" id=' + "inputNascimentoPet" + i + '>\
						</div>\
					</div>\
				</div>\
			</div>');
        i++;
    });

    // Remove a opção anterior
    $('#meusPets').on("click", ".remove", function (e) {
        e.preventDefault();
        $(this).parent('div').remove();
        i--;
	});


	/*Tabs Minha conta*/
	jQuery(document).ready(function ($) {
		$('#tabs').tab();
	});


	/*Steps*/
	const stepButtons = document.querySelectorAll('.step-button');
	const progress = document.querySelector('#progress');

	Array.from(stepButtons).forEach((button,index) => {
		button.addEventListener('click', () => {
			progress.setAttribute('value', index * 100 /(stepButtons.length - 1) );//there are 3 buttons. 2 spaces.

			stepButtons.forEach((item, secindex)=>{
				if(index > secindex){
					item.classList.add('done');
				}
				if(index < secindex){
					item.classList.remove('done');
				}
			})
		})
	})

});



$(document).ready(function () {
    var currentGfgStep, nextGfgStep, previousGfgStep;
    var opacity;
    var current = 1;
    var steps = $("fieldset").length;
  
    setProgressBar(current);
  
    $(".next-step").click(function () {
  
        currentGfgStep = $(this).parent();
        nextGfgStep = $(this).parent().next();
  
        $("#progressbar li").eq($("fieldset")
            .index(nextGfgStep)).addClass("active");
  
        nextGfgStep.show();
        currentGfgStep.animate({ opacity: 0 }, {
            step: function (now) {
                opacity = 1 - now;
  
                currentGfgStep.css({
                    'display': 'none',
                    'position': 'relative'
                });
                nextGfgStep.css({ 'opacity': opacity });
            },
            duration: 500
        });
        setProgressBar(++current);
    });
  
    $(".previous-step").click(function () {
  
        currentGfgStep = $(this).parent();
        previousGfgStep = $(this).parent().prev();
  
        $("#progressbar li").eq($("fieldset")
            .index(currentGfgStep)).removeClass("active");
  
        previousGfgStep.show();
  
        currentGfgStep.animate({ opacity: 0 }, {
            step: function (now) {
                opacity = 1 - now;
  
                currentGfgStep.css({
                    'display': 'none',
                    'position': 'relative'
                });
                previousGfgStep.css({ 'opacity': opacity });
            },
            duration: 500
        });
        setProgressBar(--current);
    });
  
    function setProgressBar(currentStep) {
        var percent = parseFloat(100 / steps) * current;
        percent = percent.toFixed();
        $(".progress-bar")
            .css("width", percent + "%")
    }
  
    $(".submit").click(function () {
        return false;
    })
});