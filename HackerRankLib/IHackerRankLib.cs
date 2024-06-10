﻿using HackerRankLib.Model;

namespace HackerRankLib
{
    public interface IHackerRankLib
    {
        string BetterCompression(string str);

        IEnumerable<string> BuildCartesianProduct(int[] arrA);

        int[] CombineArrays(int[] arrA, int[] arrB, int numberOfItemsToGrabOnA, int numberOfItemsToGrabOnB);

        int[] CyclicRotation(int[] initialArr, int rotations);

        int FindSmallestPositiveInteger(int[] baseNumbers, int maxValue);

        int GetAverageTemperatureFromSensors(string[] dataPoints, string[] sensors);

        bool IsPalindrome(int number);

        int MaxBinaryGaps(int[] numbers);

        string MiniMaxSum(List<long> arr);

        Tuple<string, int> PossibleSuccessiveCombinations(Tree? node, int numberOfSuccessiveNumbers, bool allowDuplicates);

        string PossibleTwoSums(int target, int arrayLength);

        string StairCase(int number);
    }
}
