#include <iostream>
#include  <cstring>
#include <fstream>
using namespace std;
int main()
{
    ifstream read;
    read.open("file_read.cpp",ios::in);
    string readed;
    string text;
    ofstream myfile;
    myfile.open("program.txt",ios::out);

    while(!read.eof()){

        read>>readed;
        if(readed==";"){
            text+="\n";
        }
        else{
           text+=readed;
        }

    }
    myfile<<text;


    myfile.close();
    read.close();
	return 0;
}
