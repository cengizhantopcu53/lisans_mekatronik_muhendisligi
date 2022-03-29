#include <iostream>
using namespace std;

class dikdortgen
{
	int genislik,yukseklik;
	public:
	void set_values (int,int);
	int alan() {return genislik*yukseklik;};
};

void dikdortgen::set_values (int x, int y)
{
	genislik=x;
	yukseklik=y;
}

int main () 
{
	dikdortgen islem;
	islem.set_values (9,7);
	cout << "Dikdortgenin Alani:" << islem.alan();
	return 0;
}
