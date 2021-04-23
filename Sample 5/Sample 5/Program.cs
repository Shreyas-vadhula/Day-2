using System;

namespace Sample_5
{
    class Program
    {
        void Swap(out int a)
        {
            a = 6;  
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.Swap(out a);
            Console.WriteLine("The value of a before swapping is " + a);
            Console.ReadLine();
        }
    }
}
