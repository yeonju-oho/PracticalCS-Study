using System;

/// <summary>
/// 2.1 Distance Converter에 관한 소스코드이다.
/// </summary>
namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string readLine = Console.ReadLine();

            if (readLine.Equals("-tom"))
            {
                PrintFeetToMeter(1, 100);
            }
            else if (readLine.Equals("-tof"))
            {
                PrintMeeterToFeet(1, 100);
            }
            else
            {
                Console.WriteLine("일치하는 문자열이 없습니다!!");
            }

            Console.ReadKey();
        }

        public static void PrintFeetToMeter(int start, int stop)
        {
            for (int i = start; i <= stop; i++)
            {
                Console.WriteLine("{0} ft = {1:0.0000} m", i, FeetConverter.ToMeter(i));
            }
        }
        public static void PrintMeeterToFeet(int start, int stop)
        {
            for (int i = start; i <= stop; i++)
            {
                Console.WriteLine("{0} m = {1:0.0000} ft", i, FeetConverter.FromMeter(i));
            }
        }
    }
}
