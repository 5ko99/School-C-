#include <iostream>
#include <string.h>
using namespace std;
int main()
{
    char a[10]="";
    char b[10]="";
    cin>>a;
    strcpy(b,a);
    cout<<a<<endl;
    cout<<b;
	return 0;
}
