using System;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

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
                Console.WriteLine("some new code");
                Console.WriteLine("some new code");
                Console.WriteLine("some new code");
            }

            // added by NB_1
            catch (Exception e)
            {
            }

            // added by NB_1
            // added by NB_1
            // added by NB_1
            

        }

        //    NB_1
        public int GetSquare(int number) => number * number;
        
        //    NB_1
        public double GetSqrt(int number) => Math.Sqrt(number);
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
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }
        public int Prop3 { get; set; }
        public int Prop4 { get; set; }
        
    }
}    
