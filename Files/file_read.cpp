#include <iostream>
#include  <cstring>
#include <fstream>
using namespace std;
int main()
{
    ifstream read;
    string readed;
    read.open("file.txt",ios::in);
    read>>readed;
    while(read)
    {
        cout<<readed;
        read>>readed;

    }



    read.close();
	return 0;
}
