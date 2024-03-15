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
            return ((seconds + ms / 1000) / 60) * 100;
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
            return ((minutes * 60 + seconds + ms / 1000) / 3600) * 100;
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
            return ((hours % 12 * 3600 + minutes * 60 + seconds) / (12 * 3600) * 100);
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
            double degrees = percentage / 100 * 360;
            double radians = (90 - degrees) * Math.PI / 180;

            if (radians < 0)
            {
                radians += 2 * Math.PI;
            }

            return radians;
        }

        /// <summary>
        /// Given an initial point {x, y}, and angle (in radians) and length,
        /// translate the point to a new location, staying at distance length
        /// from the initial point in direction, given by the input angle.
        /// </summary>
        public Point TranslatePoint(Point point, double angle, double length)
        {
            double newX = point.X + length * Math.Cos(angle);
            double newY = point.Y - length * Math.Sin(angle);
            return new Point((int)newX, (int)newY);
        }
    }
}