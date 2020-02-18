#include <iostream>
#include <string>

using namespace std;

string Comparing(int num1, int num2){
    int l = to_string(max(abs(num1), abs(num2))).length();
    for (int j=l; j >= 0; j--){
        if ((num1 & (1 << j)) < (num2 & (1 << j))){
            return "Yes";
        }
        else if ((num1 & (1 << j)) > (num2 & (1 << j))){
            return "No";
        }
        
    }
    return "No";
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