using System;

namespace Sample_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = "Dummy  ";
            string sample1 = "Dummy1";
            Console.WriteLine(string.Compare(sample, sample1));
            Console.WriteLine(sample.Trim());
            Console.WriteLine(sample.ToLower());
            Console.WriteLine(sample.ToUpper());
            Console.ReadLine();
        }
    }
}
