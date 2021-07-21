using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            ChallengesSet04 num = new ChallengesSet04();
            num.AddEvenSubtractOdd(numbers);


            
            Console.WriteLine(num);
        }
    }
}
