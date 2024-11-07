using System.Collections.Generic;

namespace lab2.kruchinina.nom6
{
    public class LuckyNumberFinder
    {
     
        public int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        
        public bool IsLuckyNumber(int number)
        {
            if (number < 100000 || number > 999999)
                throw new ArgumentOutOfRangeException("Номер должен быть шестизначным.");

            int firstHalf = number / 1000; 
            int secondHalf = number % 1000; 
            return SumOfDigits(firstHalf) == SumOfDigits(secondHalf);
        }

        
        public List<int> GetAllLuckyNumbers()
        {
            List<int> luckyNumbers = new List<int>();

            for (int i = 100000; i <= 999999; i++)
            {
                if (IsLuckyNumber(i))
                {
                    luckyNumbers.Add(i);
                }
            }

            return luckyNumbers;
        }
    }
}