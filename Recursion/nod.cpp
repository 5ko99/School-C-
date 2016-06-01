#include <iostream>
using namespace std;
int nod(int a, int b){
    if(a==b) return a;
    if(a>b) nod(a-b,a);
    else nod(a,b-a);
}

int main()
{
    int a,b;
    cout<<"a=";
    cin>>a;
    cout<<"b=";
    cin>>b;
    int NOD = nod(a,b);
    cout<<"NOD("<<a<<","<<b<<")="<<NOD<<endl;
	return 0;
}
