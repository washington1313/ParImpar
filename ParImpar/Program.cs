using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero;
            
            Console.WriteLine("Digite o número: ");

            numero = float.Parse(Console.ReadLine());

            if (numero % 2 ==  0) 
            {
                Console.WriteLine("O número informado é PAR. ");

            }
            else
            {
                Console.WriteLine("O número informado é ÍMPAR. ");
            }


            Console.ReadKey();


        }
    }
}
