using System;

namespace Array_Soma
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b=20;
            int x;

            Calculator.Triple(ref a);
            Calculator.Triple2(b, out x);


            Console.WriteLine(a);
            Console.WriteLine(x);

        }
    }
}
