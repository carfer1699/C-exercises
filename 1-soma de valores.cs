using System;

namespace area_da_circunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, Pi, a;
            Pi = 3.14159;
            Console.WriteLine("Informe um valor para o raio da circunferência: ");
            r = double.Parse(Console.ReadLine());

            a = (Pi * (r * r));

            Console.WriteLine("A área da circunferência é igual a " + a.ToString("F2"));

            Console.ReadKey();
        }
    }
}
