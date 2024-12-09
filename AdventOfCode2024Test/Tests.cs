
using AdventOfCode2024;

namespace AdventOfCode2024Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }


        [Test]
        public void exampleOrder()
        {
            Assert.AreEqual(11, DayOne.DistanceCalc("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayoneExample.txt"));
        }
    }
}