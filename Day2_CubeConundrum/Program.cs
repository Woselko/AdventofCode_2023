﻿namespace Day2_CubeConundrum;

internal class Program
{
    private const int redCubes = 12;
    private const int greenCubes = 13;
    private const int blueCubes = 14;

    static void Main(string[] args)
    {
        var input = "Game 1: 2 green, 12 blue; 6 red, 6 blue; 8 blue, 5 green, 5 red; 5 green, 13 blue; 3 green, 7 red, 10 blue; 13 blue, 8 red\nGame 2: 1 green, 7 red; 1 green, 9 red, 3 blue; 4 blue, 5 red\nGame 3: 2 red, 2 blue, 6 green; 1 blue, 2 red, 2 green; 3 blue, 3 green\nGame 4: 8 green, 16 red, 7 blue; 1 red, 7 blue, 12 green; 8 green, 14 red, 1 blue; 6 blue, 9 green, 12 red; 9 red, 2 green; 8 red, 7 blue, 17 green\nGame 5: 2 red, 7 green; 2 red, 1 green, 4 blue; 4 blue, 7 green, 5 red; 8 red, 2 blue, 5 green\nGame 6: 20 red, 4 green, 3 blue; 12 green, 1 blue, 9 red; 8 green, 15 red, 1 blue; 17 red, 5 blue, 7 green\nGame 7: 2 red, 2 blue, 5 green; 3 blue, 1 green, 2 red; 2 green, 2 blue; 2 green, 1 red, 1 blue; 1 blue, 6 green; 1 green, 2 red\nGame 8: 18 red, 1 green, 3 blue; 7 blue, 3 green, 18 red; 2 green\nGame 9: 13 blue; 13 blue; 3 red, 13 blue; 1 red, 8 blue; 1 green, 8 blue, 1 red\nGame 10: 15 blue, 1 green, 12 red; 13 red, 13 green, 5 blue; 2 blue, 3 red, 7 green\nGame 11: 2 blue, 17 red, 5 green; 6 red, 2 green, 12 blue; 7 green, 5 blue, 14 red\nGame 12: 12 blue, 10 green, 14 red; 7 red, 3 green; 10 blue, 2 red; 4 red, 5 blue, 7 green\nGame 13: 1 red, 13 blue, 14 green; 1 green, 1 red, 7 blue; 5 red, 15 blue, 14 green\nGame 14: 2 blue, 1 red, 9 green; 4 blue, 3 red; 2 red, 7 green; 2 red, 4 green\nGame 15: 5 green, 7 blue, 18 red; 10 blue, 4 green, 4 red; 13 blue, 16 red; 18 red, 4 green; 1 blue, 6 green, 17 red; 9 blue, 2 green, 15 red\nGame 16: 15 green, 3 red, 4 blue; 3 blue, 16 green; 5 green, 2 blue, 1 red; 6 blue, 3 red, 12 green; 2 red, 3 green\nGame 17: 10 green, 4 blue, 11 red; 6 green, 13 red, 6 blue; 2 blue, 5 green, 2 red\nGame 18: 1 red, 13 blue; 4 green, 5 red; 3 green, 1 red, 12 blue; 1 green, 15 blue; 7 red, 1 green, 15 blue\nGame 19: 2 blue, 6 green, 4 red; 4 green, 15 red; 3 blue, 8 red, 7 green\nGame 20: 7 blue, 7 red, 10 green; 5 red, 1 green, 9 blue; 1 blue, 6 red, 12 green; 1 red, 11 green; 6 green, 9 blue, 4 red\nGame 21: 4 red, 16 green, 10 blue; 2 blue, 14 green; 6 green, 4 blue; 7 blue, 6 red; 6 red, 10 green, 6 blue\nGame 22: 5 green, 2 red; 5 green, 3 red, 1 blue; 2 red, 1 green, 7 blue; 3 red, 11 green, 4 blue; 6 blue, 10 green, 2 red; 5 blue, 2 green, 2 red\nGame 23: 3 blue, 3 red; 6 blue, 6 green, 2 red; 3 green, 15 blue, 2 red; 2 green, 1 blue, 2 red; 5 green, 5 blue; 5 green, 10 blue, 7 red\nGame 24: 1 blue, 19 green; 18 green, 1 red, 2 blue; 5 green; 2 blue, 3 green, 1 red; 1 red, 5 green; 9 green, 1 red\nGame 25: 1 green, 1 red, 7 blue; 2 green, 10 blue, 1 red; 8 red, 1 blue, 1 green\nGame 26: 7 blue, 2 green, 2 red; 8 blue, 6 green, 9 red; 5 red, 11 green, 2 blue; 7 blue, 5 red, 9 green; 10 blue, 12 green, 4 red\nGame 27: 9 blue, 1 red; 15 blue, 2 red; 2 red, 11 blue; 15 blue, 4 red, 1 green; 4 red, 1 green\nGame 28: 9 green, 7 blue; 8 green, 3 red, 2 blue; 3 red, 11 blue, 7 green; 3 red, 3 blue; 9 green, 2 red\nGame 29: 2 green, 3 blue, 1 red; 13 blue, 2 green, 8 red; 3 green, 12 red, 9 blue\nGame 30: 9 red, 18 green, 6 blue; 1 green, 3 blue, 5 red; 6 blue, 12 green, 3 red\nGame 31: 6 green, 1 red; 1 blue, 4 red, 10 green; 11 green, 1 blue, 4 red; 2 green; 1 red, 1 green; 8 green\nGame 32: 7 green, 8 blue, 1 red; 4 red, 5 blue, 8 green; 5 green, 2 blue; 2 red, 3 green, 2 blue\nGame 33: 1 red, 1 blue; 16 red, 1 green, 2 blue; 1 blue, 13 red; 1 blue, 1 green, 17 red; 6 red, 1 blue, 1 green; 10 red, 2 blue\nGame 34: 10 red, 13 green; 18 blue, 6 green; 5 blue, 1 red, 11 green; 8 green, 1 red, 9 blue; 11 blue, 10 red, 12 green\nGame 35: 4 red, 2 green; 4 red, 3 blue, 7 green; 3 blue, 2 green, 7 red\nGame 36: 1 blue, 8 red, 9 green; 2 green, 9 red, 2 blue; 8 blue, 10 green, 12 red; 9 blue, 9 green, 10 red; 1 red, 9 green, 5 blue\nGame 37: 7 blue, 2 green, 14 red; 8 green, 8 red, 6 blue; 2 green, 12 red, 1 blue; 5 blue, 6 green, 5 red; 9 blue, 2 green, 1 red\nGame 38: 11 red, 2 green; 15 red, 1 blue, 7 green; 3 red, 3 green, 1 blue; 2 blue, 11 red, 9 green; 2 blue, 3 green; 5 green, 8 red, 1 blue\nGame 39: 4 blue, 13 red; 16 red, 3 blue, 2 green; 1 red, 1 blue\nGame 40: 7 blue, 2 green; 2 green, 2 blue; 1 red, 1 blue; 1 red, 4 green, 15 blue\nGame 41: 3 red, 5 blue, 5 green; 1 green, 4 blue, 1 red; 9 blue, 3 green, 1 red; 3 green, 9 blue, 1 red\nGame 42: 8 green, 2 blue, 4 red; 10 green, 2 red, 1 blue; 4 red, 10 green; 5 green, 3 blue, 3 red; 5 green, 3 blue, 5 red; 3 red, 10 green, 5 blue\nGame 43: 14 red, 8 green, 3 blue; 9 red, 2 blue, 9 green; 6 red, 4 green, 4 blue; 8 green; 12 blue, 10 red, 9 green\nGame 44: 6 green, 1 red; 3 red, 11 green, 2 blue; 2 green, 2 red, 3 blue; 1 red, 15 green, 2 blue\nGame 45: 12 green, 16 red, 6 blue; 15 blue, 3 red, 5 green; 2 blue, 10 green; 15 red, 15 blue; 6 green, 5 blue, 16 red; 16 green, 6 blue\nGame 46: 1 green, 3 red, 18 blue; 3 red, 8 green, 10 blue; 3 green, 12 blue; 2 red, 10 green, 17 blue; 12 green, 9 blue; 3 green, 6 blue\nGame 47: 10 green, 7 red, 6 blue; 12 green, 2 blue, 5 red; 7 green, 10 blue, 3 red; 11 green, 7 red; 5 blue, 8 green\nGame 48: 1 green, 2 red; 2 blue, 1 green, 6 red; 5 red, 1 blue; 2 blue, 1 green, 1 red; 9 red\nGame 49: 6 green, 4 blue, 1 red; 6 blue, 2 red, 1 green; 2 red, 5 blue, 4 green; 3 green, 6 blue, 1 red; 6 green, 12 blue, 1 red\nGame 50: 2 blue, 4 red, 2 green; 6 red, 12 green, 4 blue; 1 blue, 6 red, 13 green\nGame 51: 3 red, 1 blue; 2 red, 1 green, 2 blue; 3 blue, 2 red, 1 green; 1 red, 1 green, 1 blue\nGame 52: 1 green, 12 blue; 2 red, 9 blue; 1 green, 8 blue, 2 red; 8 blue, 1 red; 1 red, 13 blue; 2 red, 2 blue, 1 green\nGame 53: 7 blue, 16 green, 13 red; 9 red, 5 blue, 15 green; 4 green, 1 red; 15 green, 10 red, 2 blue; 11 green, 11 red, 2 blue\nGame 54: 5 red, 20 green, 11 blue; 13 red, 4 blue; 13 green, 15 blue; 1 red, 8 blue, 11 green; 5 green, 17 blue, 4 red\nGame 55: 5 red, 17 blue, 13 green; 17 red, 1 blue, 6 green; 3 red, 5 green; 8 green, 16 blue, 5 red\nGame 56: 6 green, 5 blue; 7 green, 1 red, 1 blue; 7 green, 2 blue; 3 blue, 8 green; 5 blue\nGame 57: 1 blue, 2 red, 3 green; 2 blue; 4 green, 2 red, 1 blue; 2 red, 1 green, 1 blue; 2 red, 2 blue, 1 green; 1 blue, 2 green\nGame 58: 6 red, 7 green, 18 blue; 9 blue, 4 green, 8 red; 12 green, 5 blue, 7 red\nGame 59: 2 red, 19 green, 1 blue; 10 green, 5 red; 2 blue, 10 green; 1 red, 3 blue; 14 green, 4 red\nGame 60: 12 blue, 2 red, 11 green; 6 red, 1 blue, 11 green; 6 red, 11 blue, 7 green; 5 green, 4 red, 7 blue; 2 red, 14 green\nGame 61: 7 red, 4 blue, 1 green; 11 blue, 8 red, 3 green; 10 blue, 7 red, 2 green; 2 green, 12 blue, 10 red\nGame 62: 3 blue, 19 green, 1 red; 3 red, 7 blue, 14 green; 10 green, 1 blue\nGame 63: 11 green, 1 blue, 15 red; 11 green, 16 red; 11 green, 8 blue, 12 red\nGame 64: 8 red, 2 green, 3 blue; 1 green, 9 red, 7 blue; 11 red, 3 blue; 2 blue, 3 green, 9 red; 3 blue, 6 red\nGame 65: 1 red, 4 blue; 4 blue, 6 red; 4 blue, 11 red; 2 green, 2 blue, 4 red; 1 blue, 9 red; 5 green, 7 red\nGame 66: 8 blue, 11 green; 7 red, 6 green; 6 red, 7 blue, 9 green; 12 blue, 2 red, 6 green\nGame 67: 4 green, 6 blue, 2 red; 4 blue, 2 red, 2 green; 4 green, 2 blue; 2 green, 4 blue, 2 red; 4 red, 4 green, 2 blue; 2 red, 7 green\nGame 68: 1 red, 5 blue; 5 blue, 16 green, 2 red; 1 red, 12 green, 4 blue; 7 blue, 9 red, 6 green\nGame 69: 6 blue, 6 green; 3 blue, 9 red; 3 green, 13 red, 6 blue\nGame 70: 1 green, 5 red; 1 blue, 1 green, 15 red; 5 blue, 5 red; 10 red, 7 blue; 9 red, 7 blue; 4 red, 1 green, 3 blue\nGame 71: 6 green, 11 blue, 6 red; 11 blue, 3 red, 4 green; 6 red, 10 blue\nGame 72: 5 green, 3 blue, 6 red; 4 blue, 2 red; 3 red, 4 green, 1 blue; 18 blue, 4 green; 3 red, 1 blue, 1 green; 4 blue, 4 green, 1 red\nGame 73: 8 green, 4 red, 13 blue; 2 green, 11 blue, 4 red; 2 blue, 12 red, 4 green; 2 blue, 1 red, 2 green; 11 blue, 8 red, 11 green\nGame 74: 4 red, 8 blue, 3 green; 7 red, 7 blue, 7 green; 7 red, 2 blue, 1 green\nGame 75: 1 blue, 1 green, 2 red; 6 red, 1 blue; 15 red, 13 blue; 19 red, 4 green, 4 blue; 12 blue, 3 red, 2 green; 12 red, 3 green, 1 blue\nGame 76: 1 blue, 3 red, 12 green; 13 green, 1 red, 1 blue; 6 blue, 3 green, 2 red; 1 green, 1 blue\nGame 77: 4 blue; 1 red, 1 green, 5 blue; 2 blue; 4 blue, 2 red, 3 green; 1 green, 5 blue; 1 red, 1 green, 6 blue\nGame 78: 2 red, 4 green, 1 blue; 4 green, 1 blue, 6 red; 7 green, 1 blue\nGame 79: 3 red, 14 blue, 1 green; 1 blue, 5 red; 4 green, 3 blue, 5 red; 7 red, 1 blue, 3 green; 7 blue, 4 green\nGame 80: 12 red, 1 green, 11 blue; 2 green, 5 blue, 13 red; 15 red, 15 blue, 1 green; 1 red, 1 green, 14 blue\nGame 81: 3 green, 2 red, 6 blue; 4 green, 11 blue; 4 green, 9 blue, 4 red; 10 blue, 2 red, 4 green\nGame 82: 15 blue, 7 green; 4 green, 15 blue, 7 red; 4 green, 9 blue, 5 red; 4 green, 6 blue, 1 red\nGame 83: 16 green, 10 red, 9 blue; 14 green, 3 blue, 7 red; 11 red, 7 blue; 10 blue, 15 red; 3 red, 4 blue, 10 green; 15 red, 3 blue\nGame 84: 3 red, 14 blue; 1 red, 3 blue; 2 red, 4 green, 6 blue; 1 green, 11 blue, 2 red\nGame 85: 15 green, 2 blue, 11 red; 4 red, 7 blue, 6 green; 3 blue, 14 green; 10 green, 10 blue, 7 red; 17 red, 3 green, 15 blue\nGame 86: 8 red, 1 green, 14 blue; 6 red, 12 green, 9 blue; 13 blue, 9 green, 6 red\nGame 87: 4 red, 3 blue; 4 blue, 4 green, 4 red; 1 green, 6 blue, 4 red; 2 green, 4 red, 3 blue; 4 blue, 4 green, 2 red; 1 green, 7 blue\nGame 88: 6 blue, 4 red, 6 green; 1 red, 9 blue, 13 green; 3 red, 1 blue, 15 green; 3 red, 7 blue, 15 green; 1 green, 1 blue, 3 red; 4 green, 4 blue, 2 red\nGame 89: 16 green, 9 blue, 1 red; 3 blue, 6 green, 5 red; 5 blue, 1 green\nGame 90: 17 red, 1 blue; 5 red; 2 red, 1 blue, 1 green; 13 red; 11 red, 1 blue, 1 green\nGame 91: 4 red, 1 blue; 4 green, 7 red; 13 green, 9 blue; 5 green, 9 blue; 12 red, 6 green, 6 blue\nGame 92: 4 red, 1 blue; 2 red, 15 blue; 2 blue, 1 green, 8 red; 1 green, 6 blue, 8 red; 12 blue, 1 green, 8 red; 8 blue, 1 red\nGame 93: 8 red, 9 green, 3 blue; 2 green, 1 red, 2 blue; 7 red, 5 blue\nGame 94: 1 green, 2 blue, 10 red; 7 red, 3 blue; 1 blue, 6 red, 4 green\nGame 95: 1 red, 7 blue, 2 green; 3 red, 14 blue, 2 green; 1 red; 1 red, 14 blue, 1 green; 4 blue, 10 red, 2 green; 9 blue, 7 red\nGame 96: 1 green, 10 red, 1 blue; 4 red, 1 green, 2 blue; 3 blue, 8 red\nGame 97: 4 red, 3 green; 1 blue, 2 green; 4 green, 4 red; 1 red, 1 blue; 1 green, 3 red; 1 green\nGame 98: 7 green, 4 blue, 1 red; 2 red, 5 blue; 4 blue, 3 red, 7 green\nGame 99: 7 blue, 13 green; 3 green, 5 red, 12 blue; 2 blue, 14 green, 8 red; 4 red, 6 blue, 2 green; 5 red, 9 green, 13 blue; 8 red, 8 blue, 5 green\nGame 100: 8 green, 7 blue, 1 red; 10 blue, 2 green, 5 red; 12 blue, 1 green, 1 red; 9 green, 9 blue, 2 red; 1 blue, 5 red, 3 green";
        Console.WriteLine(MultiplyAndSumMinimalAmountCubesEachColorInAllGames(input));
    }

