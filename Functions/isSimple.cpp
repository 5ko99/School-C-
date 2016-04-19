#include <iostream>
#include <cmath>
using namespace std;

	bool isPrime(int n)
	{
		bool isPrime=true;
		if (n==2) return true;
		int i=2;
		while(sqrt(n)>=i)
		{
			if(n%i==0 && n!=i)
			{
				isPrime=false;
				return isPrime;
			}
			i++;
		}
		
		return isPrime;
	}
	
	long arrMax (long arr[], int n)
	{
		long max = arr[0];
		for (int i=1;i<n;i++)
		{
			if(arr[i]>max) max = arr[i];
		}
		return max;
	}

int main()
{
	int a;
	cout<<"n=";
	cin>>a;
	bool isP = isPrime(a);
	cout<<"Number a is prime:"<<isP<<endl;s
	
	int n=5;
	long arr[n];
	for(int i=0;i<n;i++)
	{
	  cout<<"arr["<<i<<"]=";
	  cin>>arr[i];
	}
	cout<<"arr max="<<arrMax(arr,n);
}
