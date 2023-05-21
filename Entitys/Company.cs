using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Company
    {
        public string CompanyId { get; set; }
        public string CorporateName { get; set; }
        public string CNPJ { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public double Note { get; set; }

        public Company() { }
    }
}
