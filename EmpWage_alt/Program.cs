﻿using System;

// UC 6

namespace EmpWage
{
    class Program
    {
        public const int full_time = 1;
        public const int part_time = 2;
        public const int wage_per_hr = 20;
        public const int working_days = 20;
        public const int max_working_hrs = 100;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            int full_day_hr = 0;
            int wage_per_day = 0;
            int monthly_wage = 0;
            int total_working_hrs = 0;
            int present_days = 0;

            while (total_working_hrs <= max_working_hrs && present_days <= working_days)
            {
                Random check = new Random();
                int status = check.Next(0, 3);

                switch (status)
                {
                    case full_time:
                        full_day_hr = 8;
                        present_days++;
                        break;
                    case part_time:
                        full_day_hr = 4;
                        present_days++;
                        break;
                    default:
                        full_day_hr = 0;
                        break;
                }
                total_working_hrs += full_day_hr;
                wage_per_day = (wage_per_hr * full_day_hr);
                monthly_wage += wage_per_day;
                Console.WriteLine("Daily wage = " + wage_per_day);
            }
            Console.WriteLine("Total hours worked = " + total_working_hrs);
            Console.WriteLine("Total days present = " + present_days);
            Console.WriteLine("Monthly wage = " + monthly_wage);
        }
    }
}