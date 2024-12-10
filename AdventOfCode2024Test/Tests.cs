
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
        public void DayOne_PartOne_exampleOrder()
        {
            Assert.AreEqual(11, DayOne.DistanceCalc("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayoneExample.txt"));
        }

        [Test]
        public void DayOne_partTwo_NumberOfRepease()
        {
            List<int> rightlist = DayOne.makeLists("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayoneExample.txt", 1);
            List<int> leftlist = DayOne.makeLists("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayoneExample.txt", 0);
            Assert.AreEqual(31, DayOne.CaluclateRepeasts(leftlist,rightlist));
        }

        [Test]
        public void DayTwo_PartOne()
        {
            Assert.AreEqual(2, DayTwo.SafeNumbers("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayTwoExample.txt"));
        }


        [Test]
        public void DayTwo_PartTwo()
        {
            Assert.AreEqual(4, DayTwo.DamperReportSafeNumers("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayTwoExample.txt"));
        }

        [Test]
        public void DayThree_PartOne()
        {
            Assert.AreEqual(161, DayThree.mulCalc("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayThreeExample.txt"));
        }

        [Test]
        public void DayThree_PartTwo()
        {
            Assert.AreEqual(48, DayThree.mulcalcPartTwo("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayThreeExample_partTwo.txt"));
        }
    }

}