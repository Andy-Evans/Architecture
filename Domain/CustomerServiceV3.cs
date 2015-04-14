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
        List<Customer> GetAllCustomers();
        List<CustomerV2> GetCustomersWhoAreContactableByEmail();
    }

    public class RetrieveCustomerService : IRetrieveCustomerService
    {
        public List<Customer> GetAllCustomers()
        {
            // Fetch all customers
            return new List<Customer>();
        }

        public List<CustomerV2> GetCustomersWhoAreContactableByEmail()
        {
            // Fetch all customers where ContactbyEmailIsSet
            return new List<CustomerV2>();
        }

    }

    public interface ICustomerServiceV3
    {
        void AddCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }

    public class CustomerServiceV3 : ICustomerServiceV3
    {
        public void AddCustomer(Customer customer)
        {
            //Repo call to add customer
        }

        public Customer UpdateCustomer(Customer customer)
        {
            //Repo perform update
            return new Customer();
        }

        public void DeleteCustomer(int id)
        {
            //Repo perform delete
        }
    }

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

    public class MarketingInfoV3
    {
        public int MarketingPreferences { get; set; }
        public bool ContactByEmail { get; set; }
        public string HomeNo { get; set; }
        public string MobileNo { get; set; }
    }
}
