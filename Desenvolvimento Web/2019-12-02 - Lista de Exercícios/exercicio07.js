// EXERCÍCIO 07 - FATORIAL
// ================================================================================================

function fatorial() {

    var valor = document.getElementById('num').value;
    //var valor = Number (num1);

    if(valor < 0){
        document.getElementById('resultado').innerText = 'Valor deve ser maior ou igual a zero!';
    } else if ( (valor == 0) | (valor == 1) ){
        document.getElementById('resultado').innerText = 'Fatorial de ' + valor + ' é igual a 1!';
    } else{
        var acumulado = 1;
        for(i=valor; i>1; i--){
            acumulado = acumulado * i;
        }
        
        document.getElementById('resultado').innerText = "Fatorial de " + valor + " é igual a: " + acumulado;
    } 
}