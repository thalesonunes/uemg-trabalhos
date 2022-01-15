// EXERCÍCIO 01 - CATEGORIA DO ATLETA
// ================================================================================================
function categoria() {
    var nome = document.getElementById('nome').value;
    var ano = document.getElementById('ano').value;
    var anoAtual = new Date();
    var idade = anoAtual.getFullYear() - ano;

    if (idade < 14) { document.getElementById('resultado').innerText = nome + ' é um atleta MIRIM.'; }
    else if ((idade >= 14) & (idade <= 15)) { document.getElementById('resultado').innerText = nome + ' é um atleta INFANTIL.'; }
    else if ((idade >= 16) & (idade <= 17)) { document.getElementById('resultado').innerText = nome + ' é um atleta JUNVENIL.'; }
    else if ((idade >= 18) & (idade <= 20)) { document.getElementById('resultado').innerText = nome + ' é um atleta JUNIORES.'; }
    else if ((idade > 20) & (idade < 100)) { document.getElementById('resultado').innerText = nome + ' é um(a) atleta PROFISSIONAL.'; }
    else if (idade > 100) { document.getElementById('resultado').innerText = nome + ' é uma LENDA do esporte! rs'; }

    if (document.getElementById("nome").value == "") {
        document.getElementById('resultado').innerText = 'O campo NOME DO ATLETA não foi preenchido.';
        document.getElementById("nome").focus();
    }
    if (document.getElementById("nome").value != "") {
        if (document.getElementById("ano").value == 0) {
            document.getElementById('resultado').innerText = 'O campo ANO DE NASCIMENTO não foi preenchido.';
            document.getElementById("ano").focus();
        }
    }
}