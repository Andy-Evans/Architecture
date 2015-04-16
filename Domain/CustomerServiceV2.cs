using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICustomerServiceV2
    {
        void AddCustomer(CustomerV2 customer);
        void UpdateCustomer(CustomerV2 customer);
        void DeleteCustomer(int id);
        List<CustomerV2> GetAllCustomers();
        void AddCustomerMarketingInfo(int custId, MarketingInfoV2 marketingInfo);
        string GetPrefferedContactDetails(int CustId);
    }

    public class CustomerServiceV2 : ICustomerServiceV2
    {
        public void AddCustomer(CustomerV2 customer)
        {
            //Repo call to add customer
        }

        public void UpdateCustomer(CustomerV2 customer)
        {
            //Repo perform update
        }

        public void DeleteCustomer(int id)
        {
            //Repo perform delete
        }

        public List<CustomerV2> GetAllCustomers()
        {
            // Fetch all customers
            return new List<CustomerV2>();
        }

        public void AddCustomerMarketingInfo(int custId, MarketingInfoV2 marketingInfo)
        {
            //Repo add marketing info to customer
        }

        public string GetPrefferedContactDetails(int CustId)
        {
            return string.Empty;
        }

        public List<CustomerV2> GetCustomersWhoAreContactableByEmail()
        {
            // Fetch all customers where ContactbyEmailIsSet
            return new List<CustomerV2>();
        }    
    }

    public class MarketingInfoV2
    {
        public int MarketingPreferences { get; set; }
        public bool ContactByEmail { get; set; }
        public string HomeNo { get; set; }
        public string MobileNo { get; set; }
    }

    public class CustomerV2
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
}
