using System;

namespace salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, s01, s02, s03;
            Console.WriteLine("Informe o salário: ");
            salario = double.Parse(Console.ReadLine());

            s01 = (salario - 2000.00);
            s02 = (s01 - 1000.00);
            s03 = ((salario* 28) / 100);

            if (salario < 2000.00)
            {
                Console.WriteLine("Isento.");
            }
            else if (salario > 2000.00 && salario < 3000.00)
            {
                Console.WriteLine("R" + ((s01 * 8)/100));
            }
            else if (salario > 3000.01 && salario < 4500.00)
            {
                Console.WriteLine("R" + (((s01 * 8)/100) + ((s02 * 18)/100)));
            }
            else if (salario > 4500.00)
            {
                Console.WriteLine("R{0}", s03);
            }
            Console.ReadKey();
        }
    }
}