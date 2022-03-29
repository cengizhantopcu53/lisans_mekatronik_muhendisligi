#include <iostream>
using namespace std;
int main () {                                //ilk üç bölme standart yazýlýyo
   int x,y=3,a,b,k,l,c;
   cout<<x<< "\n" ;	
   x=5;
   cout<<x<< "\n" ;
   x=y;
   cout<<y<< "\n" ;
   a=10 ;
   b=4 ;
   cout<<"a="<<a<<"\tb="<<b<<"\n" ;
   a=b ;
   b=7 ;
   cout<<"a="<<a<<"\tb"<<b<<"\n" ;
   x=11%3 ;                                  //yüzde mod anlamýnda
   cout<<"x=" <<x<< "\n" ;
   y +=x;                                    //y=y+x demektir
   cout<<"y="<<y<<"\n"; 
   x-=5;                                     //x=x-5 demektir	
   cout<<"x="<<x<<"\n";
   k=3;
   l=++k;                                    //ardý ardýna yapýlan ++ larýn anlamý +1 anlamýndadýr
   cout<<"k="<<k<<"\t l="<<l<<"\n";
   k=3;                                      //hoca burayý boþ býrakýr
   l=0;                                      //hoca burayý boþ býrakýr  sorar bunlarý
   l=k++;                                    //k=k+1 ????
   cout<<"k="<<k<<"\t l="<<l<<"\n";          //sýnavda çýkar hacý (k=3 den baþlýyo !!)
                                            //==eþittir !=eþit deðildir
   cout<<(!(5==5))<<"\n";                   //ilk 5,5 e eþitmidir diye soror doðru 1 sonra !1 sorar o da tersi false 0 olur
   cout<<(!(6<=4))<<"\n";                   //ilk 6,4 den küçük yada eþit midir sorar hayýr o sonra !0 diye sorar tesi true 1 olur
                                            //c meselesi ile ilgili iki senerdir sorüuyolar
   c=5+(7%2);
   cout<<"c="<<c<<"\n";
   c=0;
   c=(5+7)%2;
   cout<<"c="<<c<<"\n";
                                            //and  , or kapýsý
                                            //and iþarati &&
                                            //or iþarati || 
   cout<<((!(5==5))&&(!(6<=4)));
   cout<<"\n";
   cout<<((!(5==5))||(!(6<=4)));
   cout<<"\n";
                                            //if , else yapýsý
                                            //? ve : kullanýyoruz
   string i;
   i=(7==5)?"helal be":"tekrar yapacan malesef";              //sring leri kelimelri tutmak için kullanýyoruz
   cout<<i<<"\n";
   i=(7>5)?"helal be":"tekrar yapacan malesef";              
   cout<<i<<"\n";
}




