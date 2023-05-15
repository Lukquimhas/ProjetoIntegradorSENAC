using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class _freight
    {
        public string IdFreight { get; set; }
        public string StartPoint { get; set; }
        public string Destination { get; set; }
        public double Distance { get; set; }
        public double ValueKm { get; set; }
        public double TotalValue { get; set; }
        public string Load { get; set; }
        public bool Trace { get; set; }
        public string Obs { get; set; }
        public string Driver { get; set; }
        public string Client { get; set; }
        public bool Concluded { get; set; }
        public DateTime CreateDate { get; set; }

        public _freight() { }

        public double GetTotalValue()
        {
            return this.Distance * this.ValueKm;
        }

        public override string ToString()
        {
            return $"{IdFreight}; " +
                $"{StartPoint}; {Destination}; {Distance}Km; {ValueKm.ToString("C2", new CultureInfo("pt-BR"))}; {TotalValue.ToString("C2", new CultureInfo("pt-BR"))};" +
                $"{Load}; {Trace}; {Obs}; {Driver}; {Client}; {Concluded}";
        }
    }
}
