using System;

namespace numero_negativo_ou_positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Informe um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("O número fonecido '{0}' é negativo.", num);
            }

            if (num > 0)
            {
                Console.WriteLine("O número '{0}' é positivo.", num);
            }

            Console.ReadKey();
        }
    }
}