using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class GroupOfPeople
    {
        List<Person> people;

        public GroupOfPeople()
        {
            people = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public List<Person> GetPeopleAbove30()
        {
            return people.OrderBy(p => p.name).Where(p => p.age > 30).ToList();
        }
    }
}
