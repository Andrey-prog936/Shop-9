﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Product> Product { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
