namespace MorningChallenges
{
  static class Day3
  {

    public static int doubleInteger(int num)
    {
      return num * 2;

    }
    public static bool isNumberEven(int num)
    {
      return num % 2 == 0;
    }
    public static bool isNumberEven(float num)
    {
      return num % 2 == 0;
    }
    public static bool isNumberEven(decimal num)
    {
      return num % 2 == 0;
    }



    public static string getFileExtension(string str)
    {
      // str will be a string, but it may not have a file extension.
      // return the file extension (with no period) if it has one, otherwise "invalid"
      int lastIndex = str.LastIndexOf('.');
      // if(lastIndex == -1 || lastIndex == str.Length - 1){
      //   return "invalid";
      // }
      // return str.Substring(+1);
      return lastIndex == -1 || lastIndex == str.Length - 1 ? "invalid" : str.Substring(+1);
    }
    public static string longestString(string str)
    {
      // Return the longest string in the array
      string longest = "";
      string[] words = str.Split(' ');
      for (int i = 0; i < words.Length; i++)
      {
        string word = words[i];
        if (word.Length > longest.Length)
        {
          longest = word;
        }
      }
      return longest;
    }


    public static int arraySum(int[] arr)
    {
      //given an array return the sum of all its values
      int total = 0;
      foreach (var num in arr)
      {
        total += num;
      }
      return total;
    }
    public static double arraySum(double[] arr)
    {
      //given an array return the sum of all its values
      double total = 0;
      foreach (var num in arr)
      {
        total += num;
      }
      return total;
    }
    public static decimal arraySum(decimal[] arr)
    {
      //given an array return the sum of all its values
      decimal total = 0;
      foreach (var num in arr)
      {
        total += num;
      }
      return total;
    }
  }

}