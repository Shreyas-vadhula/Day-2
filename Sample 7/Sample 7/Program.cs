using System;

namespace Sample_7
{
    class Author
    {
        public String Name;
        public int rank;
    }
    class Program
    {
        public String Name2;
        public int rank2;

        static void Main(string[] args)
        {
            Program pro = new Program();
            Author aut = new Author();
            bool result;
            result = aut is Author;
            Console.WriteLine(result);
            result = aut is Program;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
