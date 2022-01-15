// EXERCÍCIO 03 - SELECIONAR MÊS
// ================================================================================================

function numeroMes(){

    var mes = document.getElementById("mes").value;

    if ((mes < 1) | (mes > 12)) {
        document.getElementById('resultado').innerText = 'Numero ERRADO, digite um numero de 1 a 12!';
    }

    switch(mes){

        case "1":
        document.getElementById('resultado').innerText = 'Mês correspondente: JANEIRO.';
        break;

        case "2":
        document.getElementById('resultado').innerText = 'Mês correspondente: FEVEREIRO.';
        break;

        case "3":
        document.getElementById('resultado').innerText = 'Mês correspondente: MARÇO.';
        break;

        case "4":
        document.getElementById('resultado').innerText = 'Mês correspondente: ABRIL.';
        break;

        case "5":
        document.getElementById('resultado').innerText = 'Mês correspondente: MAIO.';
        break;

        case "6":
        document.getElementById('resultado').innerText = 'Mês correspondente: JUNHO.';
        break;

        case "7":
        document.getElementById('resultado').innerText = 'Mês correspondente: JULHO.';
        break;

        case "8":
        document.getElementById('resultado').innerText = 'Mês correspondente: AGOSTO.';
        break;

        case "9":
        document.getElementById('resultado').innerText = 'Mês correspondente: SETEMBRO.';
        break;

        case "10":
        document.getElementById('resultado').innerText = 'Mês correspondente: OUTUBRO.';
        break;

        case "11":
        document.getElementById('resultado').innerText = 'Mês correspondente: NOVEMBRO.';
        break;

        case "12":
        document.getElementById('resultado').innerText = 'Mês correspondente: DEZEMBRO.';
        break;

    }
}
