#include <iostream>
using namespace std;
int main()
{
    int n=0,sum=0;
    do
    {
        cout<<"N>1"<<endl;
        cout<<"n= ";
        cin>>n;
    }
    while(n<2);

    for(int i=1;i<=n;i++)
    {
        sum+=i;
    }
    cout<<"Sum="<<sum;
    return 0;
}


