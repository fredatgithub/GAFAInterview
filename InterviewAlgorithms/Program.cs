using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

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
      display($"The validation of the XML is {IsXmlValidated(oneXml)}");

      display("-----------------");
      display("Problem 18 Amazon1");
      /*
       1. What is a priority queue? How will you implement it? Complexity of each implementation.
       */

      display("-----------------");
      display("Problem 19 Amazon2");
      /*
       2. Implement atoi (char to Int in C++)
       */
      string aNumber = "11";
      int number = AtoInt(aNumber);

      display("-----------------");
      display("Problem 20 Amazon3");
      /*
       3. Given an unsorted array of integers with each value occuring even number of times except for one of them which occurs odd number of times. Return the element which occurs odd number of times.
       Ex: 3 1 3 4 4 0 0 ==> return 1
       */

      int[] unsortedArrayOfInt = { 3, 1, 3, 4, 4, 0, 0 };
      int[] array203 = { 3, 1, 3, 4, 4, 0, 0, 9 };
      display($"The elements which have only 1 element are: {ExtractOnes(AddToDic(unsortedArrayOfInt))}");
      display($"The elements which have only 1 element are: {ExtractOnes(AddToDic(array203))}");

      display("-----------------");
      display("Problem 21 Amazon4");
      /*
       4. Question: Curly braces can be used in programming to provide scope-limit. Write a function to print all valid( properly opened and closed) combinations of n-pairs of curly braces.
          Example:
          input: 1 output: {}
          input: 2 output: {}{}, {{}}
          input: 3 output: {}{}{}, {}{{}}, {{}}{}, {{}{}}, {{{}}}
       */
      int number214 = 1;
      display($"All valid combinations of {number214}-pair of curly braces are: {AllCombo(number214)}");
      number214 = 2;
      display($"All valid combinations of {number214}-pairs of curly braces are: {AllCombo(number214)}");
      number214 = 3;
      display($"All valid combinations of {number214}-pairs of curly braces are: {AllCombo(number214)}");
      number214 = 4;
      display($"All valid combinations of {number214}-pairs of curly braces are: {AllCombo(number214)}");

      display("-----------------");
      display("Problem 22 Amazon5");
      /*
       5. Test a Coke vending machine
       */
      // TODO

      display("-----------------");
      display("Problem 23 Apple1");
      /*
       What frameworks I've built in the past?
       */

      display("-----------------");
      display("Problem 24 Apple2");
      /*
       Given a collection of tiles and collection of points, how will you find if a tile has any points in it?
       */

      display("-----------------");
      display("Problem 25 Apple3");
      /*
       Code up palindrome
       */
      var listOfPalindromes = new List<string> {
      "Ésope reste ici et se repose",
      "La mariée ira mal",
      "radar",
      "rotor",
      "été",
      "ici",
      "tôt",
      "Bob",
      "Natan",
       "Neven",
       "Ève",
       "Anna",
       "Otto",
       "Sées",
       "Noyon",
       "Callac",
       "Laval",
       "Senones",
        "Is not a palindrome",
        "caser vite ce palindrome ne mord ni lape cet ivre sac",

        "Mon nom",
        "Eh ça va la vache",
        "À l'émir, Asimov a vomi sa rime, là",
        "Engage le jeu que je le gagne",
        "Noël a trop par rapport à Léon",
        "À l'étape, épate-la",
        "La mère Gide digère mal",
        "Léon, émir cornu, d'un roc rime Noël",
        "Élu par cette crapule",
        "Un radar nu",
        "Éric notre valet alla te laver ton ciré",
        "Luc notre valet alla te laver ton cul",
        "Le ruban à Burel",
        "Été le bar arabe l'été",
        "Tâte l'État",
        "Un roc cornu",
        "Tu l'as trop écrasé, César, ce Port-Salut",
        "Oh, cela te perd répéta l'écho",
        "rue Verlaine gela le génial rêveur",
        "Et la marine va venir à Malte",
        "Elle dira hélas à la sale haridelle"
      };

      foreach (string palindrome in listOfPalindromes)
      {
        //display($"palindrome={palindrome}");
        //display($"Its reverse is={new string(palindrome.Reverse().ToArray()) }");
        //display($"The word or sentence: {palindrome} is{Negative(IsAPalindrome(palindrome))} a palindrome");
        display($"{Negative(IsAPalindrome(palindrome))} a palindrome: {palindrome}");
      }

      display("-----------------");
      display("Problem 26 Apple4");
      /*
       Given a huge JSON file, write a way to serialize paths
        Ex: { k1 : '1234',
        k2 :
        { k3 : '123',
        k4 : 'abc'
        }
        k3 : 'sddd',
        }
        output: k1 -> k2.k3 -> k2.k4, k3
       */

      display("-----------------");
      display("Problem 27 Apple5");
      /*
       Explain my approach to testing in the past. Dev hooks, api layer, abstraction etc
       */

      display("-----------------");
      display("Problem 28 Apple6");
      /*
       Write a class for implementing LRU cache. What methods will be there? How will you test it?
       */

      display("-----------------");
      display("Problem 29 Apple7");
      /*
       Given a collection of points, return the k closest points to a given point
       */

      display("-----------------");
      display("Problem 30 Apple8");
      /*
       How did I deal with an ambiguous situation
       */

      display("-----------------");
      display("Problem 31 Apple9");
      /*
       What is my approach to solving a big daunting problem
       */

      display("-----------------");
      display("Problem 32 Amazon1");
      /*
       Given a dictionary of words. There can be duplicates. Given a bag of letters. There can be duplicates. Print the length of the longest valid dictionary word that can be formed from the bag.
       */
      List<string> dicoOfWords = new List<string> { "lot", "of", "word", "words", "galaxy", "of" };
      string tmpPhrase = "Given a dictionary of words. There can be duplicates. Given a bag of letters. There can be duplicates. Print the length of the longest valid dictionary word that can be formed from the bag";
      foreach (string word in tmpPhrase.Split(' '))
      {
        dicoOfWords.Add(word.Trim('.'));
      }

      List<char> bagOfLetters = GetRandomChar();

      //List<char> bagOfLetters = new List<char>();
      //for (char a = 'a'; a <= 'z'; a++)
      //{
      //  bagOfLetters.Add(a);
      //}

      //// few duplicate
      //bagOfLetters.Add('e');
      //bagOfLetters.Add('i');
      //bagOfLetters.Add('a');
      //bagOfLetters.Add('o');
      //bagOfLetters.Add('u');
      Dictionary<string, int> dicoresult = new Dictionary<string, int>();
      foreach (string word in dicoOfWords)
      {
        if (LettersInWord(word, bagOfLetters))
        {
          if (!dicoresult.ContainsKey(word))
          {
            dicoresult.Add(word, word.Length);
          }
        }
      }

      display($"The longest word is {LongestWord(dicoresult)}");
      display("press any key to exit:");
      Console.ReadKey();
    }

    private static List<char> GetRandomChar()
    {
      List<char> result = new List<char>();
      int numberOfChar = GenerateRandomNumberUsingCrypto(1, 254);
      var allChar = "abcdefghijklmnopqrstuvwxyz";
      for (int i = 0; i < numberOfChar; i++)
      {
        result.Add(allChar[GenerateRandomNumberUsingCrypto(0, allChar.Length)]);
      }

      return result;
    }

    private static int GenerateRandomNumberUsingCrypto(int min, int max)
    {
      if (max >= 255)
      {
        return 0;
      }

      int result;
      var crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result <= min || result >= max);

      return result;
    }

    private static bool LettersInWord(string word, ICollection<char> bagOfLetters)
    {
      //return word.All(c => bagOfLetters.Contains(c));
      return word.All(bagOfLetters.Contains);
    }

    private static string LongestWord(Dictionary<string, int> dico)
    {
      string result = string.Empty;
      var maxValue = dico.Values.Max();
      var keys = dico.Where(kvp => kvp.Value == maxValue).Select(kvp => kvp.Key);
      result = keys.First();
      return result;
    }

    private static bool IsAPalindrome(string palindrome)
    {
      //string result = string.Empty;
      //for (int i = palindrome.Length - 1; i >= 0; i--)
      //{
      //  result += palindrome[i];
      //}
      //return string.Equals(RemoveAccent(palindrome), RemoveAccent(result), StringComparison.OrdinalIgnoreCase) ;

      return string.Equals(RemoveAccent(palindrome), RemoveAccent(new string(palindrome.Reverse().ToArray())), StringComparison.OrdinalIgnoreCase);
    }

    private static string RemoveAccent(string s)
    {
      string result = s;
      char[] Eaccents = { 'é', 'è', 'E', 'ê', 'È', 'É', 'ë' };
      foreach (char accent in Eaccents)
      {
        result = result.Replace(accent, 'e');
      }

      char[] Aaccents = { 'à', 'â', 'A', 'À' };
      foreach (char accent in Aaccents)
      {
        result = result.Replace(accent, 'a');
      }

      result = result.Replace("ç", "c");
      result = result.Replace(" ", "");
      result = result.Replace(",", "");
      result = result.Replace("'", "");
      result = result.Replace("!", "");
      result = result.Replace("-", "");
      return result;
    }

    private static string Negative(bool booleanValue)
    {
      return booleanValue ? string.Empty : " not";
    }

    private static string AllCombo(int number)
    {
      string result = string.Empty;
      if (number == 1) return "{}";
      if (number == 2) return "{}{}, {{}}";
      if (number == 3) return "{}{}{}, {}{{}}, {{}}{}, {{}{}}, {{{}}}";
      for (int i = 4; i <= number; i++)
      {
        result += "{}{}{}{}, {}{}{{}}, {{}}{}{}, {{}{}{}}, {{{{}}}}";
        // TODO code the rest
      }

      return result;
    }

    private static Dictionary<string, int> AddToDic(int[] myArray)
    {
      var dico = new Dictionary<string, int>();
      foreach (int nb in myArray)
      {
        if (dico.ContainsKey(nb.ToString()))
        {
          dico[nb.ToString()]++;
        }
        else
        {
          dico.Add(nb.ToString(), 1);
        }
      }

      return dico;
    }

    private static string ExtractOnes(Dictionary<string, int> dico)
    {
      string result = string.Empty;
      foreach (KeyValuePair<string, int> kvp in dico)
      {
        if (kvp.Value == 1)
        {
          result += $"{kvp.Key} ";
        }
      }

      return result;
    }

    private static int AtoInt(string aNumber)
    {
      return int.Parse(aNumber);
    }

    private static bool IsXmlValidated(string oneXml)
    {
      bool result = true;
      List<string> dom = new List<string>();
      string standardFirstXmlTag = @"<?xml version=""1.0"" encoding=""utf-8"" ?>";
      var caractereXml = new Dictionary<string, char> { { "<", '<' } };
      if (!oneXml.StartsWith(standardFirstXmlTag))
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
          dom.Add($"<{openingTagName}>");
          openingTagName = string.Empty;
        }
      }

      if (oneXml.StartsWith(standardFirstXmlTag) && dom.Count == 1)
      {
        return true;
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

      //Parsing the list of tags DOM staring with the first one and last one
      string startTag2 = dom[0];
      string lastTag = dom[dom.Count - 1];
      string tmpStartTagWithSlash = AddSlashToTag(startTag2);
      if (lastTag != tmpStartTagWithSlash)
      {
        return false; // starting XML tag is different from ending tag
      }

      //checking other tags within first and last
      Stack<string> domTag1 = new Stack<string>();
      for (int i = 1; i < dom.Count / 2; i++)
      {
        if (AddSlashToTag(dom[i]) == dom[dom.Count - i - 1])
        {
        }
        else if (AddSlashToTag(dom[i]) == dom[i + 1])
        {
          i++;
        }
        else
        {
          domTag1.Push(dom[i]);
        }
      }

      result = domTag1.Count < 1;
      return result;
    }

    private static string AddSlashToTag(string myString)
    {
      if (myString == string.Empty)
      {
        return "/";
      }

      return $"{myString.Substring(0, 1)}/{myString.Substring(1, myString.Length - 1)}";
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
    private List<Interval> Intervals { get; set; }

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