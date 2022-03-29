//overloadind
void yaz (double x)
{
	cout<<x<<end;
}
void yaz(string x)
{
	cout<<x<<end;
}
void yaz(int x)
{
	cout<<x<<end;
}
 int main()
{
	yaz(5);
	yaz(3.14);
	yaz("Bilimsel Akademi");
	return 0;
}
