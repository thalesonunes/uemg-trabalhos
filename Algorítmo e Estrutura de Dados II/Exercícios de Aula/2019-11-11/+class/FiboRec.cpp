#include<iostream>
using namespace std;
int fibo(int t )
{
	if ((t==0)|| (t==1))
	   return 1;
	else
	   return fibo(t-1) + fibo(t-2);
}
int main() {
	int t;
	cout <<"Digite o termo desejado da seq. Fibonacci";
	cin >> t;
	cout << "O valor referente ao "<<t << "o. termo é "<< fibo(t);
	return 0;
}
