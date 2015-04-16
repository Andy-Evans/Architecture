using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string ForeName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MarketingPreferences { get; set; }
        public bool ContactByEmail { get; set; }
        public string EmailAddress { get; set; }
        public string HomeNo { get; set; }
        public string MobileNo { get; set; }
    }

    public class CustomerName
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
    }

    public class CustomerMarketingPreferences
    {
        public int MarketingPreferences { get; set; }
        public bool ContactByEmail { get; set; }
        public string EmailAddress { get; set; }
    }

    public class MarketingInfo
    {
        public int MarketingPreferences { get; set; }
        public bool ContactByEmail { get; set; }
        public string HomeNo { get; set; }
        public string MobileNo { get; set; }
    }
}
