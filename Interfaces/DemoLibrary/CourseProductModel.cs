﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (!HasOrderBeenCompleted) { 
            
            }
        }
    }
}
