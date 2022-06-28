using System;
using System.Collections.Generic;
using System.Text;

namespace nothing
{
    class factorial
    {

        public int Factorial(int eded)
        {
            
            int defaultFact = 1;

            for (int i = 1; i <= eded; i++)
            {
                defaultFact *= i;
                
            }
            Console.WriteLine(defaultFact);
            return eded;
            

        }


    }
}
