Algoritmo "primosEquanto"


Var

   i, n, x: inteiro
   primo: logico

Inicio


      Enquanto (i<3) faca
               Escreva ("Digite um valor: ")
               Leia (n)
               primo <- verdadeiro
               x <- 2
               Enquanto (x <= n-1) faca
                        Se (n % x = 0) entao
                        primo <- falso
                        x <- n
                        FimSe
                        x <- (x+1)
               FimEnquanto

               Se (primo = verdadeiro) entao
                  Escreval ("O valor é primo")
               Senao
                  Escreval ("O valor não é primo")
               FimSe
               i <- (i+1)
               FimEnquanto


      

Fimalgoritmo