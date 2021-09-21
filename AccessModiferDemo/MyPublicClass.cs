using System;

namespace AccessModiferDemo
{
    public class MyPublicClass
    {
        //Has a private member for demo
        private string nameString = "FirstName, LastName";
        protected internal int MyAge = 45;

        public string GetName(string myName)
        {
            //I can use nameString because a private member is local to the class
            Console.WriteLine(nameString);
            return myName;
            
        }
    }
}