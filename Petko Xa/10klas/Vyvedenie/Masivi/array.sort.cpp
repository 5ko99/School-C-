#include <iostream>
using namespace std;
int main()
{
	 int n,k,min,swap,search,low,mid,high;
	 bool flag=true;
	cout<<"n=";
	cin>>n;
	int a[n];
	for (int i=0;i<n;i++)
	{
	    cout<<"a["<<i<<"]=";
	    cin>>a[i];
	}

	for(int i=0;i<n;i++)
	{
	    k=i;
	    min=a[i];
	    for(int j=i;j<n;j++)
	    {
	        if(a[j]<min)
	        {
	            min=a[j];
	            k=j;
	        }
	    }
            swap=a[k];
	        a[k]=a[i];
	        a[i]=swap;
	    }

	cout<<endl;
	for(int i=0;i<n;i++)
	{
	    cout<<"a["<<i<<"]="<<a[i]<<endl;
	}

	//Search
	cout<<"Serched Nummber=";
	cin>>search;

	low=0;
	high =n-1;
	mid=high/2;
do
{
    if(search<a[mid])
	{
	    high=mid;
	    mid=(high-low)/2;
	}
	if(search>a[mid])
	{
	    low=mid;
	    mid=(high-low)/2;
	}
	else
	{
	    cout<<"YES! a["<<mid-1<<"]="<<search<<endl;
	    flag=false;
	    break;
	}
}
	while(low==high);
if(flag) cout<<"NO!";

	return 0;
}
