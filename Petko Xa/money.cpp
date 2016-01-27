#include <iostream>
using namespace std;
int main()
{
  int sum = 0;
  int b1= 10000;
  int b2 = 10000;
  int b5 = 10000;
  cout<<"Enter Money: ";
  cin>>sum;
   for (int i =0; i<=b1; i++)
   {
       for (int j=0; j<=sum/2; j++)
       {
           for(int q=0; q<=sum/5; q++)
           {
               if (sum == (i*1) + (j*2) + (q*5))
               {
                   cout<<i<<"*"<<"1 lv"<<" + "<<j<<"*2 lv"<<" + "<<q<<"*5 lv"<<endl;
               }

           }
       }
   }
	return 0;
}
