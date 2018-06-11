using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    //Given two integers, an hour and a minute, write a function to calculate
    //the angle between the two hands on a clock representing that time.
    class ClockAngleApp
    {
        public const double MINUTES_PER_HOUR = 60;
        public const double DEGREES_PER_MINUTE = 360 / MINUTES_PER_HOUR;
        public const double DEGREES_PER_HOUR = 360 / 12;
        static void Main(string[] args)
        {
            int hour = 11;
            int min = 10;
            double resultAngle = ClockAngle(hour, min);
            Console.WriteLine($"The angle between hourhand and minute" +
                $" hand of {hour}+ {min} is: {resultAngle} degree ");
            Console.ReadKey();
        }
        public static double ClockAngle(int hour, int minutes)
        {
            double minuteAngle = minutes * DEGREES_PER_MINUTE;
            double hourAngle = hour * DEGREES_PER_HOUR +
                (minutes / MINUTES_PER_HOUR) * DEGREES_PER_HOUR;

            double diff = Math.Abs(hourAngle - minuteAngle);
            return diff > 180 ? 360 - diff : diff;
        
        }
    }
}
