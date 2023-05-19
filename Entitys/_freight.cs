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

        public _freight()
        {
            IdFreight = IdGenerate();
        }

        private string IdGenerate()
        {
            string character = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string FreightId = "";
            Random random = new Random();

            while (FreightId.Length < 36)
            {
                char c = (char)character[random.Next(character.Length)];

                FreightId += c;

                if (FreightId.Length == 8)
                    FreightId += "-";
                else if (FreightId.Replace("-", "").Length == 12)
                    FreightId += "-";
                else if (FreightId.Replace("-", "").Length == 16)
                    FreightId += "-";
                else if (FreightId.Replace("-", "").Length == 20)
                    FreightId += "-";
            }

            return FreightId;
        }

        public override string ToString()
        {
            return $"{IdFreight}; " +
                $"{StartPoint}; {Destination}; {Distance}Km; {ValueKm.ToString("C2", new CultureInfo("pt-BR"))}; {TotalValue.ToString("C2", new CultureInfo("pt-BR"))};" +
                $"{Load}; {Trace}; {Obs}; {Driver}; {Client}; {Concluded}";
        }
    }
}
