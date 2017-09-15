using System;
using System.Collections.Generic;
using System.Media;
using System.Security.Policy;

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
      Card carte = new Card();
      CardHand hand = new CardHand();
      Player computerPlayer = new Player();
      Player dealer = new Player();
      Game firstGame = new Game();
      display("-----------------");
      display("Problem 4 Google1");
      /*
          1. Write an iterator class for finding the inorder successor in a Binary Tree
       */
      display("-----------------");
      display("Problem 5 Google2");
      /*
          2. Some testing questions
            Given a MxN matrix return the count of islands
              0 0 1 1 0 1
              0 0 1 1 1 0
              1 1 0 0 0 0
        Ex: 3 islands in the above matrix (an island has all 1s in the neighboring nodes, not diagonally)
       */
      display("-----------------");
      display("Problem 6 Google3");
      /*
       3. Chrome is implementing remote desktop feature where a user can log into another maching through an app installed from Chrome and do remote desktop operations. Test plan for this feature. Had to cover everything - app, RDP (media negotiation), sender side, receiver side etc
       * */
      display("-----------------");
      display("Problem 7 Google4");
      /*
       4. Given a sorted list of non-overlapping intervals, insert a new interval at the right location if it does not overlap. If it does, return the merged interval.
       [3,10] [5,20] [6,40]
       If [4,25] --> return [3,10] [5,25] [6,40]
       If [1,2] --> return [1,2] [3,10] [5,20] [6,40]
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

  internal class Game
  {
    public int NumberOfPlayer { get; set; }
    public int numberOfDecksOfCards { get; set; }
    public Game()
    {
      NumberOfPlayer = 1;
      numberOfDecksOfCards = 1;
    }
  }

  internal class Player
  {
  }

  internal class CardHand 
  {
    public List<Card> ListOfCards { get; set; }
    public CardHand()
    {
      ListOfCards = new List<Card>();
    }

    public void AddCard(){}
    public void RemoveCard() { }
  }

  internal class Card
  {
  }
}