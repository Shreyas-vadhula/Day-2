using System;

namespace Sample_4
{
    class Program
    {
        void swap(ref int a, ref int b)
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
            int a, b;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            b = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.swap(ref a,ref b);
            Console.WriteLine("The value of a before swapping is " + a);
            Console.WriteLine("The value of b before swapping is " + b);
            Console.ReadLine();
        }
    }
}
