using System;
namespace classAssignment
{
    public class Parent : Person
    {
        private string work;
        public Parent(string name, string work):base(name){
            this.work = work;
            Console.WriteLine(" Your job is " + work);
        }
    }
}