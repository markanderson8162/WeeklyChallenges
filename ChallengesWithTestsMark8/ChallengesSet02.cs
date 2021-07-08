using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return true;

            //    if (alphabet.Contains(c))
            //    {
            //        return true;
            //    }
           
            //return false;
        }

		public bool CharacterIsNotALetter(char c)
		{
			string nonLetters = "0123456789`~!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?\u2222";
			return true;
		}

		public bool CountOfElementsIsEven(string[] vals)
        {
            int stringLength = vals.Length;
            if(stringLength % 2 == 0)
			{
                return true;
			}
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
			{
                return true;
			}
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null|| numbers.Count() == 0)
			{
                return 0;
			}
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
			{
                return 0;
			}
            return numbers.Sum();
            
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null || numbers.Count() == 0)
			{
                return 0;
			}
            return numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number < 0)
			{
                return 0;
			}
            return number / 2;
        }
    }
}
