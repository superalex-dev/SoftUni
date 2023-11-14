﻿using System.ComponentModel;

namespace CarRentalSystem.Services.Cars.Models
{
    public class CarServiceModel
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        [DisplayName("Price Per Day")]
        public decimal PricePerDay { get; set; }

        [DisplayName("Image")]
        public string ImageUrl { get; set; }

        [DisplayName("Rented")]
        public bool IsRented { get; set; }
    }
}
