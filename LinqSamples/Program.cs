using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Samples {
    class Program {

       
        static void Main (string[] args) {
            var people = Person.GenerateListOfPeople ();//.OrderBy (x => x.Age);
            foreach (var p in people)
                Console.WriteLine ($"{p.FirstName},{p.Age}");

            //Where ,Skip and Take examples
             IEnumerable<Person> peoples = people.Where(p=>p.Age > 30).Skip(1).Take(0);

            //Changing Each Item in Collections
            IEnumerable<string> allFirstNames = people.Select (p => p.FirstName);
            IEnumerable<FullName> allFullNames = people.Select(x=> new FullName{ First=x.FirstName,Last=x.LastName});
            foreach (var p in allFullNames)
                Console.WriteLine ($"{p.Last}, {p.First}");
            try {
                var firstPerson = people.LastOrDefault(x => x.Age > 30); //LastOrDefault (x => x.Age != 30);
                Console.WriteLine (firstPerson.FirstName);
            } catch (InvalidOperationException e) {
                Console.WriteLine (e.Message);
            }

            string[] stringArray = {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };
            //print string characters using Linq
            IEnumerable<char> stringChar = stringArray.SelectMany (s => s);
            int size = Convert.ToInt16 (stringChar.Count ());
            foreach (char c in stringChar)

                Console.Write ($"{c},");

           

        }
    }
}
