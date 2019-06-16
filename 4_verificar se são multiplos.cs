using System;

namespace verificar_se_são_multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01, num02;
            
            Console.WriteLine("Infrome um número; ");
            num01 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Infrome outro número; ");
            num02 = int.Parse(Console.ReadLine());

            if (num02 % num01 == 0) 
            {
                Console.WriteLine("São multiplos.");
            }
            else if (num01 % num02 == 0)
            {
                    Console.WriteLine("São multiplos.");
            }
            else if (num01 % num02 != 0)
            {
                    Console.WriteLine("Não são Multiplos.");
            }
            
            Console.ReadKey();
        }
    }
}