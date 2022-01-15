Algoritmo "saldo"

Var

   saldo, deposito, saque : real

Inicio

      saldo <- (500)
      Escreval ("Digite o valor do cheque a ser depositado: ")
      Leia (deposito)
      saldo <- (saldo + deposito)
      Escreval ("Seu saldo atual é: ", saldo)
      Escreval ("Digite o valor do saque: ")
      Leia (saque)
      Se (saque < saldo) entao
         saldo <- (saldo - saque)
      Senao
           Escreval ("Saque acima do permitido, informe um valor abaixo de: ", saldo, ": ")
           Leia (saque)
      saldo <- (saldo - saque)
      FimSe
      Escreval ("Seu saldo atual é: ", saldo)



Fimalgoritmo