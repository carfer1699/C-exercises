using System;

namespace duração_de_um_jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int hi, mi, hf, mf, deltami, deltamf, deltam;
            
            Console.WriteLine("Informe a hora inicial: ");
            hi = int.Parse(Console.ReadLine());
            
            Console.WriteLine("informe os minutos iniciais: ");
            mi = int.Parse(Console.ReadLine());

            deltami = ((hi * 60) + mi);
            
            Console.WriteLine("Informe a hora final: ");
            hf = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe os minutos finais: ");
            mf = int.Parse(Console.ReadLine());

            deltamf = ((hf * 60) + mf);

            deltam = ((deltamf - deltami) / 60);
            
            Console.WriteLine("O JOGO DUROU {0} HORAS(S)", deltam);

            Console.ReadKey();

        }
    }
}