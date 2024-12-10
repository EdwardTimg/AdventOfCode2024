using AdventOfCode2024;

internal class Program
{
    private static void Main(string[] args)
    {
        string filepath_dayone = "C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayone.txt";

        Console.WriteLine("Day one part 1 solution: " + DayOne.DistanceCalc(filepath_dayone));
        List<int> rightlist = DayOne.makeLists(filepath_dayone, 1);
        List<int> leftlist = DayOne.makeLists(filepath_dayone, 0);
        Console.WriteLine("Day one part 2 solution: " + DayOne.CaluclateRepeasts(leftlist, rightlist));

        Console.WriteLine("Day Two Part 1 Solution: " +DayTwo.SafeNumbers("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayTwo.txt"));
        Console.WriteLine("Day Two Part 2 Solution: " + DayTwo.DamperReportSafeNumers("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayTwo.txt"));

        Console.WriteLine("Day Three Part 1 solution: " + DayThree.mulCalc("C:\\Users\\edwtim\\source\\repos\\AdventOfCode2024\\AdventOfCode2024Test\\input\\dayThree.txt"));
    }
}