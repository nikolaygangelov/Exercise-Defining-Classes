using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            GroupOfPeople groupOfPeople = new GroupOfPeople();
            for (int i = 0; i < N; i++)
            {
                string[] namesAndAges = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string nameFromConsole = namesAndAges[0];
                int ageFromConsole = int.Parse(namesAndAges[1]);

                Person person = new Person(nameFromConsole, ageFromConsole);
                groupOfPeople.AddPerson(person);
            }
            List<Person> allAbove30 = new List<Person>(groupOfPeople.GetPeopleAbove30());

            foreach (var person in allAbove30)
            {
                Console.WriteLine($"{person.name} - {person.age}");
            }
        }
    }
}
