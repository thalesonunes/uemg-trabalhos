function mensagem(){
	// alert("Funcionando");
	var nome = document.getElementById('nome').value;

	if(nome == ""){
		document.getElementById('resultado').innerText = "Preencha este campo.";
		document.getElementById('nome').focus();
	}else if (nome == "João") {
		document.getElementById('resultado').innerText = "Eita "+nome+ ", chega mais meu brother!!!.";
	}else{
		document.getElementById('resultado').innerText = "Olá "+nome+ ", seja bem vindo(a).";
	}
}

function calcula(){
	//var num1 = document.getElementById('num1').value;
	var num1 = Number (document.getElementById('num1').value);
	var num2 = document.getElementById('num2').value;
	var num2 = Number (num2);
	var resultado = num1+num2;

	document.getElementById('conta').innerText = "O resultado é " + resultado;
}