using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null || words.Contains(null))
			{
                return false;
			}
            bool result = false;
			if (ignoreCase)
			{
                var lowerWords = words.Select(x => x.ToLower());
                result = lowerWords.Contains(word.ToLower());

			}
			else
			{
                result = words.Contains(word);
			}
            return result;
        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrime = false;
            if(num >= 0)
			{
                if(num % 2 != 0 && num % 3 !=0)
				{
                    isPrime = true;
				}
			}
            if(num == 2 || num == 3)
			{
                isPrime = true;
			}

            if(num == 1)
			{
                return false;
			}
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uniqe;

            for (int i = 0; i < str.Length; i++)
            {
                uniqe = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
					{
                        uniqe = false;
					}

                }
                    if(uniqe == true)
					{
                        index = i;
					}
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }
			

    

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var NthElement = new List<double>();

            if(n<1 || elements == null)
			{
                return new double[0];
			}
            for(int i = 0; i<elements.Count; i++)
			{
                if(elements[i] % n == 0)
				{
                    NthElement.Add(elements[i]);
				}
			}
            return NthElement.ToArray();
        }
    }
}
