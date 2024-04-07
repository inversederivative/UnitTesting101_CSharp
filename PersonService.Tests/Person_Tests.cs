namespace PersonService.Tests
{
    [TestClass]
    public class PersonServiceClassTest
    {
        [TestMethod]
        public void PersonInitialTest()
        {
            // Setup
            Person person = new Person("John", 29, "Programmer");
            string expectedName = "John";
            int expectedAge = 29;
            string expectedPosition = "Programmer";
            
            // Tests
            Assert.AreEqual(expectedName, person.Name);
            Assert.AreEqual(expectedAge, person.Age);
            Assert.AreEqual(expectedPosition, person.Position);
        }
        [TestMethod]
        public void PersonJsonTest()
        {
            var ozzie = new Person("Ozzie", 28, "Second Base");
            string actualOzzieJson = ozzie.ToJson();

            string eddieJson = "{\"Name\":\"Eddie\",\"Age\":32,\"Position\":\"Left Field\"}";
            var eddie = Person.FromJson(eddieJson);

            string expectedOzzieJson = "{\"Name\":\"Ozzie\",\"Age\":28,\"Position\":\"Second Base\"}";
            var expectedEddie = new Person("Eddie", 32, "Left Field");

            Assert.AreEqual(expectedOzzieJson, actualOzzieJson);
            Assert.AreEqual(expectedEddie.ToJson(), eddie.ToJson());
        }
    }        
}
