function dados()
{

	var nome = document.getElementById('nome').value;
	var mail = document.getElementById('mail').value;
	var tel = document.getElementById('tel').value;

	if (nome == "") {
		document.getElementById("enviar").innerHTML = "Campo NOME não foi preenchido!";
		document.getElementById("nome").focus();
	}else if (mail == "") {
		document.getElementById("enviar").innerHTML = "Campo EMAIL não foi preenchido!";
		document.getElementById("mail").focus();
	}else if (tel == "") {
		document.getElementById("enviar").innerHTML = "Campo TELEFONE não foi preenchido!";
		document.getElementById("tel").focus();
	}else{
		document.getElementById("enviar").innerHTML = "Dados enviados com sucesso!";
	}

}
