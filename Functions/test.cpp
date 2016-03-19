#include <iostream>
#include <string>
using namespace std;
    string text = "SUM= ";
    int sum(int a, int b)
    {
        int sum=a+b;
        return sum;
    }

    int sum(int a, int b, int c)
    {
       int sum = a+b+c;
       return sum;
    }

    void swap(double x, double y)
    {
        double temp;
        temp=x;
        x=y;
        y=temp;
    }

int main()
{
	int s;
	int a,b,c;
	a=3;
	b=8;
	c=1;
	s = sum(a,b,c);
	cout<<text<<s<<endl;


    cout<<'\n';
	cout<<"Before swap"<<endl;
	cout<<"A="<<a<<" B="<<b<<endl;
	swap(a,b);
	cout<<"After swap"<<endl;
	cout<<"A="<<a<<" B="<<b<<endl;
	return 0;
}
