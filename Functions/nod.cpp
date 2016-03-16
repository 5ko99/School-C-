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
	int a,b,c,p;
	cout<<"A=";
	cin>>a;
	cout<<"B=";
	cin>>b;
	cout<<"C=";
	cin>>c;
	cout<<'\n';

	nod=Nod(Nod(a,b),c);
	cout<<"Nod na a="<<a<<" b="<<b<<" c="<<c<<" NOD="<<nod<<'\n';

	return 0;
}
