#include <iostream>
using namespace std;
int main()
{
	int q,p;
	bool flag = false;
	cout<<"p=";
	cin>>p;
	cout<<"q=";
	cin>>q;
	for (int i=p;i<=q;i++)
	{
	 flag=false;
	 for(int j=2;j<i;j++)
	 {
	     if (i%j==0)
	        {
                flag = true;
                break;
	        }
	 }
        if(flag==false)
        {
            cout<<i<<" ";
        }
	}

	return 0;
}
