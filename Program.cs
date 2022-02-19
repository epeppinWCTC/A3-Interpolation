using System;

namespace A3_Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
                var date = DateTime.Now;
                var dateFormatted = date.ToString("MMMM dd, yyyy");
                //1.January 22, 2019
                Console.WriteLine($"1.{dateFormatted,40}");

                //2.2019.01.22
                Console.WriteLine($"2.{date:yyyy}.{date:MM}.{date:dd}");

                //3.Day 22 of January, 2019
                Console.WriteLine($"3.Day {date:dd} of {date:MMMM}, {date:yyyy}");

                //4.Year: 2019, Month: 01, Day: 22
                Console.WriteLine($"4.Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}");

                //5.            Tuesday (10 spaces)
                Console.WriteLine($"5.{date, 10:dddd}");

                //6.     11:01 PM             Tuesday (10 spaces between)
                Console.WriteLine($"6.{date, 10:t}{date, 10:dddd}");

                //7.h:11, m:01, s:27
                Console.WriteLine($"7.h:{date:hh}, m:{date:mm}, s:{date:ss}");

                //8.2019.01.22.11.01.27
                Console.WriteLine($"8.{date:yyyy}.{date:MM}.{date:dd}.{date:hh}.{date:mm}.{date:ss}");
                    
                Console.WriteLine("------------------------------------------");
                var pi = Math.PI;
                //1. Output as currency
                Console.WriteLine($"1.{pi:c2}");

                //2. Output as right-aligned (10 spaces), number with 3 decimal places
                Console.WriteLine($"2.{pi, 10:n3}"); 
            

            }
        
           
        
        }
    }