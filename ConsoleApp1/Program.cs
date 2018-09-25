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
        }
    }
}