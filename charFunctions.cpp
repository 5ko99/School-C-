#include <iostream>
#include <string.h>
using namespace std;
int main()
{
    char s1[50],s2[50];
    cout<<"s1= ";
    cin>>s1;
	strcpy(s2,s1);
	strcat(s2," Petko");
	cout<<"s1= "<<s1<<endl;
	cout<<"s2= "<<s2<<endl;
	return 0;
}
