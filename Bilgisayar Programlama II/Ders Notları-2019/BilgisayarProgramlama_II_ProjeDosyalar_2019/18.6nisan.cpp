//Recursýve
#include <iostream>
using namespace std;
int f(int n)
{
	if(n<=1)
	return 1;
else
 return (f(n-1)*n);
}
int main()
{
int x=7;
cout<<f(x);
return 0;
}
