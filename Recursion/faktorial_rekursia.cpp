#include <iostream>
using namespace std;

long long factorial(int n){
if(n==0){
        return 1;
    }
    return n*factorial(n-1);
}

 double power(double n, int pow){
    if(pow==0){
        return 1;
    }
    if(pow>0){
        return n*power(n,pow-1);
    }else{
        return 1.0/power(n,-pow);
    }

}



int main()
{
    int n,pow;
    double d;
    cout<<"n=";
    cin>>n;
    cout<<"d=";
    cin>>d;
    cout<<"pow=";
    cin>>pow;
    long long fact = factorial(n);
    cout<<"Factorial("<<n<<")="<<fact<<endl;
    cout<<"Pow(d="<<d<<",pow="<<pow<<")="<<power(d,pow)<<endl;
	return 0;
}
