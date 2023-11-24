namespace Reserve_Seat_on_a_Train
{
    public class Program
    {
        private static bool reserve = false;
        private static readonly object lockObject = new object();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Reserve);
            Reserve();
        }

        static void Reserve()
        {
            lock (lockObject)
            {
                if (!reserve)
                {
                    Console.WriteLine("Reserved");
                    reserve = true;
                }
            }
        }
    }
}