using System;

namespace addaninstanceofaclass
{
    public class Person
    {
        private string name = "noname";
        public Person(string name){
            //constructor
            this.name = name;

            Console.WriteLine("Hi there "+name);
        }
        
    }
}

