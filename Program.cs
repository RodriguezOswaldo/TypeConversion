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

            //The Object
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            //Calculator Class

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            //Array
            var numbers = new int[3] {1, 2, 3};
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            var names = new string[3] {"Jack", "John", "Mary"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

        }
    }
}
