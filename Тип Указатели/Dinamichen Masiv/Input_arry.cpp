#include <iostream>
using namespace std;
 void inputArray(int arr[], int n)
 {
     for(int i=0;i<n;i++)
     {
         cout<<"arr["<<i<<"]=";
         cin>>arr[i];
     }
 }

 void coutArray(int arr[], int n)
 {
     for(int i=0;i<n;i++)
     {
         cout<<"arr["<<i<<"]=";
         cout<<arr[i];
         cout<<'\n';
     }
 }

int main()
{
    int arr[5];
    int n=5;
    inputArray(arr,n);
    cout<<'\n';
    coutArray(arr,n);

	return 0;
}
