using System;

namespace n1_maior_ou_menor_que_n2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01, num02;
            
            Console.WriteLine("Informe um número inteiro: ");
            num01 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe mais um número inteiro: ");
            num02 = int.Parse(Console.ReadLine());

            if (num01 > num02)
            {
                Console.WriteLine("O primeiro número fornecido, {0}, é maior que o segundo número fornecido, {1}.",
                    num01, num02);
            }
            
            if (num01 < num02)
            {
                Console.WriteLine("O primeiro número fornecido, {0}, não é maior que o segundo número fornecido, {1}.",
                    num01, num02);
            }

            Console.ReadKey;
        }
    }
}