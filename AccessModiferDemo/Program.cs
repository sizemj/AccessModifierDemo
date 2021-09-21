using System;

namespace AccessModiferDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Does not work Why?
            // MyStaticClass staticClass = new MyStaticClass();

            //Why does this work
            MyStaticClass.Greeter();

            //Public class instantiation
            // New C# syntax
            MyPublicClass myPublicClassObject = new();

            //Can also be done the old way
            // MyPublicClass mypublicclass = new MyPublicClass();

            //Why cannot I not do this?
            //string name = mypublicclass.nameString;

            //Why can I do this?
            string name1 = myPublicClassObject.GetName("Jason Sizemore");
            Console.WriteLine($"My name is {name1}");
           
            var baseObject = new MyPublicClass();
            var myAge = baseObject.MyAge = 40;
            Console.WriteLine($"My age is: {myAge}");
        }
    }
}