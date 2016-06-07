#include <iostream>
using namespace std;

bool digitCheck(int x, int k ){
    if(x==0){
        return false;
    }
    if(x%10==k){
        return true;
    }else{
        return digitCheck(x/10,k);
    }

}

int main()
{
	int x,k;
	cout<<"x=";
	cin>>x;
	cout<<"k=";
	cin>>k;
	if(digitCheck(x,k)){
        cout<<"Digit "<<k<<" is in "<<x<<" ="<<" TRUE"<<endl;
	}else{
        cout<<"Digit "<<k<<" is in "<<x<<" ="<<" FALSE"<<endl;
	}


	return 0;
}
