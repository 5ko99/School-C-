#include <iostream>
using namespace std;
    int Nod(int a, int b)
    {
        while (a!=b){
             if(a>b){
                 a=a-b;
             } else {
                 b=b-a;
             }
        }
        return a;
    }

int main()
{
	int A[20];
	int n;
	cout<<"n=";
	cin>>n;
	for(int i=0;i<n;i++)
    {
        cout<<"arr["<<i<<"]=";
        cin>>A[i];
    }

    int g = A[0];
    for (int i = 1; i < n; i++)
    {
       g = Nod(g, A[i]);
    }

    cout<<"NOD="<<g;
	return 0;
}
