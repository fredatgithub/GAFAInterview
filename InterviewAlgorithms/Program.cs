using System;
using System.Collections.Generic;

namespace InterviewAlgorithms
{
  internal static class Program
  {
    private static void Main()
    {
      Action<string> Display = Console.WriteLine;
      /* Problems are in text file  */
      // problem 1 Netflix
      /*
       Netflix
        =======
        1. Given a file full of these strings:
        Vivek 1
        Vivek 2
        Ajit 3
        Krishna 4
        Keshav 6
        Keshav 7
        Print the duplicates and the IDs:
        Vivek: 1, 2
        Keshav: 6, 7
       * */

      List<string> list1 = new List<string>
      {
        "Vivek 1",
        "Vivek 2",
        "Ajit 3",
        "Krishna 4",
        "Keshav 6",
        "Keshav 7"
      };

      var duplicate = new Dictionary<string, string>();
      foreach (string item in list1)
      {
        var tmpName = GetName(item);
        var tmpNumber = GetNumber(item);

      }

      Display("press any key to exit:");
      Console.ReadKey();
    }

    private static string GetNumber(string item)
    {
      string result = string.Empty;
      //"Vivek 1"
      result = item.Substring(item.IndexOf(' ') + 1);
      return result;
    }

    private static string GetName(string item)
    {
      string result = string.Empty;

      return result;
    }
  }
}