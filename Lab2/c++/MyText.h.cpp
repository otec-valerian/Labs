#include "MyText.h"
#include <iostream>
#include <vector>
#include <cstring>
#include <stdio.h>
#include <ctype.h>


void MyText::GetContent(){
    for (int i = 0; i < sizeof(this->Content);i++){
        cout<<this->Content[i].GetText<<endl;
    }
}

void MyText::AddLine(char* txt){
    Content.push_back(MyString(txt));
    this->size++;
}

void MyText::DelLine(int n){
    this->Content.erase(Content.begin() + n);
}

void ClearText(){
    this->Content.clear();
}

MyString FindBiggestLine(){
    int big_v = 0;
    MyString big_str = this->Content[0];
    for (int i = 0; i < strlen(this->Content); i++)
    {
        if (strlen(this->Content[i].GetText) > big_v)
        {
            big_v = strlen(this->Content[i].GetText);
            big_str = this->Content[i];
        }
    }

    return big_str;
}


int TotalSymbols(){
    int sum = 0;
    for (int i = 0; i < strlen(this->Content); i++)
    {
        sum += strlen(this->Content[i].GetText);
    }
    
    return sum;
}


double PercentOfSymbols(){
    float total = this->TotalSymbols();
    float cur = 0;
    for (int i = 0; i < strlen(this->Content); i++)
    {
        for (int j = 0; j < strlen(this->Content[i].GetText); j++)
        {
            if (isalpha(this->Content[i].GetText[j]))
            {
                cur++;
            } 
        }
    }

    float r = cur / total;
    return round(r * 100, 2);
}


