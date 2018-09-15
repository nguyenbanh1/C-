using System;

namespace Plugin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("oke " + System.Configuration.ConfigurationManager.ConnectionStrings["ok"].ConnectionString);
            Console.ReadKey();
        }
    }
}
