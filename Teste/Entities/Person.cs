namespace Teste.Entities
{
    public class Person
    {
        public Person(string name, int age, bool gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public Guid Id { get; }
        public string Name { get; init; }
        public int Age { get; init; }
        public bool Gender { get; init; }
    }
}
