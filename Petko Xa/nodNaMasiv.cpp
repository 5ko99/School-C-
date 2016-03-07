#include <iostream>
using namespace std;
int main()
{
   int a,c=0,sum=0;;
   do
   {
       cout<<"a["<<c<<"]=";
       cin>>a;
       sum+=a;
       c++;
   }
   while(a!=0);
    cout<<"Sum="<<sum<<endl;
	return 0;
}
