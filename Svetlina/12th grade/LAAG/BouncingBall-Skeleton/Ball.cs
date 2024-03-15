namespace BouncingBall
{
    public class Ball
    {
        private const int VERTICAL_NORMAL = 360;
        private const int HORIZONTAL_NORMAL = 360;

        private double speed;
        private double posX;
        private double posY;
        private double speedX;
        private double speedY;

        public Ball(double angle = 100, double speed = 5)
        {
            this.speed = speed;
            this.Angle = angle;
            this.Diameter = 50;
            this.posX = 100;
            this.posY = 100;

            this.CalculateSpeed();
        }

        public double Angle { get; set; }

        public int Diameter { get; }

        public double PositionX => this.posX;

        public double PositionY => this.posY;

        public void ChangeSpeed(double value)
        {
            this.speed = value;
        }

        public void DecreaseSpeed(double value)
        {
            this.speed -= value;
        }

        public bool HasSpeed()
        {
            return this.speed > 0;
        }

        public void CalculateSpeed()
        {
            double radians = this.Angle * (Math.PI / 180);
            this.speedX = this.speed * Math.Sin(radians);
            this.speedY = -this.speed * Math.Cos(radians);
        }

        public void MoveBall()
        {
            this.posX += this.speedX;
            this.posY += this.speedY;
        }

        public void CheckCollisionX(int width)
        {
            if (this.posX < 0 || this.posX + this.Diameter > width)
            {
                this.Angle = HORIZONTAL_NORMAL - this.Angle;
            }
        }

        public void CheckCollisionY(int height)
        {
            if (this.posY < 0 || this.posY + this.Diameter > height)
            {
                this.Angle = VERTICAL_NORMAL - this.Angle;
            }
        }
    }
}