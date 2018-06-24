using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_StatisticalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number between 10 - 1000");
            int n = int.Parse(Console.ReadLine());
            List<int> Zero = RandomList(n);
            foreach (int number in Zero)
            {
                Console.Write($"{number}, ");
            }
            Console.WriteLine();

            int avg = Mean(Zero);
            Console.WriteLine($"The mean is {avg}");

            double med = Median(Zero);
            Console.WriteLine($"The median is {med}");

            int sd = StandardDeviation(Zero);
            Console.WriteLine($"The standard deviation is {sd}");

            double medAD = MedianAD(Zero);
            Console.WriteLine($"The median absolute deviation is {medAD}");

            double skew = Skewness(Zero);
            Console.WriteLine($"The skewness is {skew}");

            double kurt = Kurtosis(Zero);
            Console.WriteLine($"The kurtosis is {kurt}");
        }

        public static List<int> RandomList(int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                result.Add(new Random(i).Next(1000));
            }
            return result;
        }

        public static int Mean(List<int> intList)
        {
            return (int)intList.Average();
        }

        public static double Median(List<int> intList)
        {
            intList.Sort();
            if (intList.Count % 2 != 0)
                return (intList[intList.Count / 2 + 1]);

            else
            {
                double half1 = intList[intList.Count / 2];
                double half2 = intList[intList.Count / 2 + 1];
                return (half1 + half2) / 2;
            }
        }
        public static int StandardDeviation(List<int> intList)
        {
            List<int> numera = new List<int>();
            double median = Median(intList);
            double average = Mean(intList);

            foreach (int num in intList)
            {
                int temp = (int)(Math.Pow(num - average, 2));
                numera.Add(temp);
            }
            int total = numera.Sum();
            return (int)Math.Sqrt(total / intList.Count);
        }
        public static double MedianAD(List<int> intList)
        {
            intList.Sort();
            double median = Median(intList);
            List<int> absList = new List<int>();

            foreach (int number in intList)
            {
                absList.Add((int)Math.Abs(number - median));
            }
            return Median(absList);
        }
        public static double Skewness(List<int> intList)
        {
            return (3 * (Mean(intList) - Median(intList)) / StandardDeviation(intList));
        }
        public static double Kurtosis(List<int> intList)
        {
            List<double> numera = new List<double>();
            foreach (int num in intList)
            {
                numera.Add(Math.Pow((num - Mean(intList)), 4));
            }
            double total = numera.Sum();
            double lastNumerator = total / intList.Count;
            double denominator = Math.Pow(StandardDeviation(intList), 4);
            return lastNumerator / denominator;
        }
    }
}
