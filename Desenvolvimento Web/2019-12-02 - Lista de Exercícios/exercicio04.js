// EXERCÍCIO 04 - CONSÓRCIO
// ================================================================================================

function consorcio(){
    var prestacoesTotal = document.getElementById('prestacoesTotal').value;
    var prestacoesPagas = document.getElementById('prestacoesPagas').value;
    var prestacoesValor = document.getElementById('prestacoesValor').value;
    var valorPago = prestacoesPagas * prestacoesValor;
    var valorAPagar = (prestacoesTotal - prestacoesPagas) * prestacoesValor;

    document.getElementById('valorpago').innerText = 'Valor pago: ' + valorPago + ' reais.';
    document.getElementById('valorapagar').innerText = 'Valor a pagar: ' + valorAPagar + ' reais.';
}