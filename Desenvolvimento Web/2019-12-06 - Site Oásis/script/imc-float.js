
function calculo() {

    var altura1 = document.getElementById('altura').value;
    var altura = parseFloat(altura1);

    var peso1 = document.getElementById('peso').value;
    var peso = parseFloat(peso1);

    var imc1 = (peso / (altura * altura));
    var imc = imc1.toFixed(2);

    var pesomin1 = ((altura * altura) * 18.5);
    var pesomin = pesomin1.toFixed(2);

    var pesomax1 = ((altura * altura) * 24.9);
    var pesomax = pesomax1.toFixed(2);

    if (imc < 18.5) {
        document.getElementById('resultado').innerHTML = 'Resultado: MAGREZA' + '<br>' +
            'Sinto muito, seu IMC é ' + imc + ', por isso você precisa ganhar peso.' + '<br>' +
            'Seu peso ideal precisa ficar entre ' + pesomin + 'kg e ' + pesomax + 'kg.';
    }
    else if ((imc >= 18.5) & (imc < 24.9)) {
        document.getElementById('resultado').innerHTML = 'Resultado: NORMAL' + '<br>' +
            'Parabéns, seu IMC é ' + imc + ', e você está dentro do peso adequado!' + '<br>' +
            'Procure manter seu peso entre ' + pesomin + 'kg e ' + pesomax + 'kg.';
    }
    else if ((imc >= 24.9) & (imc < 30)) {
        document.getElementById('resultado').innerHTML = 'Resultado: SOBREPESO' + '<br>' +
            'Sinto muito, seu IMC é ' + imc + ', por isso é necessário emagrecer um pouco.' + '<br>' +
            'Seu peso ideal precisa ficar entre ' + pesomin + 'kg e ' + pesomax + 'kg.';
    }
    else if ((imc >= 30) & (imc < 40)) {
        document.getElementById('resultado').innerHTML = 'Resultado: OBESIDADE' + '<br>' +
            'Sinto muito, seu IMC é ' + imc + ', por isso e necessário emagrecer.' + '<br>' +
            'Seu peso ideal precisa ficar entre ' + pesomin + 'kg e ' + pesomax + 'kg.';
    }
    else if (imc >= 40) {
        document.getElementById('resultado').innerHTML = 'Resultado: OBESIDADE GRAVE' + '<br>' +
            'Sinto muito, seu IMC é ' + imc + ', por isso é necessário emagrecer bastante.' + '<br>' +
            'Seu peso ideal precisa ficar entre ' + pesomin + 'kg e ' + pesomax + 'kg.';
    }
    else {
        document.getElementById('resultado').innerHTML = 'Os números digitados não são válidos';
    }

}

function limpar(){
    document.getElementById('altura').value = "";
    document.getElementById('peso').value = "";
    document.getElementById('resultado').innerHTML = 'Preencha os dados!';
}