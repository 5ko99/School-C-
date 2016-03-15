#include <iostream>
using namespace std;
int main()
{
    int n,k,p;//broi na el na masiva
    int pN=0;
    int nN=0;
    k=0;
    p=0;
	cout<<"Input array nummber count: ";
	cin>>n;
	int *arr = new int[n];
	for(int i=0;i<n;i++)
	{
	    cout<<"arr["<<i<<"]=";
	    cin>>*(arr+i);
	    if(arr[i]>=0)
	    {
	        k++;
	    }
	    else
	    {
	        p++;
	    }
	}

    int *pos = new int[k];
    int *neg = new int[p];

    for(int i=0;i<n;i++)
    {
        if(arr[i]>=0)
        {
            pos[pN++]=arr[i];
        }
        else
        {
                neg[nN++]=arr[i];
        }
    }

	delete []arr;

    cout<<'\n';
	for(int i=0;i<k;i++)
	{
	    cout<<"pos["<<i<<"]="<<pos[i]<<endl;
	}

    cout<<'\n';

	for(int i=0;i<p;i++)
	{
	    cout<<"neg["<<i<<"]="<<neg[i]<<endl;
	}

	return 0;
}
