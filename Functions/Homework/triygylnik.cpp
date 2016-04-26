#include <iostream>
#include <string>
using namespace std;
    bool isTriaganle(double a, double b, double c)
    {
        if(a>b+c || b>a+c || c>a+b)
        {
          return false;
        }
        return true;
    }

    string trType(double a, double b, double c)
    {
        if(isTriaganle(a,b,c))
        {
            if(a==b && b==c) return "Ravnostranen";
            if(a==b || b==c || c==a) return "Ravnobedren";
            return "Raznostranen";
        }
        else return "";

    }
int main()
{
	int n;
	double a,b,c;
	cout<<"n=";
	cin>>n;
	for(int i=0;i<n;i++)
    {
        cout<<"a=";
        cin>>a;
        cout<<"b=";
        cin>>b;
        cout<<"c=";
        cin>>c;
        cout<<"\n";
        if(isTriaganle(a,b,c))
        {
          cout<<"Yes ";
        }
        else
        {
            cout<<"No ";
        }
        cout<<trType(a,b,c);
        cout<<"\n";
    }
	return 0;
}
