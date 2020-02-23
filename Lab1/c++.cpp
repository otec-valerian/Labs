#include <iostream>
#include <string>

using namespace std;

int Sum(int num1, int num2){
    while (num2 != 0){
        int cur = num1 & num2;
        num1 ^= num2;
        num2 = cur << 1;
    }
    return num1;
    
}

bool Comparing(int num1, int num2){
    num2 = Sum(~num2, 1);
    if (Sum(num1, num2) > 0){
        return false;
    } else {
        return true;
    }
}


int DecrementByOne(int num) {
    int x = 0;
    while ((num & (1 << x)) == 0) {
        num = num ^ (1 << x);
        x++;
    }
    num = num ^ (1 << x);
    return num;
}

int main()
{
  cout << "Decrementing -124: " << DecrementByOne(-124)<<endl;
  cout << "Decrementing 43: " << DecrementByOne(43)<<endl;
  cout << "Decrementing 9: " << DecrementByOne(9)<<endl;
  cout << "Is 32 less than 45 - "<< Comparing(32, 45)<<endl;
  cout << "Is -34 less than -35 - "<< Comparing(-34, -35)<<endl;
  cout << "Is 377 less than -32 - "<< Comparing(377, -32)<<endl;
}