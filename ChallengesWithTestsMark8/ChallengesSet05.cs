﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if(startNumber == 0)
			{
                return n;
			}
            int x = startNumber * n;
            int nextNum = 0;

            for (int i = startNumber + 1; i < x; i++)
			{
                if(i % n == 0)
				{
                    nextNum = i;
                    break;
				}
			}
                return nextNum;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
			{
                if(businesses[i].TotalRevenue == 0)
				{
                    businesses[i].Name = "CLOSED";
				}
			}
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //var numbersAscending = numbers.OrderBy(n => n).ToArray();
            //return numbersAscending == numbers;

            if(numbers == null || numbers.Length == 0)
			{
                return false;
			}
            for(int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] < numbers[i - 1])
				{
                    return false;
				}
			}
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
				{
                    sum += numbers[i];
				}
            }

            return sum;
            if(numbers == null)
			{
                return 0;
			}
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length == 0)
			{
                return "";
			}
            string sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim().Length > 0)
				{
                sentence += words[i].Trim() + " " ;
                }
			}
            if(sentence.Length == 0)
			{
                return "";
			}
            sentence = sentence.Trim() + ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
			{
                return new double[0];
			}
            var everyFourth = new List<double>();
            for(int i = 3; i < elements.Count; i+= 4)
			{
                everyFourth.Add(elements[i]);
			}

            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
