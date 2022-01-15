// EXERCÍCIO 05 - TABUADA
// ================================================================================================

function tabuada(){

    var num = document.getElementById('num').value;

    for (var i=0; i<=10; i++)
    {
        document.getElementById('resultado'+i).innerText =
        num + " x " + i + " = " + (num*i);
    }
}
