using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo = InterviewAlgorithms.Program;

namespace UnitTestProjectInterviewAlgo
{
  [TestClass]
  public class UnitTestPalindrome
  {
    [TestMethod]
    public void TestMethod_Char_MinValue()
    {
      const char source = char.MinValue;
      const string expected = "\0";
      Assert.AreEqual(source.ToString(), expected);
    }

    [TestMethod]
    public void TestMethod_Reverse_string()
    {
      const string source = "alla";
      string expected = new string(source.Reverse().ToArray());
      Assert.AreEqual(source, expected);
    }
  }
}