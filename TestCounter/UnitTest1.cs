using DemoCICD;

namespace TestCounter
{
    public class Tests
    {
        private string stringToCheck;

        [SetUp]
        public void Setup()
        {
            stringToCheck = "Mysterious";
        }

        [Test]
        public void ShouldFindOneYInMysterious()
        {
            var stringToFind = "y";
            var expectedResult = 1;
            var classUnderTest = new PmmTestDevopdDemo();
            var actualResult = classUnderTest.CountOccurrance(stringToCheck, stringToFind);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ShouldFindTwoSInMysterious()
        {
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new PmmTestDevopdDemo();
            var actualResult = classUnderTest.CountOccurrance(stringToCheck, stringToFind);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void ShouldBeCaseSensitive()
        {
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new PmmTestDevopdDemo();
            var actualResult = classUnderTest.CountOccurrance(stringToCheck, stringToFind);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void ShouldBeAbleToHandleNulls()
        {
            string stringToCheck = null;
            var stringToFind = "s";
            var expectedResult = -1;
            var classUnderTest = new PmmTestDevopdDemo();
            var actualResult = classUnderTest.CountOccurrance(stringToCheck, stringToFind);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
        [Test]
        public void ShouldBeAbleToHandleNoValueFound()
        {
            string stringToFind = null;
            var expectedResult = 0;
            var classUnderTest = new PmmTestDevopdDemo();
            var actualResult = classUnderTest.CountOccurrance(stringToCheck, stringToFind);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [TearDown]
        public void TearDownAfterTest()
        {
            stringToCheck = string.Empty;
        }
    }
}