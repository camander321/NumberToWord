using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public static class NumberToWord
  {
    public static Dictionary<char, string> ones = new Dictionary<char, string>
    {
      {'0', "zero"}, {'1', "one"}, {'2', "two"}, {'3', "three"}, {'4', "four"},
      {'5', "five"}, {'6', "six"}, {'7', "seven"}, {'8', "eight"}, {'9', "nine"}
    };

    public static Dictionary<char, string> teens = new Dictionary<char, string>
    {
      {'0', "ten"}, {'1', "eleven"}, {'2', "twelve"}, {'3', "thirteen"}, {'4', "fourteen"},
      {'5', "fifteen"}, {'6', "sixteen"}, {'7', "seventeen"}, {'8', "eighteen"}, {'9', "ninteen"}
    };

    public static Dictionary<char, string> tens = new Dictionary<char, string>
    {
      {'2', "twenty"}, {'3', "thirty"}, {'4', "fourty"}, {'5', "fifty"},
      {'6', "sixty"}, {'7', "seventy"}, {'8', "eighty"}, {'9', "ninety"}
    };

    private static List<string> higherPlaceValues = new List<string>
    {
      "", "thousand", "million", "billion", "trillion", "Quadrillion", "Quintillion", "Sextillion", "Septillion	", "Octillion", "Nonillion", "Decillion", "Undecillion", "Duodecillion", "Tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septendecillion", "Octodecillion", "Novemdecillion", "Vigintillion"
    };

    public static char GetDigitFromRight(int digit, string number)
    {
      return number[number.Length-1-digit];
    }

    public static string ConvertLastDigit(string number)
    {
      if (number.Length < 1 || GetDigitFromRight(0, number) == '0')
      {
        return "";
      }
      return ones[GetDigitFromRight(0, number)];
    }

    public static string ConvertLast2Digits(string number)
    {
      if (number.Length < 2 || GetDigitFromRight(1, number) == '0')
      {
        return ConvertLastDigit(number);
      }
      else if (GetDigitFromRight(1, number) == '1')
      {
        return teens[GetDigitFromRight(0, number)];
      }
      else
      {
        string result = tens[GetDigitFromRight(1, number)];
        if(GetDigitFromRight(0, number) != '0')
        {
          result += '-' + ConvertLastDigit(number);
        }
        return result;
      }
    }

    public static string ConvertHundred(string number)
    {
      if (number.Length < 3 || GetDigitFromRight(2, number) == '0')
      {
        return ConvertLast2Digits(number);
      }
      else
      {
        string result = ones[GetDigitFromRight(2, number)] + " hundred";
        if(GetDigitFromRight(0, number) != '0' || GetDigitFromRight(1, number) != '0')
        {
          result += ' ' + ConvertLast2Digits(number);
        }
        return result;
      }
    }

    public static string Convert(string number)
    {
      string resultString = "";

      int start = number.Length;
      int end = number.Length;
      int placeValue = 0;
      while (start > 0)
      {
        end = start;
        start -= 3;
        if (start < 0)
        {
          start = 0;
        }

        string numberPart = number.Substring(start, end - start);
        if (resultString.Length > 0)
        {
          resultString = ' ' + resultString;
        }
        string resultPart = ConvertHundred(numberPart);
        if (placeValue > 0)
        {
          resultPart += ' ' + higherPlaceValues[placeValue];
        }

        resultString = resultPart + resultString;
        placeValue++;
      }

      return resultString;
    }
  }
}
