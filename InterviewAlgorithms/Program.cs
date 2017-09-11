using System;
using System.Collections.Generic;

namespace InterviewAlgorithms
{
  class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      /*
       Problems in text file 
       * */

      Display("press any key to exit:");
      Console.ReadKey();
    }
  }
}