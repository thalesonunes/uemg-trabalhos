#include <stdio.h>
#include <iostream>
using namespace std;


int main (void) {

  int i;
  int j;
  int perfeito;
  int x;

  cout <<  ("�ngelo Schmitz Pedron\n\n");
  cout <<  ("Exercic�o 2\n");


  for (i = 1; x<5; i++ ) {
	for (j = 1; j< i; j++) {
	  if ((i % j) == 0) {
		perfeito = perfeito + j;
	  }
	}
	if (i == perfeito) {
	  cout << ("O numero %d � perfeito\n",i);
	  x++;
	}
	perfeito=0;
  }
}
