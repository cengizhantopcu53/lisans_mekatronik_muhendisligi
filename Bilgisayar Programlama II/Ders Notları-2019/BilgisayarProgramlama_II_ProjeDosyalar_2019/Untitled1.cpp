#include <iostream>
using namespace std;
int main () {                                //ilk �� b�lme standart yaz�l�yo
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
   x=11%3 ;                                  //y�zde mod anlam�nda
   cout<<"x=" <<x<< "\n" ;
   y +=x;                                    //y=y+x demektir
   cout<<"y="<<y<<"\n"; 
   x-=5;                                     //x=x-5 demektir	
   cout<<"x="<<x<<"\n";
   k=3;
   l=++k;                                    //ard� ard�na yap�lan ++ lar�n anlam� +1 anlam�ndad�r
   cout<<"k="<<k<<"\t l="<<l<<"\n";
   k=3;                                      //hoca buray� bo� b�rak�r
   l=0;                                      //hoca buray� bo� b�rak�r  sorar bunlar�
   l=k++;                                    //k=k+1 ????
   cout<<"k="<<k<<"\t l="<<l<<"\n";          //s�navda ��kar hac� (k=3 den ba�l�yo !!)
                                            //==e�ittir !=e�it de�ildir
   cout<<(!(5==5))<<"\n";                   //ilk 5,5 e e�itmidir diye soror do�ru 1 sonra !1 sorar o da tersi false 0 olur
   cout<<(!(6<=4))<<"\n";                   //ilk 6,4 den k���k yada e�it midir sorar hay�r o sonra !0 diye sorar tesi true 1 olur
                                            //c meselesi ile ilgili iki senerdir sor�uyolar
   c=5+(7%2);
   cout<<"c="<<c<<"\n";
   c=0;
   c=(5+7)%2;
   cout<<"c="<<c<<"\n";
                                            //and  , or kap�s�
                                            //and i�arati &&
                                            //or i�arati || 
   cout<<((!(5==5))&&(!(6<=4)));
   cout<<"\n";
   cout<<((!(5==5))||(!(6<=4)));
   cout<<"\n";
                                            //if , else yap�s�
                                            //? ve : kullan�yoruz
   string i;
   i=(7==5)?"helal be":"tekrar yapacan malesef";              //sring leri kelimelri tutmak i�in kullan�yoruz
   cout<<i<<"\n";
   i=(7>5)?"helal be":"tekrar yapacan malesef";              
   cout<<i<<"\n";
}




