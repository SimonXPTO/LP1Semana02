using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Max Value All types

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

            //Min Value All types

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

            //Special Value Double
            
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

            //Special Value Float
            
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);

            //Overflow Uint

            uint a = uint.MaxValue;
            Console.WriteLine(a+1);

            //Overflow Float

            float b = float.MaxValue;
            Console.WriteLine(b+1);
            Console.WriteLine(b*2);

            //Underflow Float

            float f, f1;
            f = f1 = 20000.0f;
            Console.WriteLine(f==f1 + 0.00001f);
            
        }
    }
}
