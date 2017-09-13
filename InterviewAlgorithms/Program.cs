using System;
using System.Collections.Generic;

namespace InterviewAlgorithms
{
  public static class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
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
      display("Problem 1 NetFlix");
      List<string> list1 = new List<string>
      {
        "Vivek 1",
        "Vivek 2",
        "Ajit 3",
        "Krishna 4",
        "Keshav 6",
        "Keshav 7"
      };

      var duplicates = new Dictionary<string, string>();
      foreach (string item in list1)
      {
        var tmpName = GetName(item);
        var tmpNumber = GetNumber(item);
        if (duplicates.ContainsKey(tmpName))
        {
          duplicates[tmpName] += $",{tmpNumber}";
        }
        else
        {
          duplicates[tmpName] = tmpNumber;
        }
      }

      foreach (KeyValuePair<string, string> kvp in duplicates)
      {
        if (duplicates[kvp.Key].Contains(","))
        {
          display($"{kvp.Key} {duplicates[kvp.Key]}");
        }
      }

      display("-----------------");
      display("Problem 2 NetFlix");
      /*
       Implement a class Sorter with 2 functions: AddValue & GetValues. GetValues in sorted order. Can assume any data type.
       * */
      Sorter collection1 = new Sorter();
      collection1.AddValue("a string");
      collection1.AddValue(3);
      collection1.AddValue(DateTime.Now);
      display(collection1.GetValues<string>(0).ToString());
      display(collection1.GetValues<DateTime>(2).ToString());
      display("-----------------");
      display("Problem 3 NetFlix");
      /*
       Consider a game of cards where there are n number of players sat around a table playing and a single dealer that is controlling the game. The game can played with a variable number of decks of cards.

       If you were to consider writing a simulator for the game using object oriented principles, outline the classes that would be present in the design and how the would relate to each other
       * */


      display("press any key to exit:");
      Console.ReadKey();
    }

    public static string GetNumber(string item)
    {
      return item.Substring(item.IndexOf(' ') + 1);
    }

    public static string GetName(string item)
    {
      return item.Substring(0, item.IndexOf(' '));
    }
  }
}