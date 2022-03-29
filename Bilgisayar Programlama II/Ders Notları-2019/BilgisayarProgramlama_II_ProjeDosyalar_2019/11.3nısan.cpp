#include <iostream>
using namespace std;
int main ( ) 
{  
  int n,s; 
  double top=0,sayi,ort;
cout<<"n degeri=";
cin>>n;
for(s=1;s<=n;s++)
{
	cout<<s<<".sayiyi gir=";
	cin>>sayi;
	top=top+sayi;
}
 ort=top\n;
 cout<<"ortalama="<<ort<<"\n";
 s=1;top=0;ort=0;
while(5<=n)
{
	cout<<s<<".sayiyi gir=";
	cin>>sayi;
	top=top+sayi;
	s++
}
ort=top\n;
cout<<"ortalama="<<ort;
return 0;
}
