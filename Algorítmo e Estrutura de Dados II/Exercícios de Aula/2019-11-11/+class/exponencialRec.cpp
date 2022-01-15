#include<iostream>
using namespace std;
int expo(int x, int n )
{
	if (n==0)
	   return 1;
	else
	   return x * expo(x, n-1);
}
int main() {
	int x,n;
	cout <<"Qual a base? ";
	cin >> x;
	cout <<"Qual a potencia? ";
	cin >> n;
	cout << "Resultado "<< expo(x,n);
	return 0;
}
