using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere a Altura do Cilindro: ");
            string b = Console.ReadLine();

            Console.WriteLine("Insere o Raio do Cilindro: ");
            string c = Console.ReadLine();

            double a = double.Parse(b);
            double r = double.Parse(c);

            double V = Math.PI * Math.Pow(r,2)*a;
            
            double Sa= 2*Math.PI*r*(r+a);

            Console.WriteLine($"{V:f3}");
            Console.WriteLine($"{Sa:f3}");
        }
    }
}
