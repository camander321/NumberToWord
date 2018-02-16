using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Models.Tests
{
  [TestClass]
  public class NumbersToWordsTest
  {
    [TestMethod]
    public void GetNumber_ReturnNumber()
    {
      NumberToWord n2w = new NumberToWord("1384");


      Assert.AreEqual("1384", n2w.GetNumber());
    }

    [TestMethod]
    public void ConvertLast2Digits_ReturnNumber()
    {
      NumberToWord n2w;

      n2w = new NumberToWord("0");
      Assert.AreEqual("", n2w.ConvertLast2Digits("0"));

      n2w = new NumberToWord("5");
      Assert.AreEqual("five", n2w.ConvertLast2Digits("5"));

      n2w = new NumberToWord("14");
      Assert.AreEqual("fourteen", n2w.ConvertLast2Digits("14"));

      n2w = new NumberToWord("1384");
      Assert.AreEqual("eighty-four", n2w.ConvertLast2Digits("1384"));
    }

    [TestMethod]
    public void ConvertHigherDigits_ReturnNumber()
    {
      NumberToWord n2w;

      n2w = new NumberToWord("0");

      Assert.AreEqual("one hundred twenty-three", n2w.ConvertHundred("123"));
      Assert.AreEqual("one hundred", n2w.ConvertHundred("100"));
      Assert.AreEqual("one hundred one", n2w.ConvertHundred("101"));
      Assert.AreEqual("one hundred ten", n2w.ConvertHundred("110"));
      Assert.AreEqual("one", n2w.ConvertHundred("1"));
      Assert.AreEqual("ten", n2w.ConvertHundred("10"));

    }

    [TestMethod]
    public void Convert_ReturnNumber()
    {
      NumberToWord n2w;

      n2w = new NumberToWord("0");

      Assert.AreEqual("one thousand one hundred twenty-three", n2w.Convert("1123"));
      Assert.AreEqual("twenty-one thousand one hundred", n2w.Convert("21100"));
      Assert.AreEqual("three hundred twenty-one thousand one hundred one", n2w.Convert("321101"));
      Assert.AreEqual("four million three hundred twenty-one thousand one hundred ten", n2w.Convert("4321110"));
      Assert.AreEqual("one", n2w.Convert("1"));
      Assert.AreEqual("ten", n2w.Convert("10"));

    }
  }
}
