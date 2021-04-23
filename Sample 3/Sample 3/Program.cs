using System;

namespace Sample_3
{
    class Program
    {
        void swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("The value of a after swapping is " + a);
            Console.WriteLine("The value of b after swapping is " + b);
        }
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Enter a number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            j = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.swap(i,j);
            Console.ReadLine();
        }
    }
}
