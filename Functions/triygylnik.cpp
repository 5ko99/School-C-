#include <iostream>
#include <string>
using namespace std;
    bool isTriaganle(double a, double b, double c)
    {
        if(a<b+c || b<a+c || c<a+b)
        {
          return false;
        }
        return true;
    }

    string trType(double a, double b, double c)
    {
        if(a==b && b==c) return "Ravnostranen";
        if(a==b || b==c || c==a) return "Ravnobedren";
        return "Raznostranen";
    }
int main()
{
	int n;
	cout<<"n=";
	cin>>n;
	return 0;
}
