using System;

namespace MorningChallenges
{
  class Program
  {
    static void Main(string[] args)
    {
      // new Day2().Login();
      Console.WriteLine("Double Integer (2)? " + Day3.doubleInteger(2));
      Console.WriteLine("Number is even (1)? " + Day3.isNumberEven(1));
      Console.WriteLine("Number is even (2)? " + Day3.isNumberEven(2));
      Console.WriteLine("Get File extention(test.txt)? " + Day3.getFileExtension("test.txt"));
      Console.WriteLine("Get File extention(invalid)? " + Day3.getFileExtension("junk"));
      Console.WriteLine("Get File extention(nowWhat.)? " + Day3.getFileExtension("nowWhat."));
      Console.WriteLine("Longest String(hello world of bannanas)? " + Day3.longestString("hello world of bannanas"));
      Console.WriteLine("Array Sum([1,2,3,4])? " + Day3.arraySum(new int[] { 1, 2, 3, 4 }));


    }
  }
}
