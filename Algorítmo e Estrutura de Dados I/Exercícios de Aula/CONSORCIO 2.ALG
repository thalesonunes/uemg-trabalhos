Algoritmo "media_repetida"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 


Var

   notas, soma: real
   i : inteiro

Inicio

      Para i <- 1 ate 10 faca
      Escreval (i, " ")
      FimPara
      
      Para i <- 1 ate 4 faca
           Escreval ("Digite a nota", i, " ")
           Leia (notas)
           soma <- (soma + notas)
      FimPara
      Escreva ("A nota m�dia � ", soma/4)
      
      
      

Fimalgoritmo