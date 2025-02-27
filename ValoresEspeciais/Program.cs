using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(Int128.MaxValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(Int128.MinValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(decimal.MinValue);
        }
    }
}
