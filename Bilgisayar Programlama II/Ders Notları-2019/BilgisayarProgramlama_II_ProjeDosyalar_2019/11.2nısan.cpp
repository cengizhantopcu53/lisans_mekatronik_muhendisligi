#include <iostream>
using namespace std;
int main ( ) 
{
	int top=0;
    for(int i=0;i<=5;i++);
{
	if(i==3)
	  break;                  //continue ikisindede farklý sonuç çýkar ilki 3 bunda 12
	top=top+i;
}
	cout<<"toplam="<<top;
return 0;
}
