#include <iostream>
using namespace std;

int main(){
    int N = 0;
        for (int i = 0; i < 1000; ++i)
        {
            N += ((i % 5 == 0) || (i % 3 == 0)) ? 
                i : 0;
        }

    cout << N << "\n";
}