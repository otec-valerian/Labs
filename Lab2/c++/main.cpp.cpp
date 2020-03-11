#include <iostream>
#include "MyString.h"
#include "MyText.h"
using namespace std;

int main()
{
    MyString a = MyString("qwerty");
    MyString b = MyString("1234");
    MyString c = MyString("(*^)(&");
    MyText test = MyText();
    test.AddLine(a);
    test.AddLine(b);
    test.AddLine(b);
    test.GetContent;
    test.DelLine(1);
    test.GetContent;
    test.Cleartext();
    test.GetContent();
    test.AddLine(a);
    test.AddLine(b);
    int a = test.TotalSymbols()
    cout<<a<<endl;
    double b = test.PercentOfSymbols();
    cout<<b<<endl;
}
