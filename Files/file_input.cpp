#include <iostream>
#include  <cstring>
#include <fstream>
using namespace std;
int main(){
    string name,fathername,surname;
    ofstream myfile;
    myfile.open("file.txt",ios::out);
    int n;
    cout<<"n=";
    cin>>n;
    for(int i=0;i<n;i++){
        cout<<"input name: ";
        cin>>name;
        cout<<"input fathername: ";
        cin>>fathername;
        cout<<"input surname: ";
        cin>>surname;
        myfile<<i<<". ";
        myfile<<name<<" ";
        myfile<<fathername<<" ";
        myfile<<surname<<'\n';
    }

    myfile.close();
    return 0;
}
