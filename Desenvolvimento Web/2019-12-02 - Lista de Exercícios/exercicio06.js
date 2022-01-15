// EXERCÍCIO 06 - PRIMO
// ================================================================================================

function primo(){

    var numero = document.getElementById("num").value;
    var nDivisores=0;

    for (var i=1; i <= numero; i++){

        if (numero % i == 0){
            nDivisores++;
        }
    }

    if (nDivisores == 2){
        document.getElementById('resultado').innerText = 'É número primo.';
    }else{
        document.getElementById('resultado').innerText = 'Não é número primo.';
    }
}