Algoritmo "parcelas"


Var

   Divida, VM : real
   Parcelas: real
   
Inicio

      Escreva ("Digite o valor da sua divida ")
      Leia (Divida)
      VM <- 327,00
      Parcelas <- (Divida / VM)
      Se (Parcelas < VM) entao
      Escreva ("Será parcela única")
      Senao
      Escreva ("O numero de parcelas a serem pagas é :", int(Parcelas))
      FimSe





Fimalgoritmo