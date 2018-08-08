﻿using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Restaurant Name")]
        public string Name { get; set; }
        public CuisineType cuisine { get; set; }
    }
}
