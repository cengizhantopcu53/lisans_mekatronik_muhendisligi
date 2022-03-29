//FONKSÝYONLAR
//Ana programý tarafýndan ggerektiðinden çaðrýlýp çalýþtýrýlan program parçalarýna fonksiyon denir.
//Eðer program içinde bazý iþlemler sýk sýk yapýlýyorsa her iþlem için kod yazmak yerine bu kodu bir defa yazar ve fonksiyon kaybederiz,gerektiðinde kullanýrýz.
#include <iostream>
using namespace std;
int main ( ) 
{ 
//int kare(int x)
//{
//int kare ;
//kare=x*x;
//return kare ;
//}
//int main()
//{
  //int s=5;
  //cout<<kare(s);       //Buradaki kare fonksiyonun temsili.
  //return 0;
//}                      //cevap=25

//dönüþ-tipi fonksiyon-adý(parametereler)
//{
	//kodlar;
	//return deðiþken;
//}


void topla ()
{
	int s1,s2,topla=0;
	cout<<"Birinci sayi=";cin>>s1;
	cout<<"Ýkinci sayi=";cin>>s2;
	topla=s1+s2;
	cout<<"Toplam="<<topla;
}
int main ()
{ cout<<"xxx";
  topla();
  return 0;
}
}
