using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            int largest = 0;
            if (first > second)
            {
                if (first > third)
                {
                    largest = first;
                }
            }

            if (second > first)
            {
                if (second > third)
                {
                    largest = second;
                }
            }

            if (third > first)
            {
                if (third > second)
                {
                    largest = third;
                }
            }

            Console.WriteLine($"Number {largest} is the largest");
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            int largest = (first > second && first > third) ? first : (second > first && second > third) ? second : largest = third;
            Console.WriteLine($"Number {largest} is the largest");
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            int largest = 0;
            if (first > second && first > third)
            {
                    largest = first;
            }

            if (second > first && second > third)
            {
                    largest = second;
            }

            if (third > first && third > second)
            {
                    largest = third;
            }

            Console.WriteLine($"Number {largest} is the largest");
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 18 && userAge < 21)
            {
                Console.WriteLine("You're old enough to drive.");
            }
            else if (userAge >= 21 && userAge < 65)
            {
                Console.WriteLine("Fancy an alcoholic beverage?");
            }
            else if (userAge >= 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else
            {
                Console.WriteLine("You are too young to drive, drink, or retire.");
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }

            if (countOfDailyDownloads >= 1 && countOfDailyDownloads < 100)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }

            if (countOfDailyDownloads >= 100 && countOfDailyDownloads < 1000)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }

            if (countOfDailyDownloads >= 1000 && countOfDailyDownloads < 10000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }

            if (countOfDailyDownloads >= 10000 && countOfDailyDownloads < 100000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }

            if (countOfDailyDownloads > 100000)
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }
        
        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The first day of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Tuesday || dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("The middle of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the work week.");
            }
            else
            {
                Console.WriteLine("The weekend.");
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week.");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("The middle of the work week.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("The middle of the work week.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("The middle of the work week.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("The weekend.");
                    break;                
            }
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            string type = null;
            if (arg is sbyte)
            {
                type = $"{arg} is sbyte.";
            }
            else if (arg is byte)
            {
                type = $"{arg} is byte.";
            }
            else if (arg is short)
            {
                type = $"{arg} is short.";
            }
            else if (arg is int)
            {
                type = $"{arg} is int.";
            }
            else if (arg is long)
            {
                type = $"{arg} is long.";
            }
            else if (arg is ushort)
            {
                type = $"{arg} is ushort.";
            }
            else if (arg is uint)
            {
                type = $"{arg} is uint.";
            }
            else if (arg is ulong)
            {
                type = $"{arg} is ulong.";
            }
            else
            {
                type = $"{arg} is not integer.";
            }

            return type;
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            string type = null;
            switch (arg)
            {
                case sbyte _:
                    type = $"{arg} is sbyte.";
                    break;
                case byte _:
                    type = $"{arg} is byte.";
                    break;
                case short _:
                    type = $"{arg} is short.";
                    break;
                case int _:
                    type = $"{arg} is int.";
                    break;
                case long _:
                    type = $"{arg} is long.";
                    break;
                case ushort _:
                    type = $"{arg} is ushort.";
                    break;
                case uint _:
                    type = $"{arg} is uint.";
                    break;
                case ulong _:
                    type = $"{arg} is ulong.";
                    break;
                default:
                    type = $"{arg} is not integer.";
                    break;
            }

            return type;
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg)
        {
            return arg switch
            {
                sbyte x => x + " is sbyte.",
                byte x => x + " is byte.",
                short x => x + " is short.",
                int x => x + " is int.",
                long x => x + " is long.",
                ushort x => x + " is ushort.",
                uint x => x + " is uint.",
                ulong x => x + " is ulong.",
                _ => arg + " is not integer."
            };
        }

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch (month)
            {
                case Month.January:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.February:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.March:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.April:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.May:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.June:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.July:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.August:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.September:
                    Console.WriteLine("It's autumn now.");
                    break;
                case Month.October:
                    Console.WriteLine("It's autumn now.");
                    break;
                case Month.November:
                    Console.WriteLine("It's autumn now.");
                    break;
                case Month.December:
                    Console.WriteLine("It's winter now.");
                    break;
                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            byte length = 0;
            if (number < 10 && number > -10)
            {
                length = 1;
            }
            else if (number < 100 && number > -100)
            {
                length = 2;
            }
            else if (number < 1000 && number > -1000)
            {
                length = 3;
            }
            else if (number < 10000 && number > - 10000)
            {
                length = 4;
            }
            else if (number < 100000 && number > -100000)
            {
                length = 5;
            }
            else if (number < 1000000 && number > -1000000)
            {
                length = 6;
            }
            else if (number < 10000000 && number > -10000000)
            {
                length = 7;
            }
            else if (number < 100000000 && number > -100000000)
            {
                length = 8;
            }
            else if (number < 1000000000 && number > -1000000000)
            {
                length = 9;
            }
            else
            {
                length = 10;
            }

            return length;
        }

        public static byte GetLengthWithSwitchExpression(int number)
        {
            return number switch
            {
                int n when n < 10 && n > -10 => 1,
                int n when n < 100 && n > -100 => 2,
                int n when n < 1000 && n > -1000 => 3,
                int n when n < 10000 && n > -10000 => 4,
                int n when n < 100000 && n > -100000 => 5,
                int n when n < 1000000 && n > -1000000 => 6,
                int n when n < 10000000 && n > -10000000 => 7,
                int n when n < 100000000 && n > -100000000 => 8,
                int n when n < 1000000000 && n > -1000000000 => 9,
                _ => 10
            };
        }

        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month == 1)
            {
                return Month.January;
            }
            else if (month == 2)
            {
                return Month.February;
            }
            else if (month == 3)
            {
                return Month.March;
            }
            else if (month == 4)
            {
                return Month.April;
            }
            else if (month == 5)
            {
                return Month.May;
            }
            else if (month == 6)
            {
                return Month.June;
            }
            else if (month == 7)
            {
                return Month.July;
            }
            else if (month == 8)
            {
                return Month.August;
            }
            else if (month == 9)
            {
                return Month.September;
            }
            else if (month == 10)
            {
                return Month.October;
            }
            else if (month == 11)
            {
                return Month.November;
            }
            else if (month == 12)
            {
                return Month.December;
            }
            else
            {
                return null;
            }
        }

        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case 1: return Month.January;
                case 2: return Month.February;
                case 3: return Month.March;
                case 4: return Month.April;
                case 5: return Month.May;
                case 6: return Month.June;
                case 7: return Month.July;
                case 8: return Month.August;
                case 9: return Month.September;
                case 10: return Month.October;
                case 11: return Month.November;
                case 12: return Month.December;
                default: return null;
            }
        }
        
        public static Month? GetMonthWithSwitchExpression(int month)
        {
            return month switch
            {
                1 => Month.January,
                2 => Month.February,
                3 => Month.March,
                4 => Month.April,
                5 => Month.May,
                6 => Month.June,
                7 => Month.July,
                8 => Month.August,
                9 => Month.September,
                10 => Month.October,
                11 => Month.November,
                12 => Month.December,
                _ => null
            };
        }
    }
}