    static int MultiplyAndSumMinimalAmountCubesEachColorInAllGames(string input)
    {
        int sum = 0;
        var games = ParseInputToGames(input);
        foreach (var game in games)
        {
            var minimalRedCubes = 0;
            var minimalGreenCubes = 0;
            var minimalBlueCubes = 0;
            var sets = ParseGameToSets(game);
            foreach (var set in sets)
            {
                var parsedSet = ParseSetToCubes(set);
                foreach (var keyValue in parsedSet)
                {
                    switch (keyValue.Value)
                    {
                        case "red":
                            if (keyValue.Key > minimalRedCubes)
                                minimalRedCubes = keyValue.Key;
                            break;
                        case "green":
                            if (keyValue.Key > minimalGreenCubes)
                                minimalGreenCubes = keyValue.Key;
                            break;
                        case "blue":
                            if (keyValue.Key > minimalBlueCubes)
                                minimalBlueCubes = keyValue.Key;
                            break;
                    }
                }
            }
            var multiplication = minimalBlueCubes * minimalGreenCubes * minimalRedCubes;
            sum += multiplication;
        }
        return sum;
    }

    static int CountAndAddPossibleGames(string input)
    {
        var games = ParseInputToGames(input);
        var gameCounter = 1;
        var sum = 0;
        foreach (var game in games)
        {
            bool needAdd = true;
            var sets = ParseGameToSets(game);
            foreach (var set in sets)
            {
                if (!isSetPossible(set))
                {
                    needAdd = false;
                }
            }
            if (needAdd)
            {
                sum += gameCounter;
            }
            gameCounter++;
        }
        return sum;
    }

