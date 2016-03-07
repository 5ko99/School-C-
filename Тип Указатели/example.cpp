#include <iostream>
using namespace std;
int main()
{
	int a =5;
	int *pa;
	pa=&a;
	int c = 0x64f8d8;
	c++;

	cout<<pa<<endl;
	cout<<*pa;

	return 0;
}
