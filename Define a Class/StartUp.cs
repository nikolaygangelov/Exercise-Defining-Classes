using System;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new Person
            {
                Name = "Peter",
                Age = 20
            };
            Person george = new Person
            {
                Name = "George",
                Age = 18
            };
            Person jose = new Person
            {
                Name = "Jose",
                Age = 43
            };

            Console.WriteLine($"{peter.Name} is {peter.Age} years old");
            Person noName = new Person("gosho", 36);
            Console.WriteLine($"{noName.Name} is {noName.Age} years old");
        }
    }
}
