﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class VehicleData
    {
        public virtual void PrintVehicle(Vehicle v)
        {
            Console.WriteLine(v.DescribeVehicle());
        }
    }
}
