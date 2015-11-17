#include <iostream>
#include <cstring>
using namespace std;
int main()
{
    char niz[10];
    int n=0;
    cin>>niz;
    while(niz[n]!='\0')
    {
        n++;
    }
    cout<<n;
	return 0;
}
