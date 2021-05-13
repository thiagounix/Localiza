using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza
{
    public static class Calculos
    {
        public static bool IsNumeroPrimo(int numero)
        {
            bool bPrimo = true;
            int fator = numero / 2;
            int i = 0;
            for (i = 2; i <= fator; i++)
            {
                if ((numero % i) == 0)
                    bPrimo = false;
            }
            return bPrimo;
        }

        static public ArrayList GetFatores(int num)
        {
            ArrayList vetor = new();
           
            for (int x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    vetor.Add(x);
                }
            }
            return vetor;
        }

    }
}
