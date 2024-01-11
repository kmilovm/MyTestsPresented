﻿using HackerRankLib;

HackerRankLibHelper.Initialize(new HackerRankLibrary());
var number = 123321;
Console.WriteLine(HackerRankLibHelper.IsPalindrome(number) ? $"{number} it is" : $"{number} no is not");
number = 6;
Console.WriteLine(HackerRankLibHelper.StairCase(number));
var array = new List<long>{ 256741038,623958417,467905213,714532089,938071625 };
Console.WriteLine(HackerRankLibHelper.MiniMaxSum(array));
const string strToCompress = "a24b2c56d4a2b2d3c6";
Console.WriteLine($"Original:{strToCompress} Compressed:{HackerRankLibHelper.BetterCompression(strToCompress)}"); //expected: a26b4c62d7
Console.ReadLine();