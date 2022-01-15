Algoritmo "tringulos"

Var

   Lado1, Lado2, Lado3 : real

Inicio

      Escreval ("Digite a medida do primeiro lado: ")
      Leia (Lado1)
      Escreval ("Digite a medida do segundo lado: ")
      Leia (Lado2)
      Escreval ("Digite a medida do terceiro lado: ")
      Leia (Lado3)
      Se ((Lado1 = Lado2) e (Lado1 = Lado3)) entao
         Escreva ("TRIANGULO EQUILÁTERO")
      Senao
           Se ((Lado1 = Lado2) e (Lado1 <> Lado3)) ou ((Lado2 = Lado3) e (Lado1 <> Lado3)) ou ((Lado1 = lado3) e (Lado1 <> Lado2)) entao
           Escreva ("TRINGULO ISÓCELES")
      Senao
           Escreva ("TRIANGULO ESCALENO")
      FimSe
      FimSe


Fimalgoritmo