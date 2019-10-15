using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            */
            int i = 1;
            //Specifying the cast. (variable type)
            byte b = (byte) i;
            Console.WriteLine(b);

            var number = "1234";
            int num = Convert.ToInt32(number);
            Console.WriteLine(num);
        }
    }
}
