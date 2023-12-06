namespace Day6_WaitForIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input  test data part1
            int[] testraceTimes = { 7, 15, 30 };
            double[] testrecordDistances = { 9, 40, 200 };

            // Input test data part2
            double[] testraceTimesPart2 = { 71530 };
            double[] testrecordDistancesPart2 = { 940200 };

            //part1
            int[] part1Times = { 53, 89, 76, 98 };
            double[] part1Distances = { 313, 1090, 1214, 1201 };

            //part2
            double[] part2Times = { 53897698 };
            double[] part2Distances = { 313109012141201 };

            Console.WriteLine("part1 test input: ");
            Solve1(testraceTimes, testrecordDistances);

            Console.WriteLine("part1 input: ");
            Solve1(part1Times, part1Distances);

            Console.WriteLine("part2 test input: ");
            Solve2(testraceTimesPart2, testrecordDistancesPart2);

            Console.WriteLine("part2 input: ");
            Solve2(part2Times, part2Distances);

        }
        static void Solve1(int[] raceTimes, double[] recordDistances)
        {
            double final = 1;
            for (int i = 0; i < raceTimes.Length; i++)
            {
                final *= BeatRecord(raceTimes[i], recordDistances[i]);
            }

            Console.WriteLine("The total number of ways you could beat the record in each race is: " + final);
        }

        static void Solve2(double[] raceTimes, double[] recordDistances)
        {
            double final = 1;
            for (int i = 0; i < raceTimes.Length; i++)
            {
                final = BeatRecord(raceTimes[i], recordDistances[i]);
            }

            Console.WriteLine("The total number of ways you could beat the record in each race is: " + final);
        }

        static double BeatRecord(double time, double dist)
        {
            double beaten = 0;
            for (int acc = 1; acc < time; acc++)
            {
                double newDist = (time - acc) * acc;
                beaten = newDist > dist ? beaten + 1 : beaten;
            }

            return beaten;
        }

    }
}