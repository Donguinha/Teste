using Teste.Entities;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new People();
            string repeat;

            do
            {
                People.AddPeople(people.Person);
                Console.WriteLine("\npress anything to add another person\notherwise press 0 to continue");
                repeat = Console.ReadLine();

                Console.Clear();

            } while (repeat != "0");

            People.AverageAge(people.Person);
            People.OldestManName(people.Person);
            People.WomenUnder20(people.Person);
        }
    }
}