using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICustomerServiceV1
    {
        void AddCustomer(CustomerServiceV1.Customer customer);
        CustomerServiceV1.Customer UpdateCustomer(CustomerServiceV1.Customer customer);
        void DeleteCustomer(int id);
        List<CustomerServiceV1.Customer> GetAllCustomers();
    }

    public class CustomerServiceV1 : ICustomerServiceV1
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

        public List<Customer> GetAllCustomers()
        {
            // Fetch all customers
            return new List<Customer>();
        }

        public class Customer
        {
            public int Id { get; set; }
            public string ForeName { get; set; }
            public string Surname { get; set; }
            public DateTime DateOfBirth { get; set; }
        }
    }

}
