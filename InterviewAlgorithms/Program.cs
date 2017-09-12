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

      foreach (string item in list1)
      {
        
      }

      Display("press any key to exit:");
      Console.ReadKey();
    }
  }
}