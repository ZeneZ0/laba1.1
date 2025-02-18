using System;

namespace Zad12
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Задача 1: Конвертация стоимости из копеек в рубли и копейки
            Console.WriteLine("Задача 1.1:");
            Console.WriteLine(Logic.ConvertKopecksToRubles(321));  // 3 рубля 21 копейка
            Console.WriteLine(Logic.ConvertKopecksToRubles(1500)); // 15 рублей 0 копеек
            Console.WriteLine(Logic.ConvertKopecksToRubles(100));  // 1 рубль 0 копеек
            Console.WriteLine(Logic.ConvertKopecksToRubles(50));    // 50 копеек
            Console.WriteLine(Logic.ConvertKopecksToRubles(5000)); // 50 рубле
        }
    }

    public class Logic
    {
        public static string ConvertKopecksToRubles(int kopecks)
        {
            if (kopecks == 0)
                return "0 рублей 0 копеек";

            int rubles = kopecks / 100;
            int remainingKopecks = kopecks % 100;

            string rublesText = rubles > 0 ? GetRublesText(rubles) : string.Empty;
            string kopecksText = remainingKopecks > 0 ? GetKopecksText(remainingKopecks) : string.Empty;

          
            string result = string.Empty;

            if (rubles > 0)
                result += $"{rubles} {rublesText}";

            if (remainingKopecks > 0)
            {
                if (!string.IsNullOrEmpty(result)) 
                    result += " ";
                result += $"{remainingKopecks} {kopecksText}";
            }

         
            if (string.IsNullOrEmpty(result))
                return "0 рублей 0 копеек";

            return result;
        }

        private static string GetRublesText(int rubles)
        {
            if (rubles % 10 == 1 && rubles % 100 != 11)
                return "рубль";
            if (rubles % 10 >= 2 && rubles % 10 <= 4 && (rubles % 100 < 10 || rubles % 100 >= 20))
                return "рубля";
            return "рублей";
        }

        private static string GetKopecksText(int kopecks)
        {
            if (kopecks % 10 == 1 && kopecks % 100 != 11)
                return "копейка";
            if (kopecks % 10 >= 2 && kopecks % 10 <= 4 && (kopecks % 100 < 10 || kopecks % 100 >= 20))
                return "копейки";
            return "копеек";
        }
    }
}