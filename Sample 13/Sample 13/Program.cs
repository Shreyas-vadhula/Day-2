using System;

namespace Sample_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=0;
            Console.WriteLine("Enter a string");
            string a = Console.ReadLine();
            for (int i=0;i<a.Length;i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                    b ++;
            }
            Console.WriteLine("total number of vowels in the entered string is \t" +b);
            Console.ReadLine();
        }
    }
}
