﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double answer = minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {

            int answer = number1 - number2;
            if(answer > 0)
			{
                return number2;
			}
			else 
			{
                return number1;
			}

        }

        public long Multiply(long factor1, long factor2)
        {
            long answer = factor1 * factor2;
            return answer;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if(nameOfPerson != "")
			{
                return $"Hello, {nameOfPerson}!";
			}
			else
			{
                return "Hello!";
			}
             
        }

  //      public string GetGreeting(string nameOfPerson, string expectedGreeting)
		//{
  //          string newGreeting = nameOfPerson + expectedGreeting;
  //          return newGreeting;
		//}

        public string GetHey()
        {
            string hey = "HEY!";
            return hey;
        }
    }
}
