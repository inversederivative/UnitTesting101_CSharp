namespace PersonService.Tests
{
    [TestClass]
    public class PersonServiceClassTest
    {
        private Person person;
        [TestInitialize]
        public void Setup()
        {
            person = new Person();
        }

        [TestCleanup]
        public void TearDown()
        {
            person = null;
        }
        
        [TestMethod]
        public void PersonInitialTest()
        {
            // Setup

            person.Name = "John";
            person.Age = 29;
            person.Position = "Programmer";
            
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
            string expectedOzzieJson = "{\"Name\":\"Ozzie\",\"Age\":28,\"Position\":\"Second Base\"}";
            var expectedAustin = new Person("Austin", 27, "Third Base");
            
            person.Name = "Ozzie";
            person.Age = 28;
            person.Position = "Second Base";
            
            string actualOzzieJson = person.ToJson();
            Assert.AreEqual(expectedOzzieJson, actualOzzieJson);

            
            string austinJson = "{\"Name\":\"Austin\",\"Age\":27,\"Position\":\"Third Base\"}";
            person = Person.FromJson(austinJson);
            Assert.AreEqual(expectedAustin.ToJson(), person.ToJson());
        }
    }        
}