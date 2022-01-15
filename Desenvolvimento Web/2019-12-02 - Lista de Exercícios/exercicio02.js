// EXERCÍCIO 02 - MAIOR NUMERO
// ================================================================================================
function maiorNumero() {
    var num1 = document.getElementById('num1').value;
    var num1 = Number (num1);
    var num2 = document.getElementById('num2').value;
    var num2 = Number (num2);
    var num3 = document.getElementById('num3').value;
    var num3 = Number (num3);
    var aux=0;
    

    // VERIFICA SE OS CAMPOS FORAM PREENCHIDOS E IMPRIME MENSAGEM DE ALERTA
  
    if (document.getElementById("num1").value == "") {
        document.getElementById('resultado').innerText = 'O campo "NÚMERO 1" não foi preenchido.';
        document.getElementById("num1").focus();
    }

    if (document.getElementById("num1").value != "") {
        if (document.getElementById("num2").value == "") {
            document.getElementById('resultado').innerText = 'O campo "NÚMERO 2" não foi preenchido.';
            document.getElementById("num2").focus();
        }
    }

    if ((document.getElementById("num1").value != "") & (document.getElementById("num2").value != "")) {
        if (document.getElementById("num3").value == "") {
            document.getElementById('resultado').innerText = 'O campo "NÚMERO 3" não foi preenchido.';
            document.getElementById("num3").focus();
        }
    }
        
    // COMPARA NUMEROS
    if (num1 > aux) {aux = num1;}
    if (num2 > aux) {aux = num2;}
    if (num3 > aux) {aux = num3;}

    // VERIFICA SE TODOS OS COAMPOS FORAM PREENCHIDOS
    // SE PREENCHIDOS, IMPRIME O RESULTADO
    // SE NÃO PREENCHIDOS, CHAMA NOVAMENTE A FUNÇÃO
    if ((document.getElementById("num1").value != "") & (document.getElementById("num1").value != "") & (document.getElementById("num3").value != "")){
        document.getElementById('resultado').innerText = 'O numero '+ aux + ' é o maior.';
    }else{maiorNumero()}
}

