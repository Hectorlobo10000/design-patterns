using System;

namespace SinglePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The Singleton Pattern : ensures a class has only one instance, and provides a global point of access to it.
             */

            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.Welcome($"Welcome to Singleton pattern")); ;

           Console.ReadKey();
        }
    }
}
