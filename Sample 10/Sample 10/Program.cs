using System;

namespace Sample_10
{
    class Program
    {
        static void Main(string[] args)
        {
            object str = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(values);
            Console.WriteLine("Using Equality operator{0} ", str == str2);
            Console.WriteLine("Using Equals method{0} ", str.Equals(str));
            Console.ReadLine();
        }
    }
}
