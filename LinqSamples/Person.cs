using System;
using System.Collections.Generic;

namespace Linq_Samples {
    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }

        public List<string> Cars { get; set; }

        public static List<Person> GenerateListOfPeople () {
            var people = new List<Person> ();

            people.Add (new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24, Cars = new List<string> { "Maruthi", "Honda" } });
            people.Add (new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40, Cars = new List<string> { "Robels", "Benz" } });
            people.Add (new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30, Cars = new List<string> { "Maruthi", "Ford" } });
            people.Add (new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35, Cars = new List<string> { "Peacock", "Honda" } });
            people.Add (new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24, Cars = new List<string> { "Maruthi", "Swift" } });

            return people;
        }

    }

     public class FullName {
            public string First { get; set; }
            public string Last { get; set; }
        }
}