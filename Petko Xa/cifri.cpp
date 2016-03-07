#include <iostream>
using namespace std;
int main()
{
   long a,sum=0,n;
   cout<<"a=";
   cin>>a;

   while(a!=0)
   {
        n = a%10;
        if (n%2==0) sum+=n;
        a/=10;
   }

   cout<<"Sum of even number="<<sum;

	return 0;
}
