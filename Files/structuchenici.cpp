#include <iostream>
#include  <string>
#include <fstream>
using namespace std;

struct Student{
    string name;
    string surname;
    int clas;
    float uspeh;
    int ots;
};

int main()
{
    float swap =0;
    string s_swap;
    int k =0;
    int min = 0;
    ofstream usp_file;
    ofstream ots_file;
    int n;
    cout<<"n=";
    cin>>n;
    Student student[n];
    for(int i=0;i<n;i++){
        cout<<"Name: ";
        cin>>student[i].name;
        cout<<"Surname: ";
        cin>>student[i].surname;
        cout<<"Class: ";
        cin>>student[i].clas;
        cout<<"Uspeh: ";
        cin>>student[i].uspeh;
        cout<<"ots: ";
        cin>>student[i].ots;
    }

    usp_file.open("uspeh.txt");
    ots_file.open("otsystvia.txt");

    for(int i=0;i<n;i++)
	{
	    k=i;
	    min=student[i].uspeh;
	    for(int j=i;j<n;j++)
	    {
	        if(student[j].uspeh>min)
	        {
	            min=student[j].uspeh;
	            k=j;
	        }
	    }
            swap=student[k].uspeh;
	        student[k].uspeh=student[i].uspeh;
	        student[i].uspeh=swap;

	         s_swap=student[k].name;
	        student[k].name=student[i].name;
	        student[i].name=s_swap;

	         s_swap=student[k].surname;
	        student[k].surname=student[i].surname;
	        student[i].surname=s_swap;

	        swap=student[k].clas;
	        student[k].clas=student[i].clas;
	        student[i].clas=swap;

	        swap=student[k].ots;
	        student[k].ots=student[i].ots;
	        student[i].ots=swap;
	    }

    for(int i=0;i<n;i++){
        usp_file<<student[i].name<<" ";
        usp_file<<student[i].surname<<endl;
        usp_file<<student[i].clas<<endl;
        usp_file<<student[i].uspeh<<endl;

        usp_file<<endl;

        ots_file<<student[i].name<<" ";
        ots_file<<student[i].surname<<endl;
        ots_file<<student[i].clas<<endl;
        ots_file<<student[i].ots<<endl;


    }

    usp_file.close();
    ots_file.close();
	return 0;
}
