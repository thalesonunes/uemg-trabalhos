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
      Escreva ("Ser� parcela �nica")
      Senao
      Escreva ("O numero de parcelas a serem pagas � :", int(Parcelas))
      FimSe





Fimalgoritmo