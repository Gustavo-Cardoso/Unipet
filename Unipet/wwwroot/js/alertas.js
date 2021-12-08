/*Index - Newsletter*/
function alertNewsletter() {
	if (document.getElementById("subscribe").value != "") {
		Swal.fire({
			title: 'E-mail cadastrado',
			text: 'Obrigado por inscrever-se!',
			icon: 'success',
			confirmButtonColor: '#00adb5',
		})
		document.getElementById("subscribe").blur();
		document.getElementById("formNews").reset();
	}
}

/*Contato*/
//function alertContato() {
//	Swal.fire({
//		title: 'Mensagem enviada!',
//		text: 'Em breve entraremos respondendo.',
//		icon: 'success',
//		confirmButtonColor: '#00adb5',
//	})
//}

/*Criar Usuário*/
function criarConta() {
	Swal.fire({
		title: 'Conta criada com sucesso!',
		icon: 'success',
		confirmButtonColor: '#00adb5',
	});
}


/*Recuperar Senha*/
function alertRecuperarSenha() {
	if (document.getElementById("redefinir").value != "") {	
		Swal.fire({
			title: 'E-mail enviado!',
			text: 'Se você não receber o e-mail, verifique suas pastas de spam ou de lixo eletrônico.',
			icon: 'success',
			confirmButtonColor: '#00adb5',
		});
		document.getElementById("redefinir").blur();
	}
	else {
		document.getElementById("msgemail").innerHTML = "O campo EMAIL é obrigatório.";
    }
}

/*Minha Conta*/
function alertSalvarTutor() {
	Swal.fire({
		title: 'Dados salvos com sucesso!',
		icon: 'success',
		confirmButtonColor: '#00adb5',
	}).then(function () {
		$('#pet_tab').trigger('click')
	})
}