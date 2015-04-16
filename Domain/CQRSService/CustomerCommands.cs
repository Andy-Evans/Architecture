namespace CQRSService
{
    public interface Message
    {
    }

    public class Command : Message
    {
    }

    public class AddCustomer : Command
    {
        private readonly Customer _customer;

        public AddCustomer(Customer customer)
        {
            _customer = customer;
        }
    }

    public class UpdateCustomerName : Command
    {
        private readonly CustomerName _customerName;

        public UpdateCustomerName(CustomerName customerName)
        {
            _customerName = customerName;
        }
    }

    public class UpdateCustomerMarketingPreferences : Command
    {
        private readonly CustomerMarketingPreferences _customerMarketingPreferences;

        public UpdateCustomerMarketingPreferences(CustomerMarketingPreferences customerMarketingPreferences)
        {
            _customerMarketingPreferences = customerMarketingPreferences;
        }
    }

    public class DeleteCustomer : Command
    {
        private readonly int _id;

        public DeleteCustomer(int id)
        {
            _id = id;
        }
    }
}
