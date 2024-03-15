using System.Drawing.Drawing2D;

namespace BouncingBall
{
    public partial class BouncingBallForm : Form
    {
        private const int TIMER_SPEED = 10;

        private readonly Ball ball;

		public BouncingBallForm()
        {
            this.InitializeComponent();

            this.timerMoveBall.Enabled = true;
            this.timerMoveBall.Interval = TIMER_SPEED;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer 
                          | ControlStyles.AllPaintingInWmPaint
                          | ControlStyles.UserPaint, true);
            this.UpdateStyles();

            this.ball = new Ball();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			e.Graphics.Clear(this.BackColor);

            e.Graphics.FillEllipse(Brushes.Orange,
                (int)Math.Round(this.ball.PositionX),
                (int)Math.Round(this.ball.PositionY),
                this.ball.Diameter,
                this.ball.Diameter);

            e.Graphics.DrawEllipse(Pens.Black, 
                (int)Math.Round(this.ball.PositionX),
                (int)Math.Round(this.ball.PositionY),
                this.ball.Diameter,
                this.ball.Diameter);
        }

        private void TimerMoveBall_Tick(object sender, EventArgs e)
        {
            this.ball.CalculateSpeed();

            this.ball.MoveBall();

            this.ball.CheckCollisionX(this.pictureBox.Width);
            this.ball.CheckCollisionY(this.pictureBox.Height);

            this.ball.DecreaseSpeed((double)this.numericUpDownSlowdown.Value);
            if (!this.ball.HasSpeed())
            {
                this.timerMoveBall.Enabled = false;
            }

            this.Refresh();
        }

        private void NumericUpDownAngle_ValueChanged(object sender, EventArgs e)
        {
            this.ball.Angle = (double)this.numericUpDownAngle.Value;
        }

        private void NumericUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            this.ball.ChangeSpeed((double)this.numericUpDownSpeed.Value);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            this.ball.ChangeSpeed((double)this.numericUpDownSpeed.Value);
            this.timerMoveBall.Enabled = true;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            this.timerMoveBall.Enabled = false;
        }
    }
}
