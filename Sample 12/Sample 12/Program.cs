using System;

namespace Sample_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string a = Console.ReadLine();
            string b = string.Empty;
            for (int i = a.Length-1; i>-1;i--)
            {
              b += a[i];
            }
            Console.WriteLine("Reversed string is \t"+b);
            if (a == b)
                Console.WriteLine("The string is palandrome");
            else
                Console.WriteLine("The string is not palandrome");
            Console.ReadLine();

        }
    }
}
