namespace SecondTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int d = 10;
            int r = 2;
            int m = 16;
            int d1 = 10;
            int r1 = 30;
            int m1 = 20;
            Console.WriteLine(TillPaycheck(d1, r1, m1) ? 
                "Yes, you will have enough coffee till your next paycheck" : 
                "No, you won't have enough coffee till your next paycheck");
        }

        private static bool TillPaycheck(int d, int r, int m)
        {
            int totalNeeded = d * r;
            int totalPossible = d * m;
            return totalNeeded <= totalPossible;
        }
    }
}