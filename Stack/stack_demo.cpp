#include <iostream>
#include <stack>
using namespace std;
int main()
{
    stack <int> s;
    int n,temp;
    cout<<"n=";
    cin>>n;
    for(int i=0;i<n;i++){
        cout<<"element["<<i+1<<"]=";
        cin>>temp;
        s.push(temp);
    }
    cout<<'\n';
    while(!s.empty()){
        cout<<s.top()<<endl;
        s.pop();
    }
	return 0;
}
