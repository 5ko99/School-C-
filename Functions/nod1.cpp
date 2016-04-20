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
    int nod;
    int n[20];
    for(int i=0;i<20;i++)
    {
        cout<<"n["<<i<<"]=";
        cin>>n[i];
    }

    nod(n[0],n[1]);

	return 0;
}
