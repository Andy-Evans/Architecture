using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICustomerMarketingService
    {
        void AddCustomerMarketingInfo(int custId, MarketingInfoV3 marketingInfo);
        void GetPrefferedContactDetails(int custId);
    }

    public class CustomerMarketingService : ICustomerMarketingService
    {
        public void AddCustomerMarketingInfo(int custId, MarketingInfoV3 marketingInfo)
        {
            //Repo add marketing info to customer
        }

        public void GetPrefferedContactDetails(int custId)
        {

        }
    }

    public interface IRetrieveCustomerService
    {
        List<CustomerV3> GetAllCustomers();
        List<CustomerV3> GetCustomersWhoAreContactableByEmail();
    }

    public class RetrieveCustomerService : IRetrieveCustomerService
    {
        public List<CustomerV3> GetAllCustomers()
        {
            // Fetch all customers
            return new List<CustomerV3>();
        }

        public List<CustomerV3> GetCustomersWhoAreContactableByEmail()
        {
            // Fetch all customers where ContactbyEmailIsSet
            return new List<CustomerV3>();
        }

    }

    public interface ICustomerServiceV3
    {
        void AddCustomer(CustomerV3 customerV3);
        void UpdateCustomer(CustomerV3 customerV3);
        void DeleteCustomer(int id);
    }

    public class CustomerServiceV3 : ICustomerServiceV3
    {
        public void AddCustomer(CustomerV3 customerV3)
        {
            //Repo call to add customer
        }

        public void UpdateCustomer(CustomerV3 customerV3)
        {
            //Repo perform update
        }

        public void DeleteCustomer(int id)
        {
            //Repo perform delete
        }
    }

    public class CustomerV3
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

    public class MarketingInfoV3
    {
        public int MarketingPreferences { get; set; }
        public bool ContactByEmail { get; set; }
        public string HomeNo { get; set; }
        public string MobileNo { get; set; }
    }
}
