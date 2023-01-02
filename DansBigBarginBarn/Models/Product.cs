﻿using System.ComponentModel.DataAnnotations;

namespace DansBigBarginBarn.Models
{
    public class Product
    {
       public int Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(140)]
        public string? Descritption { get; set; }

        [StringLength(250)]
        public string? Photopath { get; set; }

        [StringLength(40)]
        public int Quantity { get; set; }
    }
}