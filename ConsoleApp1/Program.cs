using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mc = new MyClass_1();
            int somevar;
            try
            {
                Console.WriteLine("some new code");
            }
            catch (Exception e)
            {
                //    exception
            }
            
        }
    }

    class MyClass_1
    {
        
    }

    class MyClass2
    {
        public int GetterSetter { get; set; }
        public string GetterSetter1 { get; set; }
    }
}