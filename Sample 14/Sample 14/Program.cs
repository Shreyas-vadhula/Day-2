using System;

namespace Sample_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int e=0;
            
            Console.WriteLine("Enter a string");
            string a = Console.ReadLine();
            char c = a[0];
            for(int i=0; i < a.Length; i++)
            {
                int b = 1;
                for (int j=i+1; j< a.Length;j++)
                {
                    if (a[i] != a[j])
                        break;
                    b++;
                }
                if (b > e)
                {
                    c = a[i];
                }
                e = b; 
            }
            Console.WriteLine("The most repeted character in the entered string is : " + c+ "and the count is \t"+e);
            Console.ReadLine();
        }
    }
}
