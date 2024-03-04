namespace PersonService.Tests
{
    public class PersonServiceClassTest
    {
        // This effectively declares the function as a unit test for JTest
        [Fact]
        public void PersonInitialTest()
        {
            // Setup
            Person person = new Person("John", 29, "Programmer");
            string expectedName = "John";
            int expectedAge = 29;
            string expectedPosition = "Programmer";
        
            // Tests
            Assert.Equal(expectedName, person.Name);
            Assert.Equal(expectedAge, person.Age);
            Assert.Equal(expectedPosition, person.Position);
            
        }
        [Fact]
        public void PersonJsonTest()
        {
            var ozzie = new Person("Ozzie", 28, "Second Base");
            string actualOzzieJson = ozzie.ToJson();
            
            string eddieJson = "{\"Name\":\"Eddie\",\"Age\":32,\"Position\":\"Left Field\"}";
            var eddie = Person.FromJson(eddieJson);
            
            string expectedOzzieJson = "{\"Name\":\"Ozzie\",\"Age\":28,\"Position\":\"Second Base\"}";
            var expectedEddie = new Person("Eddie", 32, "Left Field");

            Assert.Equal(expectedOzzieJson, actualOzzieJson);
            Assert.Equal(expectedEddie.ToJson(), eddie.ToJson());
        }
    }
}
