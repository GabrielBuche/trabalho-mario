#include <iostream>
using namespace std;

int main()
{
    
    int NumAnt1 = 0;
    int NumAtual = 1;
    
    int SomaFibonacio = 0;
    
    while(NumAtual <= 4000000)
    {
       
        SomaFibonacio += (NumAtual % 2 == 0) ?
            NumAtual : 0;
        
        
        int NumAnt2 = NumAnt1;
        NumAnt1 = NumAtual;
        NumAtual = NumAnt2 + NumAnt1;
    }
    
    cout << SomaFibonacio << "\n";
}