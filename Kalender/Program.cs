using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalender
{
    class Program
    {
        static int day = 0,
                   year = 0;
        static int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static void Main(string[] args)
        {
            // Read input from user.
            readInput();

            // Fetch days based by current day and year.
            fetchDays();

            // Pause before closing the app.
            Console.ReadKey();
        }

        static void readInput()
        {
            // Get year
            Console.Write("Masukkan tahun     : ");
            year = int.Parse(Console.ReadLine());

            // Change day in February if the year is leap year.
            if (year % 4 == 0)
            {
                monthDays[1] = 29;
            }

            // Get day
            while (true)
            {
                Console.Write("Masukkan hari (1-7): ");
                day = int.Parse(Console.ReadLine()) - 1;

                if (day < 0 || day > 6)
                    Console.WriteLine("Input yang anda masukkan tidak tepat.");
                else
                    break;
            }
        }

        static void fetchDays()
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("\n\n\n[" + (i + 1) + "]\n");
                addSpaces();

                for (int j = 0; j < monthDays[i]; j++)
                {
                    int dayNum = j + 1;
                    string currentDay = dayNum.ToString();
                    Console.Write((dayNum < 10 ? "0" + currentDay : currentDay) + "  ");

                    if (day < 6)
                    {
                        day++;
                    }
                    else
                    {
                        day = 0;
                        Console.WriteLine("\n");
                    }
                }
            }
        }

        static void addSpaces()
        {
            if (day < 7) {
                for (int a = 0; a < day; a++)
                {
                    Console.Write("    ");
                }
            }
        }
    }
}
