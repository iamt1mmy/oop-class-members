﻿namespace OopClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxLifespan = Person.MaxLifespanYears;
            Person p = new Person("2344");
            Console.WriteLine(p.FirstName); 
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.CNP);

            //Person.MaxLifespanYears
            //p.CNP = "2344";
            Person.PopulationCount = 1;
        }
    }
}