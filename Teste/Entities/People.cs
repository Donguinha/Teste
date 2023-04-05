using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Entities
{
    public class People
    {
        public List<Person> Person { get; set; } = new List<Person>();

        public static void AddPeople(List<Person> people)
        {
            string name;
            string age;
            bool gender = true;
            string intGender;

            Console.Write("Name: ");
            name = Console.ReadLine();

            do
            {
                Console.Write("Age: ");
                age = Console.ReadLine();

            } while (int.Parse(age) > 150 || int.Parse(age) < 0);

            do
            {
                Console.Write("Gender:\n1 to masculine || 2 to feminine: ");
                intGender = Console.ReadLine();

                if (intGender == "1") gender = true;

            } while (intGender != "1" && intGender != "2");

            people.Add(new Person(name, int.Parse(age), gender));
        }

        public static void AverageAge(IEnumerable<Person> people)
        {
            var media = 0;

            foreach (var person in people) media += person.Age;

            media = media / people.Count();

            Console.WriteLine("Average age of the group is " + media);
        }

        public static void OldestManName(IEnumerable<Person> people)
        {
            var oldMan = new Person("", 0, false);

            foreach (var person in people)
            {
                if (person.Gender)
                {
                    if (person.Age > oldMan.Age) oldMan = person;
                }
            }

            Console.WriteLine("\nThe oldest man name is " + oldMan.Name);
            Console.WriteLine();
        }

        public static void WomenUnder20(IEnumerable<Person> people)
        {
            var women = 0;

            foreach (var person in people)
            {
                if (person.Gender is false)
                {
                    if (person.Age < 20) women++;
                }
            }

            Console.WriteLine(women + " women under 20 years old");
        }
    }
}
