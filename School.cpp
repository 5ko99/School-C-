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
    ofstream myfile;
    myfile.open("otlichnici.txt",ios::out);
    ofstream myfile1;
    myfile1.open("neotlichnici.txt",ios::out);

    for(int i=0;i<n;i++){
        if(s[i].uspeh>=5.50){
           myfile<<s[i].name<<" ";
           myfile<<s[i].secondname<<" ";
           myfile<<s[i].surname<<" ";
           myfile<<"Uspeh: "<<s[i].uspeh<<" ";
           myfile<<"Izvineni otsystvia: "<<s[i].ots.izvineni<<" ";
           myfile<<"Neizvineni otsystivia: "<<s[i].ots.neizvineni<<endl;
        }
        else{
            myfile1<<s[i].name<<" ";
            myfile1<<s[i].secondname<<" ";
            myfile1<<s[i].surname<<" ";
            myfile1<<s[i].uspeh<<" ";
            myfile1<<s[i].ots.izvineni<<" ";
            myfile1<<s[i].ots.neizvineni<<endl;
        }

    }
    myfile.close();
    myfile1.close();
	return 0;
}



