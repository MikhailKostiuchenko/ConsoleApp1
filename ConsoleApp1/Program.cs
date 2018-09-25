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
            
            // added by NB_1
            catch (Exception e)
            {
                somevar = 25;
                // deleted by NB_1
            }
            
            // added by NB_1
            // added by NB_1
            // added by NB_1
            
        }
    }

    class MyClass_1
    {
        //    Created by NewBranch_1
        void SomeMethod()
        {
            
        }
        
    }

    class MyClass2
    {
        // DELETED by NB_1
        public string GetterSetter1 { get; set; }
    }

    class MyClass3
    {
        // ADDED by NB_1
    }
}