﻿namespace CQRSService
{
    public class CustomerCommandHandlers
    {
        public CustomerCommandHandlers(/*Inject repo*/)
        {
            
        }
        public void Handle(AddCustomer message)
        {
            //Repo call to add customer
        }

        public void Handle(UpdateCustomerName message)
        {
            //Repo call to update customer name
        }

        public void Handle(UpdateCustomerMarketingPreferences message)
        {
            //Repo call to update customer marketing preferences
        }

        public void Handle(DeleteCustomer message)
        {
            //Repo call to delete customer
        }
    }
}
