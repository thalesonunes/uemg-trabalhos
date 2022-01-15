// EXERCÍCIO 08 - CAIXA DÁGUA
// ================================================================================================

function caixaDagua() {
    var cxTotal = document.getElementById('cxtotal').value;
    var cxMinuto = document.getElementById('cxminuto').value;
    var cxTempo=0;
    
    if ((cxTotal != "") & (cxMinuto != "")){
        cxTempo = cxTotal / cxMinuto;
        document.getElementById('resultado').innerText = 'Levará ' + cxTempo + ' minutos para encher a caixa!';
    }else{
        document.getElementById('resultado').innerText = 'Preencha todos os campos!';
        caixaDagua()}
}