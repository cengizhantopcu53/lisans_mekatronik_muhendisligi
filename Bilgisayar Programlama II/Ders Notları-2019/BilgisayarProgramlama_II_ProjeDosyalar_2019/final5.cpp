#include <iostream>
using namespace std;

int foo [] = {5,5,5,5};
int a , toplam=0;
int ortalama=0;

int main ()
{
	for (a=0; a<4; ++a)
	{
		toplam += foo[a];
		ortalama = toplam / 4;
	}
	cout<<"Toplam="<<toplam<<endl;
	cout<<"Ortalama="<<ortalama;
	return 0;
}
