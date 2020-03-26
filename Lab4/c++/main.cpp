#include <iostream>
#include "Trapeze.h.cpp"
using namespace std;

int main() {
  Trapeze TR1;
  int a[]  = {1, 2};
  int b[] = {5, 9};
  int c[] = {4, 56};
  int d[] = {88, 16};
  Trapeze TR2 = Trapeze(a, b, c, d);
  Trapeze TR3 = Trapeze("sameside");
  cout<<"TR1 coordinates: "<<endl;
  TR1.PrintCoord();
  cout<<"TR2 coordinates: "<<endl;
  TR2.PrintCoord();
  cout<<"TR3 coordinates: "<<endl;
  TR3.PrintCoord();
  TR1 = TR1 - 3;
  cout<<"TR1 coordinates after decrementing by 3: "<<endl;
  TR1.PrintCoord();
  TR1 = TR2 * TR3;
  double res = TR1;
  cout<<"Multiplying's TR2 and TR3 result: "<<endl;
  cout<<*TR1.a<<" "<<*(TR1.a+1)<<endl;
  cout<<*TR1.b<<" "<<*(TR1.b+1)<<endl;
  cout<<*TR1.c<<" "<<*(TR1.c+1)<<endl;
  cout<<*TR1.d<<" "<<*(TR1.d+1)<<endl;
  cout<<res<<endl;
  
}