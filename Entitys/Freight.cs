﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Freight
    {
        public string IdFreight { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double Distance { get; set; }
        public double ValueKm { get; set; }
        public double TotalValue { get; set; }
        public string Load { get; set; }
        public string Trace { get; set; }
        public string Obs { get; set; }
        public string Driver { get; set; }
        public string Client { get; set; }
        public string Concluded { get; set; }

        public Freight() { }
    }
}