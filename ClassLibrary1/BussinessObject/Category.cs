﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary1.BussinessObject
{
    public partial class Category
    {
        public Category()
        {
            FlowerBouquets = new HashSet<FlowerBouquet>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public virtual ICollection<FlowerBouquet> FlowerBouquets { get; set; }
    }
}
