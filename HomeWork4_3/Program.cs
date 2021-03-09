using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_3
{
    class Program
    {
        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Error
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер месяца: ");
                string inputString = Console.ReadLine();

                int tempMonthNumber;
                if (Int32.TryParse(inputString, out tempMonthNumber) == true)
                {
                    Console.WriteLine(GetSeasonNameFromEnum(GetSeasonFromMonth(tempMonthNumber)));
                }
            }
        }

        static Season GetSeasonFromMonth(int monthNumber)
        {
            if ((monthNumber > 0 && monthNumber < 3) || monthNumber == 12)
            {
                return Season.Winter;
            }
            else if (monthNumber > 2 && monthNumber < 6)
            {
                return Season.Spring;
            }
            else if (monthNumber > 5 && monthNumber < 9)
            {
                return Season.Summer;
            }
            else if (monthNumber > 8 && monthNumber < 12)
            {
                return Season.Autumn;
            }
            else
            {
                return Season.Error;
            }
        }

        static String GetSeasonNameFromEnum(Season season)
        {
            switch (season)
            {
                case Season.Winter:
                    return "Зима";

                case Season.Spring:
                    return "Весна";

                case Season.Summer:
                    return "Лето";

                case Season.Autumn:
                    return "Осень";

                default:
                    return "Ошибка, введите число от 1 до 12";
            }
        }
    }
}
