using System.Drawing.Drawing2D;

namespace Clock
{
    public partial class ClockForm : Form
    {
        // Lengths of clock hands in percentages of the clock radius
        private const double HOURS_HAND_LENGTH = 0.40;
        private const double MINUTES_HAND_LENGTH = 0.60;
        private const double SECONDS_HAND_LENGTH = 0.50;

        private int hours;
        private int minutes;
        private int seconds;
		private int ms;

        private readonly Calculators calculators;

        public ClockForm()
        {
            this.InitializeComponent();

            this.calculators = new Calculators();
        }

		private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            this.hours = today.Hour;
            this.minutes = today.Minute;
            this.seconds = today.Second;
			this.ms = today.Millisecond;

			this.UpdateClock();
        }

		private void DrawLine(Graphics graphics, Point startPoint, Point endPoint, int penSize)
        {
            using Pen pen = new Pen(Color.Black, penSize);
            graphics.DrawLine(pen, startPoint, endPoint);
        }
		
		/// <summary>
		/// Draw the 3 hands in a new bitmap object and load it to pictureBox.
		/// </summary>
		private void UpdateClock()
		{
			this.Text = $"Clock {this.hours}:{this.minutes:00}:{this.seconds:00}";

			// Calculate clock hands angles
			double hoursPercentage = this.calculators.CalculateHoursInPercents(this.hours, this.minutes, this.seconds);
			double hoursAngle = this.calculators.CalculateAngle(hoursPercentage);

			double minutesPercentage = this.calculators.CalculateMinutesInPercents(this.minutes, this.seconds, this.ms);
			double minutesAngle = this.calculators.CalculateAngle(minutesPercentage);

			double secondsPercentage = this.calculators.CalculateSecondsInPercents(this.seconds, this.ms);
			double secondsAngle = this.calculators.CalculateAngle(secondsPercentage);

            this.textBoxClockData.Text = this.GenerateClockInfo(
                hoursPercentage,
                hoursAngle,
                minutesPercentage,
                minutesAngle,
                secondsPercentage,
                secondsAngle);
            
			Bitmap backgroundBitmap = Properties.Resources.clock;
			Graphics graphics = Graphics.FromImage(backgroundBitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;

			int radius = backgroundBitmap.Width / 2;
			Point centerPoint = new Point(radius + 1, radius - 4);

			// Draw the hours clock hand
			Point hoursEndPoint = this.calculators.TranslatePoint(centerPoint, hoursAngle, HOURS_HAND_LENGTH * radius);
			this.DrawLine(graphics, centerPoint, hoursEndPoint, 4);

			// Draw the minutes clock hand
			Point minutesEndPoint = this.calculators.TranslatePoint(
                centerPoint, minutesAngle, MINUTES_HAND_LENGTH * radius);
			this.DrawLine(graphics, centerPoint, minutesEndPoint, 2);

			// Draw the seconds clock hand
			Point secondsEndPoint = this.calculators.TranslatePoint(
                centerPoint, secondsAngle, SECONDS_HAND_LENGTH * radius);
			this.DrawLine(graphics, centerPoint, secondsEndPoint, 1);

			this.pictureBox.Image?.Dispose();
			this.pictureBox.Image = backgroundBitmap;
			this.pictureBox.Refresh();
			graphics.Dispose();
		}

        private string GenerateClockInfo(
            double hoursPercentage,
            double hoursAngle,
            double minutesPercentage,
            double minutesAngle,
            double secondsPercentage,
            double secondsAngle)
        {
            return $"Hours: {this.hours} = {hoursPercentage:f2}%" +
                $" --> angle = {hoursAngle:f2} rad" +
                $" = {hoursAngle * 180 / Math.PI:f2}°\r\n" +
                $"Minutes: {this.minutes:00} = {minutesPercentage:f2}%" +
                $" --> angle = {minutesAngle:f2} rad" +
                $" = {minutesAngle * 180 / Math.PI:f2}°\r\n" +
                $"Seconds: {this.seconds:00} = {secondsPercentage:f2}%" +
                $" --> angle = {secondsAngle:f2} rad" +
                $" = {secondsAngle * 180 / Math.PI:f2}°\r\n";
        }
    }
}