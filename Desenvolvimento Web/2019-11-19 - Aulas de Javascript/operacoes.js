function categoria(){
		var nome = document.getElementById('nome').value;
		var data = document.getElementById('data').value;
		
        
		var idade = 2019-data
		document.getElementById('resultado').innerText = 'O resultado é ' + soma;
	}

	function subtrair(){
		var numero1 = document.getElementById('number1').
		value;
		var numero2 = document.getElementById('number2').
		value;
		var num1 = Number(numero1);
		var num2 = Number(numero2);
		var subtracao = num1 - num2;
		document.getElementById('resultado').innerText = 'O resultado é ' + subtracao;
	}

	function multiplicar(){
		var numero1 = document.getElementById('number1').
		value;
		var numero2 = document.getElementById('number2').
		value;
		var num1 = Number(numero1);
		var num2 = Number(numero2);
		var multiplicacao = num1 * num2;
		document.getElementById('resultado').innerText = 'O resultado é ' + multiplicacao;
	}


	function dividir(){
		var numero1 = document.getElementById('number1').
		value;
		var numero2 = document.getElementById('number2').
		value;
		var num1 = Number(numero1);
		var num2 = Number(numero2);
		var divisao = num1 / num2;
		document.getElementById('resultado').innerText = 'O resultado é ' + divisao;
	}

	function combustivel(){
		var numero1 = document.getElementById('number1').
		value;
		var numero2 = document.getElementById('number2').
		value;
		var num1 = Number(numero1);
		var num2 = Number(numero2);

		var aux = num2 * 1.3;

		if (aux < num1)
		{
			document.getElementById('resultado').innerText = 'Melhor abastecer com alcool';
		}else
		{
			document.getElementById('resultado').innerText = 'Melhor abastecer com gasolina';
		}
	}