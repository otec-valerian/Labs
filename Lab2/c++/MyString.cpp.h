#include <string>
#include <cstring>


class MyString {
    private:
        char* Text;
    public:
        explicit MyString(char* txt);
        int GetLength();
        char* GetText();
};