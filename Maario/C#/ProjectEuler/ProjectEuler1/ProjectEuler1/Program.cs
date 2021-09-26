using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1000;
            int result = 0;
            for (int i = 3; i < N; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result+= i;
            }
            Console.WriteLine("o resultado é: "+ result);
        }
    }
}
