using System.Text;

namespace Computer_Store
{
    public class Laptop : Product, ILaptop
    {
        private List<IHardware> hardwareParts;
        public IReadOnlyCollection<IHardware> HardwareParts { get => hardwareParts.AsReadOnly(); }

        public decimal Price { get; set; }
        public double OverallPerformance { get; set; }
        public Laptop(int id, string model, decimal price, int overallPerformance)
            : base(id, model, price, overallPerformance)
        {
            hardwareParts = new List<IHardware>();

            OverallPerformance = overallPerformance;
            Price = price;
        }

        public void AddHardware(IHardware hardwarePart)
        {
            IHardware hardware = FindHardware(hardwarePart.Id);

            if (hardware != null)
            {
                throw new ArgumentException($"Hardware part with Id {hardwarePart.Id} is already added.");
            }

            OverallPerformance += hardwarePart.OverallPerformance;
            Price += hardwarePart.Price;

            hardwareParts.Add(hardwarePart);
        }

        public IHardware FindHardware(int Id)
        {
            foreach (var part in hardwareParts)
            {
                if (part.Id == Id)
                {
                    return part;
                }
            }

            return null;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append($"Model: {Model} with: Overall Performance: {OverallPerformance}. Price: {Price} (Id: {Id})\n");
            res.Append($" Hardware ({hardwareParts.Count}):\n");

            for (int i = 0; i < hardwareParts.Count; i++)
            {
                IHardware part = hardwareParts[i];

                res.Append("  " + part);

                if (i < hardwareParts.Count)
                {
                    res.Append("\n");
                }
            }

            res.Append("\n");
            return res.ToString();
        }
    }
}