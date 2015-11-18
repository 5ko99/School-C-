#include <iostream>
#include <string>
using namespace std;
int main()
{
	string name,family,cut;
	short pos=0;
	name="Svetoslav";
	family="Petkov";
    cout<<name.length()<<endl;
    cout<<name[5]<<endl;
    cout<<name+" "+family<<endl;
    cout<<(name>family)<<endl;
    pos=name.find("slav",5);
    cout<<pos<<endl;
    name.insert(5,"mir");
    cout<<name<<endl;
    family.erase(5,1);
    cout<<family<<endl;
    cut=name.substr(3,4);
    cout<<cut<<endl;
    family.replace(1,4,cut);
    cout<<family<<endl;
    family.swap(name);
    cout<<family<<endl;

	return 0;
}
