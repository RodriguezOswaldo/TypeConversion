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
            //converting string to byte (byte can only get 232 digits)
            //Therefore this will throw an error which we can fix by putting it inside a try-catch block.
            //var number = "1234";
            //int b = Convert.ToByte(number);
            //Console.WriteLine(b);
            try
            {
                var number2 = "1234";
                int num2 = Convert.ToByte(number2);
                Console.WriteLine(num2);
            }
            catch (Exception)
            {
                Console.WriteLine("The number is too big to be converted to a byte.");
            }

        }
    }
}
