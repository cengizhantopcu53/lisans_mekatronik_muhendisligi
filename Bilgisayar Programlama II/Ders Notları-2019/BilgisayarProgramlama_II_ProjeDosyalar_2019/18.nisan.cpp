//FONKS�YONLAR
//Ana program� taraf�ndan ggerekti�inden �a�r�l�p �al��t�r�lan program par�alar�na fonksiyon denir.
//E�er program i�inde baz� i�lemler s�k s�k yap�l�yorsa her i�lem i�in kod yazmak yerine bu kodu bir defa yazar ve fonksiyon kaybederiz,gerekti�inde kullan�r�z.
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

//d�n��-tipi fonksiyon-ad�(parametereler)
//{
	//kodlar;
	//return de�i�ken;
//}


void topla ()
{
	int s1,s2,topla=0;
	cout<<"Birinci sayi=";cin>>s1;
	cout<<"�kinci sayi=";cin>>s2;
	topla=s1+s2;
	cout<<"Toplam="<<topla;
}
int main ()
{ cout<<"xxx";
  topla();
  return 0;
}
}
