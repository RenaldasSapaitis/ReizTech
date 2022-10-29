// Each hour is 30 degrees, each minute is 6 degrees (360/ 12), (360/ 60)
// The hour hand moves in increments of 0.5 degrees for each minute that passes.
// I know good programming standard dictates NOT commenting every line, but I want to document the process of my logic and reasoning when figuring this problem out.
// There are multiple ways to solve this solution, I took the most basic which is probably the least efficient. There is no unit tests or error handling. 

using System;

namespace ConsoleApplication
{
    public class ClockAngle
    {
        // Function to get the angle in degrees of a user selected hour and minute.

        static double getAngle(double hours, double minutes)
        {
            if (hours > 24)
            Console.WriteLine("I don't know what clocks you're used to, but this one only goes up to 24hr. :) ");
            if (hours==12)
            hours=0;

            if (minutes == 60)
            {
                minutes = 0;
                hours+=1;
                if (hours > 12)
                hours = hours-12; // This is to account for a 24 hour clock
            }

            double hourAngle = (0.5 * ( hours * 60 + minutes)); // Turn hours into minutes, add minutes and then multiply by 0.5 as that is the degree angle for each minute that passes within the hour
            double minuteAngle = (6 * minutes); // 6 degree is the difference for each minute that passes
            double angle = Math.Abs(hourAngle - minuteAngle); // Actual angle is hours - minutes 
            if (angle> 360){
                return angle-360; // This should ensure that the acute angle is displayed
            }
            return angle;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter hours: ");
            double hoursInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            double minutesInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(getAngle(hoursInput, minutesInput));
            
        }
        
    }
}

