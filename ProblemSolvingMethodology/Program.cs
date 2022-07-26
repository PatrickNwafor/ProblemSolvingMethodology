using ProblemSolvingMethodology.Examples;
using ProblemSolvingMethodology.Exercise1;

class Program
{
    static void Main()
    {
        // Card Shuffle Example
        CardShuffle.Test();
        // Number Sorting Example
        Sort10000Numbers.Test();

        Console.WriteLine();

        // Exercise 1
        Console.WriteLine("Exercise 1");
        // LinesOnPlaneTest.TestPointsListToHashMap();
        // LinesOnPlaneTest.EqualityAtBothSideOfLineTest();
        LinesOnPlaneTest.GetVerticalLineTest();
        LinesOnPlaneTest.GetHorizontalLineTest();
        LinesOnPlaneTest.PerformanceTest();
    }
}
