#include <iostream>
using namespace std;
int main()
{
	int n;  //broi na el na masiva
	cout<<"Input array nummber count: ";
	cin>>n;
	int *arr = new int[n];
	for(int i=0;i<n;i++)
	{
	    cout<<"arr["<<i<<"]=";
	    cin>>*(arr+i);
	}
    cout<<'\n';
	for(int i=0;i<n;i++)
	{
	    cout<<"arr["<<i<<"]=";
	    cout<<*(arr+i)<<endl;
	}
	delete []arr;
	return 0;
}
