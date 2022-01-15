#include<iostream>
using namespace std;
int fat(int n )
{
	if (n==0)
	   return 1;
	else
	   return n * fat(n-1);
}
int main() {
	int n;
	cout <<"Digite um valor inteiro";
	cin >> n;
	cout << "Fatorial "<< fat(n);
	return 0;
}
