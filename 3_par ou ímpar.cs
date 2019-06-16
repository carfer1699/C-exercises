using System;

namespace n_par_ou_ímpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("informe um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número, {0}, fornecido é par.", num);
            }
            else
            {
                if (num * 2 != 0)
                {
                                Console.WriteLine("O número, {0}, fornecido é ímpar.", num);
                }
            }
        }
    }
}