using System;

namespace valor_da_conta
{
    class Program
    {
        static void Main(string[] args)
        {
            double cq = 4.00, xs = 4.50, xb = 5.00, t = 2.00, r = 1.50;
            int p, q;

            Console.WriteLine("--SEJA BEM VINDO AO NOSSO AUTOSERVIÇO DE LANCHES--");
            Console.WriteLine("PARA REALIZAR SEU PEDIDO DIGITE O CÓDIGO RORRESPONDENTE AO PRODUTO.");
            Console.WriteLine("DIGITE 1 PARA CACHORRO QUENTE, 2 PARA X-SALADA, 3 PARA X-BACON, 4 PARA TORRADA SIMPLES E 5 PARA REFRIGETRANTE.");
            p = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade desejada: ");
            q = int.Parse(Console.ReadLine());

            if (p == 1)
            {
                Console.WriteLine("Valor a pagar é de R$ " + (cq * q));
            }
            else if (p == 2)
            {
                Console.WriteLine("Valor a pagar é de R$ " + (xs * q));
            }
            else if (p == 3)
            {
                Console.WriteLine("Valor a pagar é de R$ " + (xb * q));
            }
            else if (p == 4)
            {
                Console.WriteLine("Valor a pagar é de R$ " + (t * q));
            }
            else if (p == 5)
            {
                Console.WriteLine("Valor a pagar é de R$ " + (r * q));
            }

            Console.ReadKey();
        }
    }
}