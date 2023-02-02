using System;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < N; i++)
            {
                string [] namesAndAges = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string nameFromConsole = namesAndAges[0];
                int ageFromConsole = int.Parse(namesAndAges[1]);

                Person person = new Person
                {
                    Name = nameFromConsole,
                    Age = ageFromConsole
                };
                family.AddMember(person);
            }

            Person old = old = family.GetOldestMember();

            Console.Write($"{old.Name} {old.Age}");

            
        }
    }
}
