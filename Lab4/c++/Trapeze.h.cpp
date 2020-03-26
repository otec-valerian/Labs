#include <iostream>
using namespace std;

class Trapeze{
  public:
    Trapeze(int x[], int y[], int z[], int f[]);
    Trapeze();
    Trapeze(string type);
    int* A();
    int* B();
    int* C();
    int* D();
    Trapeze operator-(int y);
    void PrintCoord();
    Trapeze operator*(Trapeze tr2);
    double GetSquare();
    operator double();
    int a[2] = {0,0};
    int b[2] = {0,0};
    int c[2] = {0,0};
    int d[2] = {0,0};
};