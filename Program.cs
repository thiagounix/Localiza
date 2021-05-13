using System;
using System.Linq;
using System.Collections;

namespace Localiza
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            var num = Convert.ToInt32(Console.ReadLine()); 
            Console.Clear();
            ArrayList vetor = new();
            
            var numfator = Calculos.GetFatores(num);
            
            foreach (var item in numfator)
            {
                if (Calculos.IsNumeroPrimo((int)(item)) == true)
                    vetor.Add(item);
            }
           
            Console.WriteLine($"Número de Entrada: \t {num}");


            Console.Write($"Números divisores: ");
            foreach (int item in numfator)
            {
                Console.Write(item+" ");
            }
         
            Console.WriteLine();
            Console.Write($"Divisores Primos: ");
            foreach (int item in vetor)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }



    }
}
