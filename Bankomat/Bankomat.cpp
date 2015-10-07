#include <iostream>
using namespace std;
int main()
{
    int sum;
    int n=-1;
    cout<<"Sum= ";
    cin>>sum;
    int m[7];
    m[0]=1;
    m[1]=2;
    m[2]=5;
    m[3]=10;
    m[4]=20;
    m[5]=50;
    m[6]=100;
    
    for (int i=0;i<=6;i++)
    {
      if(sum-m[i]>=0)
      {
         n++;  
      }
    }
    
    while(n>=0)
    {
        if(sum-m[n]>=0)
        {
            if (sum-m[n]==0)
            {
                cout<<m[n];
                return 0;
            }
            else
            {
                sum = sum-m[n];
                cout<<m[n]<<" ";
            }
        }
        else
        {
          n--;  
        }
    }
    
   
    return 0;
}