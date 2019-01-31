using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Greet_User(name);
            }
            catch
            {
                Console.WriteLine("Your 'name' is apparently incomprehensible...");
                Console.ReadKey();
            }
        }

        private static void Greet_User(string get_name)
        {
            Console.WriteLine("Hello " + get_name + "!");
            Console.ReadKey();
        }
    }
}
