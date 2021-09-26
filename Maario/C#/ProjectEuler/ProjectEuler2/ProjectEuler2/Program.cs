using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int PrimeiroN = 0, ProximoN = 1, Result= 0, Soma = 0;

            while (Result < 4000000)
            {
                Result = PrimeiroN + ProximoN;
                PrimeiroN = ProximoN;
                ProximoN = Result;
                if (Result % 2 == 0)
                {
                    Soma += Result;
                }
            }
            Console.WriteLine("O resultado é :" + Soma);
        }
    }
}
