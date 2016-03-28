#include <iostream>
#include <cmath>
using namespace std;


    double distance(double ax,double ay,double bx,double by)
    {
        double r,A,B;

        A=bx-ax;
        B=by-ay;
        r=pow((pow(A,2)+pow(B,2)),0.5);
        return r;
    }

    double lice(double ax, double ay, double bx, double by,double cx, double cy)
    {
            long a = distance(bx,by,cx,cy);
            long b = distance(ax,ay,cx,cy);
            long c = distance(ax,ay,bx,by);
            long P = a+b+c;
            long p = P/2;
            long s=pow((p*(p-a)*(p-b)*(p-c)),0.5);
            cout<<s;
            return s;
    }


int main()
{
    double ax;
    double ay;
    double bx;
    double by;
    double cx;
    double cy;
    ax=1;
    ay=2;
    bx=3;
    by=3;
    cx=5;
    cy=4;
    cout<<"Distance= "<<distance(ax,ay,bx,by)<<endl;
    cout<<"Perimeter= "<<lice(ax,ay,bx,by,cx,cy);
	return 0;
}
