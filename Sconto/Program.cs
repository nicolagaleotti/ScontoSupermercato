using System;

namespace Sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Totale della spesa? ");
            double totale = double.Parse(Console.ReadLine());
            double scontato;
            if (totale > 100)
            {
                scontato = totale - totale / 100 * 20;
                Console.WriteLine($"L'importo scontato è {scontato} euro");
            }
            else
            {
                Console.WriteLine($"Non è applicabile lo sconto. Paghi {totale} euro");
            }
            Console.ReadLine();
        }
    }
}
