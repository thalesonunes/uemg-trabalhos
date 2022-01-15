Algoritmo "testando_funcao_para"
// Disciplina  :  [Linguagem e Lógica de Programação] 
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
      Escreva ("A nota média é ", soma/4)
      
      
      

Fimalgoritmo