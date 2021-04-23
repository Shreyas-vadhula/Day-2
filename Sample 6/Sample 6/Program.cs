using System;

namespace Sample_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter something");
            var a = Console.ReadLine();
            int result;
            int.TryParse(a, out result);
            if (result == 0)
                Console.WriteLine("Not a number");
            else
                Console.WriteLine("it is a number");
            Console.ReadLine();
        }
    }
}
