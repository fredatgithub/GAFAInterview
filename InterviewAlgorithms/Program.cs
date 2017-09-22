using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewAlgorithms
{
  public static class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      Action<string> displayWord = Console.Write;
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
       If [4,25] --> return [3,10] [4,25] [6,40]
       If [1,2] --> return [1,2] [3,10] [5,20] [6,40]
       * */
      Interval interval1 = new Interval(3, 10);
      Interval interval2 = new Interval(5, 20);
      Interval interval3 = new Interval(6, 40);
      ListOfInterval listOfIntervals = new ListOfInterval();
      listOfIntervals.Add(interval1);
      listOfIntervals.Add(interval2);
      listOfIntervals.Add(interval3);
      display($"{listOfIntervals.Insert(new Interval(4, 25))}");
      display($"{listOfIntervals.Insert(new Interval(1, 2))}");
      display($"{listOfIntervals.Insert(new Interval(7, 50))}");

      display("-----------------");
      display("Problem 8 Google5");
      /*
       5. Test plan for formatting feature in Google doc (online)
       */
      display("-----------------");
      display("Problem 9 Google6");
      /*
       6. Given a sentence reverse the order of words
       I am Vivek
       Vivek am I
       */
      const string sentence = "I am Vivek";
      string[] splitSentence = sentence.Split(' ');
      for (int i = splitSentence.Length - 1; i >= 0; i--)
      {
        displayWord($"{splitSentence[i]} ");
      }

      display(string.Empty);
      display("-----------------");
      display("Problem 10 Google7");
      /*
       7. Assume Google is implementing push to update OS on Android phones. Design a test plan to test this.
       */

      display("-----------------");
      display("Problem 11 Google8");
      /*
       8. Write code to find the deepest node in a binary tree (depth first traversal only)
       */

      display("-----------------");
      display("Problem 12 Google9");
      /*
       9. Last interviewer
       Find the longest substring in a string with only 2 varying characters
       aaabbbcccdddddd ==> cccddddd
       */
      const string sentence129 = "aaabbbcccdddddd";

      display("-----------------");
      display("Problem 13 Google10");
      /*
       10. In a BST with integer values, given a float value return the node with the closest value
       */

      display("-----------------");
      display("Problem 14 LinkedIn1");
      /*
       1. 
        * Return the sum of all integers from a random String. Continuous Integers must be considered as one number.
        * If the input String does not have any Integers, return 0.
        * You may ignore decimals, float, and other non-integer numbers
        * @param str : Input String
       */
      const string inputString = "12s312g3123h345d45a65z67 687s909x745";
      display($"The sum of all numbers is {ReturnSumOfAllInt(inputString)}");

      display("-----------------");
      display("Problem 15 LinkedIn2");
      /*
       * Given the following inputs, we expect the corresponding output:
        * "1a2b3c" => 6 (1+2+3)
        * "123ab!45c" => 168 (123+45)
        * "abcdef" => 0 (no Integers in String)
        * "0123.4" => 127 (0123+4)
        * "dFD$#23+++12@#T1234;/.,10" => 1279 (23+12+1234+10)
       */
      const string line1 = "1a2b3c";
      const string line2 = "123ab!45c";
      const string line3 = "abcdef";
      const string line4 = "0123.4";
      const string line5 = "dFD$#23+++12@#T1234;/.,10";
      display($"{ReturnSumOfAllInt(line1)}");
      display($"{ReturnSumOfAllInt(line2)}");
      display($"{ReturnSumOfAllInt(line3)}");
      display($"{ReturnSumOfAllInt(line4)}");
      display($"{ReturnSumOfAllInt(line5)}");

      display("-----------------");
      display("Problem 16 Apple1");
      /*
       1. Given a string of words print the # of occurances of each word
       */
      const string words = "A long long time ago in a galaxy far far away";
      string[] wordList = words.Split(' ');
      Dictionary<string, int> dico = new Dictionary<string, int>();
      foreach (string word in wordList)
      {
        if (dico.ContainsKey(word))
        {
          dico[word]++;
        }
        else
        {
          dico.Add(word, 1);
        }
      }

      display("In the sentence:");
      display(words);
      foreach (KeyValuePair<string, int> kvp in dico)
      {
        display($"The word {kvp.Key} is used {kvp.Value} time{Plural(kvp.Value)}");
      }

      display("-----------------");
      display("Problem 17 Apple2");
      /*
       2. Write a parser for validating if an XML is wellformed or not
       */
      string oneXml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>";
      display($"The validation of the XML is {IsXmlValidated(oneXml)} because it has a correct header");

      oneXml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><Quotes>\r\n  <Quote>\r\n    <Author>Jean-Paul Sartre</Author>\r\n    <Language>French</Language>\r\n    <QuoteValue>Dans la vie on ne fait pas ce que l\'on veut mais on est responsable de ce que l\'on est</QuoteValue>\r\n</Quote>";
      display($"The validation of the XML is {IsXmlValidated(oneXml)} because it is missing the last tag");

      oneXml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><Quotes>\r\n  <Quote>\r\n    <Author>Jean-Paul Sartre</Author>\r\n    <Language>French</Language>\r\n    <QuoteValue>Dans la vie on ne fait pas ce que l\'on veut mais on est responsable de ce que l\'on est</QuoteValue>\r\n</Quote></Quotes>";
      display($"The validation of the XML is {IsXmlValidated(oneXml)} but it has an even number of tag");
      display("press any key to exit:");
      Console.ReadKey();
    }

    private static bool IsXmlValidated(string oneXml)
    {
      bool result = true;
      List<string> dom = new List<string>();
      Dictionary<string, char> caractereXml = new Dictionary<string, char> {{"<", '<'}};
      if (!oneXml.StartsWith(@"<?xml version=""1.0"" encoding=""utf-8"" ?>"))
      {
        return false;
      }

      bool startTag = false;
      string openingTagName = string.Empty;

      for (int i = 0; i < oneXml.Length; i++)
      {
        string currentChar = oneXml[i].ToString();
        if (currentChar == "<")
        {
          startTag = true;
          openingTagName = string.Empty;
          continue;
        }

        if (startTag && currentChar != ">")
        {
          openingTagName += currentChar;
          continue;
        }

        if (currentChar == ">")
        {
          startTag = false;
          dom.Add(openingTagName);
          openingTagName = string.Empty;
        }
      }

      // remove first entry which is the definition xml file tag
      if (dom.Count > 1)
      {
        dom.RemoveAt(0);
      }
      
      // Does DOM has an even number of nodes ? if so, the xml is incorrect
      if (dom.Count % 2 != 0 && dom.Count > 1) 
      {
        return false;
      }

      //Parsing the list of tags DOM
      // TODO

      return result;
    }

    private static string Plural(int number)
    {
      return number > 1 ? "s" : string.Empty;
    }

    private static int ReturnSumOfAllInt(string sentence)
    {
      int result = 0;
      List<int> allNumbers = new List<int>();
      string tmpNumber = string.Empty;
      foreach (char t in sentence)
      {
        //int val = (int)Char.GetNumericValue('8');
        if ((int)char.GetNumericValue(t) >= 0 && (int)char.GetNumericValue(t) <= 9)
        {
          tmpNumber += (int)char.GetNumericValue(t);
        }
        else
        {
          if (!char.IsNumber(t))
          {
            if (tmpNumber != string.Empty)
            {
              allNumbers.Add(int.Parse(tmpNumber));
              tmpNumber = string.Empty;
            }        
          }
        }
      }

      if (tmpNumber != string.Empty)
      {
        allNumbers.Add(int.Parse(tmpNumber));
        tmpNumber = string.Empty;
      }

      int total = allNumbers.Sum();
      return allNumbers.Sum();
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

  internal class ListOfInterval
  {
    public List<Interval> Intervals { get; set; }

    public ListOfInterval()
    {
      Intervals = new List<Interval>();
      Intervals.Sort();
    }

    public void Add(Interval interval)
    {
      Intervals.Add(interval);
    }

    public string Insert(Interval interval)
    {
      string result = string.Empty;
      // TODO add code
      string tmpResult = Intervals.ToString();
      int intMin = 0;
      int intMax = 0;
      for (int i = 0; i < Intervals.Count; i++)
      {
        if (interval.Min < Intervals[i].Min)
        {
          intMin = Intervals[i].Min;
        }

        if (interval.Max < Intervals[i].Max)
        {
          intMax = Intervals[i].Max;
        }
      }

      Interval tmpInterval = new Interval(intMin, intMax);
      // TODO add all cases

      return result;
    }
  }

  internal class Interval
  {
    public int Min { get; set; }
    public int Max { get; set; }
    public Interval(int min, int max)
    {
      Min = min;
      Max = max;
    }
  }

  internal class Game
  {
    public int NumberOfPlayer { get; set; }
    public int NumberOfDecksOfCards { get; set; }
    public Game()
    {
      NumberOfPlayer = 1;
      NumberOfDecksOfCards = 1;
    }
  }

  internal class Player { }

  internal class CardHand
  {
    public List<Card> ListOfCards { get; set; }
    public CardHand()
    {
      ListOfCards = new List<Card>();
    }

    public void AddCard() { }
    public void RemoveCard() { }
  }

  internal class Card { }
}