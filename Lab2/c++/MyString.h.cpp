#include "MyString.h"
#include <cstring>

using namespace std;

MyString::MyString(char* txt){
    this->Text = txt;
}

int MyString::GetLength(){
    return strlen(this->Text);
}

char* MyString::GetText(){
    return this->Text;
}