using NUnit.Framework;

using GymLib;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateNewCoach() 
        {
            Coach myCoach = new Coach();
            {
                myCoach.Name = "Kati";
            };
        }
    }
}