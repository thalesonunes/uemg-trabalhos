#include <stdio.h>

int main (void) {

  int i;
  int j;
  int perfeito;
  int x;

  system("clear");
  printf ("�ngelo Schmitz Pedron\n\n");
  printf ("Exercic�o 2\n");


  for (i = 1; x<5; i++ ) {
	for (j = 1; j< i; j++) {
	  if ((i % j) == 0) {
		perfeito = perfeito + j;
	  }
	}
	if (i == perfeito) {
	  printf("O numero %d � perfeito\n",i);
	  x++;
	}
	perfeito=0;
  }
}
