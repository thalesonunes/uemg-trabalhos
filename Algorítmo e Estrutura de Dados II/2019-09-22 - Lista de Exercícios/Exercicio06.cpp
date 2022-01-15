#include <stdio.h>
#include <stdlib.h>
#define N 15

void VerificaPrimos(int k[], int *p);

int main() {
int k[N], *p;
int i;
for(i=0;i<N;i++) {
	printf("Digite um valor para V[%d]: ",i);
	scanf("%d",&k[i]);
}

p = (int *)malloc(0);
if(p == NULL) exit(1);

VerificaPrimos(k,p);
i = sizeof(p)+1;
while(i >=0){
	printf("\n%d",p[i]);
	i--;
}

free(p);
return 0;
}

void VerificaPrimos(int k[], int *p) {
int i,j;
j = 0;
for(i=0;i<N;i++) {
	divisor = 2;
	while (divisor < k[i] && k[i]%divisor != 0) divisor++;
	if (divisor == k[i]) {
	   p = (int *)realloc(p,(j + 1) * sizeof(int));
	   p[j] =k[i];
	   j++;
	}
}
}
