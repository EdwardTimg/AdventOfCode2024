
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

        [Test]
        public void DayFour_PartOne()
        {
            Assert.AreEqual(18, DayFour.CountXmas("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayFourExample.txt"));
        }

        [Test]
        public void DayFour_PartTwo()
        {
            Assert.AreEqual(9, DayFour.CountMas("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayFourExample.txt"));
        }

        [Test]
        public void DayFive_PartOne()
        {
            Assert.AreEqual(143, DayFive.printingCalc("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayFiveRulesExampel.txt", "C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayFiveOrderExample.txt"));
        }

        [Test]
        public void DayFive_PartTwo()
        {
            Assert.AreEqual(123, DayFive.printingCalcRearange("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayFiveRulesExampel.txt", "C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayFiveOrderExample.txt"));
        }

        [Test]
        public void DaySix_PartOne()
        {
            Assert.AreEqual(41, DaySix.pathCalc("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\daySixExample.txt"));
        }
        [Test]
        public void DaySix_PartOneSecondExample()
        {
            Assert.AreEqual(4, DaySix.pathCalc("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\DaySixSecondExample.txt"));
        }
    }

}