using System.Text.Json;

namespace PersonService
{
    public class Person
    {
        public Person()
        {
            Name = "";
            Age = -1;
            Position = "";
        }

        public Person(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        
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