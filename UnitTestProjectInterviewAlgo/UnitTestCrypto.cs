using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectInterviewAlgo
{
  [TestClass]
  public class UnitTestCrypto
  {
    [TestMethod]
    public void TestMethod_GetRandomChar()
    {
      PrivateType privateTypeObject = new PrivateType(typeof(InterviewAlgorithms.Program));
      const string methodName = "GetRandomChar";
      object obj = privateTypeObject.InvokeStatic(methodName);
      Assert.IsTrue(((List<char>)obj).Count > 1);
    }

    [TestMethod]
    public void TestMethod_LettersInWord_are_true()
    {
      PrivateType privateTypeObject = new PrivateType(typeof(InterviewAlgorithms.Program));
      const string methodName = "LettersInWord";
      const string source1 = "galaxy";
      IEnumerable<char> source2 = new List<char> {'g', 'a', 'l', 'x', 'y'};
      const bool expected = true;
      object obj = privateTypeObject.InvokeStatic(methodName, source1, source2);
      Assert.AreEqual(expected, obj);
    }

    [TestMethod]
    public void TestMethod_LettersInWord_are_false()
    {
      PrivateType privateTypeObject = new PrivateType(typeof(InterviewAlgorithms.Program));
      const string methodName = "LettersInWord";
      const string source1 = "galaxy";
      IEnumerable<char> source2 = new List<char> {'a', 'l', 'x', 'y' };
      const bool expected = false;
      object obj = privateTypeObject.InvokeStatic(methodName, source1, source2);
      Assert.AreEqual(expected, obj);
    }
  }
}