    private static bool isSetPossible(string set)
    {
        var cubes = ParseSetToCubes(set);
        foreach (var item in cubes)
        {
            switch (item.Value)
            {
                case "red":
                    if (item.Key > redCubes)
                        return false;
                    break;
                case "green":
                    if (item.Key > greenCubes)
                        return false;
                    break;
                case "blue":
                    if (item.Key > blueCubes)
                        return false;
                    break;
            }
        }
        return true;
    }

    static List<string> ParseInputToGames(string input)
    {
        List<string> parsedStrings = new List<string>();
        string[] lines = input.Split('\n');
        foreach (string line in lines)
        {
            parsedStrings.Add(line.Trim());
        }
        return parsedStrings;
    }

    static List<string> ParseGameToSets(string game)
    {
        List<string> parsedStrings = new List<string>();
        string[] gameAndSets = game.Split(':');

        string[] sets = gameAndSets[1].Split(";");
        foreach (string set in sets)
        {
            parsedStrings.Add(set.Trim());
        }
        return parsedStrings;
    }

    static List<KeyValuePair<int, string>> ParseSetToCubes(string set)
    {
        List<KeyValuePair<int, string>> dictionary = new List<KeyValuePair<int, string>>();

        List<string> parsedStrings = new List<string>();
        string[] lines = set.Split(',');
        foreach (string line in lines)
        {
            var trimmed = line.Trim();
            var cubes = trimmed.Split(' ');
            int key = int.Parse(cubes[0]);
            string value = cubes[1];
            var keyValuePair = new KeyValuePair<int, string>(key, value);
            dictionary.Add(keyValuePair);
        }
        return dictionary;
    }
}
