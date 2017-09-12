using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo = InterviewAlgorithms.Program;

namespace UnitTestProjectInterviewAlgo
{
  [TestClass]
  public class UnitTestGetName
  {
    [TestMethod]
    public void TestMethod_Get_Name_1()
    {
      const string source = "Vivek 1";
      const string expected = "Vivek";
      string result = Algo.GetName(source);
      Assert.AreEqual(result, expected);
    }
  }
}