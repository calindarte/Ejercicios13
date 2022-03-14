using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite un numero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero%10==0)
            {
                Console.WriteLine("El numero " + numero + " es multiplo de 10");

            }
            else
            {
                Console.WriteLine("El numero no es multiplo de 10");
            }
        }
    }
}
