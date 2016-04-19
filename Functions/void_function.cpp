#include <iostream>
using namespace std;
void swap(int a, int b)
{
    int temp;
    temp=a;
    a=b;
    b=temp;
    return;
}
int main()
{
    int x,y;
    cout<<"x=";
    cin>>x;
    cout<<"y=";
    cin>>y;
    cout<<'\n';
    cout<<"After swap:"<<endl;
    cout<<"x="<<x<<endl;
    cout<<"y="<<y<<endl;
	return 0;
}
