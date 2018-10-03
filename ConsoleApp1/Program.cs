using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic someObj = null;
            int somevar;
            try
            {
                somevar = (int)someObj;
            }
            catch (Exception e)
            {
                somevar = 25;
            }
            
            Console.Write(somevar);

            void SomeMethod()
            {
                // do something
                int i = 10;
                Console.WriteLine(i + 500 + i--);
            }
        }
    }

    class MyClass_1
    {
        // changes added by me
    }
}
