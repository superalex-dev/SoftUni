namespace Clock
{
    public class Calculators
    {
        /// <summary>
        /// Given a time in format {seconds.ms}, calculate the seconds
        /// as percentages from the whole clock. Return a value in the range [0...100].
        /// Examples:
        ///   00.000 -->  0%
        ///   15.000 --> 25%
        ///   30.000 --> 50%
        ///   45.000 --> 75%
        ///   59.000 --> 99%
        /// </summary>
        public double CalculateSecondsInPercents(double seconds, double ms)
        {
            double milisecondsAsSeconds = ms / 1000;
            double percent = (seconds + milisecondsAsSeconds) / 100;
            return percent / 60;
        }

        /// <summary>
        /// Given a time in format {minutes:seconds.ms}, calculate the minutes
        /// as percentages from the whole clock. Return a value in the range [0...100].
        /// Examples:
        ///   00:00.000 -->  0%
        ///   15:00.000 --> 25%
        ///   30:00.000 --> 50%
        ///   45:00.000 --> 75%
        ///   59:59.000 --> 99%
        /// </summary>
        public double CalculateMinutesInPercents(double minutes, double seconds,
            double ms)
        {
            double secondsInMinute = 60;
            double millisecondsInMinute = 60000;

            // Calculate total seconds including milliseconds
            double totalSeconds = minutes * secondsInMinute + seconds + (ms / 1000);

            // Calculate percentage of total seconds in a minute
            double percentOfSeconds = totalSeconds / secondsInMinute * 100;

            // Calculate percentage of milliseconds in a minute
            double percentOfMilliseconds = (ms / millisecondsInMinute) * 100;

            // Combine both percentages
            double totalPercentage = percentOfSeconds + percentOfMilliseconds;

            // Adjust the percentage considering the total minutes on a clock
            return totalPercentage / 60;
        }

        /// <summary>
        /// Given a time in format {hours:minutes:seconds}, calculate the hours
        /// as percentages from the whole clock. Return a value in the range [0...100].
        /// Examples:
        ///   00:00:00 -->  0%
        ///   03:00:00 --> 25%
        ///   06:00:00 --> 50%
        ///   09:00:00 --> 75%
        ///   11:59:59 --> 99%
        /// </summary>
        public double CalculateHoursInPercents(double hours, double minutes, double seconds)
        {
            double minutesInHour = 60;
            double secondsInHour = 3600;

            // Convert hours to 12-hour format if needed
            if (hours > 12)
                hours -= 12;

            // Calculate total seconds
            double totalSeconds = hours * secondsInHour + minutes * minutesInHour + seconds;

            // Calculate percentage of total seconds in an hour
            double percentOfSeconds = totalSeconds / secondsInHour * 100;

            // Adjust the percentage considering the total hours on a clock
            return percentOfSeconds / 12;
        }

        /// <summary>
        /// Given a value in percentages in the range [0...1], calculate
        /// the value as angle in radians, following the clock semantics.
        /// Examples:
        ///    0% == 12:00 h --> PI
        ///   25% == 03:00 h --> 0
        ///   50% == 06:00 h --> 3*PI/2
        ///   75% == 09:00 h --> 2*PI
        ///   98% == 11:55 h --> PI + PI/12
        /// </summary>
        public double CalculateAngle(double percentage)
        {
            double percent = percentage / 100;

            // Convert percentage to degrees
            double degrees = percent * 360;

            // Fix counter-clockwise rotation and ensure positive angle
            degrees = 90 - degrees;
            if (degrees < 0)
                degrees += 360;

            // Convert degrees to radians and return
            return degrees * Math.PI / 180;
        }

        /// <summary>
        /// Given an initial point {x, y}, and angle (in radians) and length,
        /// translate the point to a new location, staying at distance length
        /// from the initial point in direction, given by the input angle.
        /// </summary>
        public Point TranslatePoint(Point point, double angle, double length)
        {
            // Calculate new X coordinate
            double newX = point.X + length * Math.Cos(angle);

            // Calculate new Y coordinate
            double newY = point.Y - length * Math.Sin(angle); // Negative because Y increases downwards in typical coordinate systems

            // Return new point
            return new Point((int)newX, (int)newY);
        }
    }
}