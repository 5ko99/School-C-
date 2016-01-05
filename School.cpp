#include <iostream>
#include  <string>
#include <fstream>
using namespace std;

struct Otsystviq{
    int izvineni;
    int neizvineni;
};

 struct Student{
    string name;
    string secondname;
    string surname;
    double uspeh;
    Otsystviq ots;
};

int main()
{
    int n;
    cout<<"n=";
    cin>>n;
    Student s[n];
    double USPEH=5.50;
    int o = 3010541460;
    for(int i=0;i<n;i++){
        cout<<"Name: ";
        cin>>s[i].name;
        cout<<"Secondname: ";
        cin>>s[i].secondname;
        cout<<"Surname: ";
        cin>>s[i].surname;
        cout<<"Uspeh: ";
        cin>>s[i].uspeh;
        cout<<"Izvineni otsystviq: ";
        cin>>s[i].ots.izvineni;
        cout<<"Neizvineni otsystviq: ";
        cin>>s[i].ots.neizvineni;

        if((s[i].ots.izvineni+s[i].ots.neizvineni)<=o){
            o=s[i].ots.izvineni+s[i].ots.neizvineni;
        }

    }


    for(int i=0;i<n;i++){

        if(s[i].uspeh>=USPEH){
            cout<<s[i].name<<" "<<s[i].secondname<<" "<<s[i].surname<<endl;
        }




      if((s[i].ots.izvineni+s[i].ots.neizvineni)==o){
           cout<<s[i].name<<" "<<s[i].secondname<<" "<<s[i].surname<<endl;
        }
    }

	return 0;
}



