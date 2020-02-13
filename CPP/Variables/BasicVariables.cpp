#include <iostream>
#include <vector>
#include <string>
#include <stack>
#include <queue>
#include <math.h>

using namespace std;

class demo
{
public:
    string geekname;
    demo(string name)
    {
        geekname = name;
    }

    void printname()
    {
        cout << "Geekname is: " << geekname << endl;
    }
};

int main()
{

    demo obj("roshan");
    //obj.geekname = "roshan";
    obj.printname();

    
    vector<string> msg{"Hello", "C++", "World", "from", "VS Code!"};

    int number = 234;
    cout << number << endl;

    for (const string &word : msg)
    {
        cout << word << " ";
    }
    cout << endl;
}