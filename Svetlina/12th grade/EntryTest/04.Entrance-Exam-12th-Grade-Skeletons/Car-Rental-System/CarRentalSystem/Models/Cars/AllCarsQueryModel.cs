﻿using CarRentalSystem.Services.Cars.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem.Models.Cars
{
    public class AllCarsQueryModel
    {
        public const int CarsPerPage = 3;

        public string Category { get; init; }

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; }

        public CarSorting Sorting { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalCarsCount { get; set; }

        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<CarServiceModel> Cars { get; set; } = new List<CarServiceModel>();
    }
}
