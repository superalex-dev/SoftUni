using System;
using System.Collections.Generic;

namespace Parking.Models
{
    public partial class ParkingInfo
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
