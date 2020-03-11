#include <string>
#include <cstring>
#include "MyString.h"
#include <vector>

class MyText{
    private:
        vector<MyString> Content;
    public:
        void GetContent();
        void AddLine(char* txt);
        void DelLine(int n);
        void ClearText();
        MyString FindBiggestLine();
        int TotalSymbols();
        double PercentOfSymbols();
};