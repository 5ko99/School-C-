#include <iostream>
using namespace std;
int main()
{
    int n,max,k;
	cout<<"n=";
	cin>>n;
	int a[n];
	cout<<"a["<<0<<"]=";
    cin>>a[0];
    max=a[0];
	for (int i=1;i<n;i++)
	{
	    cout<<"a["<<i<<"]=";
	    cin>>a[i];
	    if(a[i]>max)
	    {
	      max=a[i];
	      k=i;
	    }
	}
    cout<<"Max elemnt is: "<<max;
    cout<<"and his index is:"<<k;
	return 0;
}
