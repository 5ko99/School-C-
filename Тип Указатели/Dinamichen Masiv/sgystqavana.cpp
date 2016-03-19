#include <iostream>
using namespace std;
int main()
{
    int n;
    cout<<"Input array nummber count: ";
	cin>>n;
	int *arr = new int[n];
	int c = 0;
	for(int i=0;i<n;i++)
	{
        cout<<"arr["<<i<<"]=";
	    cin>>*(arr+i);
	    if(*(arr+i)!=0)
	    {
            c++;
	    }

	}
	cout<<'\n';
	int *oarr = new int[c];
		for(int i=0;i<c;i++)
	{
	     if((*arr+i)!=0)
	    {
            *(oarr+i) = *(arr+i);
	    }
	    cout<<"arr["<<i<<"]=";
	    cout<<*(oarr+i)<<endl;
	}
	delete []arr;
	delete []oarr;
    cout<<c;


	return 0;
}
