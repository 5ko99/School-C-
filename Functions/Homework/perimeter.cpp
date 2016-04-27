#include <iostream>
using namespace std;

    double perimeter (double a, double b)
    {
        double p = 2*a+2*b;
        return p;
    }

    double lice(double a, double b)
    {
        double s = a*b;
        return s;
    }

int main()
{
	double a,b,a1,b1;
	cout<<"a=";
	cin>>a;
	cout<<"b=";
	cin>>b;
	cout<<"a1=";
	cin>>a1;
	cout<<"b1=";
	cin>>b1;
	cout<<"P="<<perimeter(a,b)-perimeter(a1,b1);
	cout<<'\n';
	cout<<"Lice ab="<<lice(a,b)<<endl;
	cout<<"Lice a1b1="<<lice(a1,b1)<<endl;
	cout<<"S="<<lice(a,b)-lice(a1,b1);
	return 0;
}
