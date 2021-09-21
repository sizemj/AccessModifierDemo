using System;
using AccessModiferDemo;
namespace AccessModiferDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Does not work WHy?
            // MyStaticClass staticClass = new MyStaticClass(); 
            MyStaticClass.Greeter();
           
        }
    }
}
