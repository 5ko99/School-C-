#include <iostream>
using namespace std;

 long factorial(int n)
 {
     if(n==0)
     {
         return 1;
     }
     return factorial(n-1) * n;
 }

 double power(double x, double p)
 {
     if(p==0)
     {
         return p;
     }
     double res=1;
     for(int i=1;i<=p;i++)
     {
         res*=x;
     }
     return x;
 }

int main()
{
    int n;
    cout<<"n=";
    cin>>n;
    long result;
    result=factorial(n);
    cout<<'\n';
    cout<<"Factorial from "<<n<<"="<<result<<endl;

	return 0;
}
