﻿using System;

namespace AlgorithmsTestProject
{
    public static class CombinationsTest
    {
        public static bool AreSetsTheSame(List<int> a, List<int> b)
        {
            if (a.Count != b.Count) return false;
            var asorted = a.OrderBy(x => x);
            var bsorted = b.OrderBy(x => x);
            return asorted.SequenceEqual(bsorted);
        }

        public static bool DoesOutputSetContains(List<List<int>> outputSet, List<int> member)
        {
            foreach (var output in outputSet)
            {
                if (AreSetsTheSame(output, member))
                {
                    return true;
                }
            }
            return false;
        }

        [Test]
        public static void TestGenerateCombinations()
        {
            var testInput = new[] { 1, 3, 5 };
            var output = GenerateCombinations(testInput);
            var expectedResults = new List<List<int>> {
                new List<int> { },
                new List<int> { 1 },
                new List<int> { 3 },
                new List<int> { 5 },
                new List<int> { 1, 3 },
                new List<int> { 1, 5 },
                new List<int> { 3, 5 },
                new List<int> { 1, 3, 5 },
            };

            foreach (var expectedResult in expectedResults)
            {
                Assert.IsTrue(DoesOutputSetContains(output, expectedResult));
            }

            Assert.AreEqual(8, output.Count);
        }

        [Test]
        public static void OutputResults()
        {
            int[] testInput = new[] { 1, 3, 5 };
            List<List<int>> combinations = GenerateCombinations(testInput);
            foreach (var combination in combinations)
            {
                Console.WriteLine("[" + string.Join(",", combination) + "]");
            }
        }

        public static List<List<int>> GenerateCombinations(int[] input)
        {
            throw new NotImplementedException();
        }
    }
}

