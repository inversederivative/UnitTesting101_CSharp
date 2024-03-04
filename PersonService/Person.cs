using System.Text.Json;

namespace PersonService
{
    public class Person
    {
        private string _name = ""; // Initialized to "", so it's not null
        private int _age;
        private string _position = "";

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        public Person(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        // We should make this function static, because we won't have an object of this class
        // when we're creating a new one from a json string.
        public static Person FromJson(string json)
        {
            // The ! is the Null-Forgiving Operator 
            return JsonSerializer.Deserialize<Person>(json)!;
        }
    }
}