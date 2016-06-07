#include <iostream>
using namespace std;

void toBinar(int n){
    if(n==0) return;
    toBinar(n/2);
    cout<<n%2;
}

int main()
{
	int n;
	cout<<"n=";
	cin>>n;
	toBinar(n);
	return 0;
}
