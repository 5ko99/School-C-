#include <iostream>
using namespace std;
int main()
{
	int a=100,b=101,c=102, *p;
	p=&b;
	cout<<&a<<endl;
	cout<<p<<endl;
	cout<<&c<<endl;
//Uvelichavame ukazetelq s 1
    p++;
    cout<<p<<' '<<*p<<endl;

//Mojem da davame(promenqme) stoinostite na ukazateli
    *(p-2)=202;
    cout<<c<<endl;
	return 0;
}
