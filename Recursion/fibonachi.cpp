#include <iostream>
using namespace std;

long long fibonachi(int n){
    if(n<3) return 1;
    return fibonachi(n-1)+fibonachi(n-2);
}

int main()
{
	int n;
	long long fib;
	cout<<"n=";
	cin>>n;
	fib=fibonachi(n);
	cout<<"Fibonachi("<<n<<")="<<fib<<endl;
	return 0;
}
