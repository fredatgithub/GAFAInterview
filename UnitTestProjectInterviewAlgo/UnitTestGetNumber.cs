using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo = InterviewAlgorithms.Program;

namespace UnitTestProjectInterviewAlgo
{
  [TestClass]
  public class UnitTestGetNumber
  {
    [TestMethod]
    public void TestMethod_Get_Number_1()
    {
      const string source = "Vivek 1";
      const string expected = "1";
      string result = Algo.GetNumber(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_Get_Number_2_digit_number()
    {
      const string source = "Vivek 10";
      const string expected = "10";
      string result = Algo.GetNumber(source);
      Assert.AreEqual(result, expected);
    }
  }
}