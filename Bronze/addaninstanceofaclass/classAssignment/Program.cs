using System;

namespace classAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // Teachers //
        Console.Clear();

        Console.WriteLine("----------------------------------");
            Console.WriteLine("");
        Console.WriteLine("Teachers:");
            Teacher t1 = new Teacher("Erwin", "PRO/DIP");
            Console.WriteLine("");
            Teacher t2 = new Teacher("Erik", "PRO");
            Console.WriteLine("");
            Teacher t3 = new Teacher("Theo", "Nothing");
            Console.WriteLine("");
            Teacher t4 = new Teacher("Alex", "DVT-A");
            Console.WriteLine("");
        
        // Students //

        Console.WriteLine("----------------------------------");
            Console.WriteLine("");
        Console.WriteLine("Students:");
            Student s1 = new Student("Harry", "Mediadeveloper");
            Console.WriteLine("");
            Student s2 = new Student("Donny", "Gamedeveloper");
            Console.WriteLine("");
            Student s3 = new Student("Bjorn", "Gamedeveloper");
            Console.WriteLine("");
        
        // Parents //

        Console.WriteLine("----------------------------------");
            Console.WriteLine("");
        Console.WriteLine("Parents:");
            Parent p1 = new Parent("Reinette", "Welzijnskwartier");
            Console.WriteLine("");
            Parent p2 = new Parent("Leonard", "Bloemen");
            Console.WriteLine("");
        
        Console.WriteLine("----------------------------------");

        }
    }
}
