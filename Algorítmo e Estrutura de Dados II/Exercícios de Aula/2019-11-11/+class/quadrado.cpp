#include<iostream>
using namespace std;
string quad(int x)
{
	if (x==1)
	   return "*";
	else
	   return "*"+quad(x-1);
}
int main() {
	int i,j,x;
	char ch='*';
	cout <<"Qual no. de linhas do quadrado ?\n";
	cin >> x;
	// sem recursao
	for(i=1;i<=x;i++) {
		for(j=1;j<=x;j++) {
			cout << ch;
		}
		cout<<endl;
	}
	// com recursao nas colunas
	for(i=1;i<=x;i++) {
		cout<<quad(x);
		cout<<endl;
	}
}
