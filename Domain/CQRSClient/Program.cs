using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace CQRSClient
{
    class Program
    {
        private static MessageBus bus;

        static void Main(string[] args)
        {
            bus = new MessageBus();

            var commands = new CustomerCommandHandlers(/*inject repo here*/);
            bus.RegisterHandler<AddCustomer>(commands.Handle);
            bus.RegisterHandler<UpdateCustomerName>(commands.Handle);
            bus.RegisterHandler<UpdateCustomerMarketingPreferences>(commands.Handle);
            bus.RegisterHandler<DeleteCustomer>(commands.Handle);

            AddCustomer();

            UpdateName();

            UpdateMarketingPreferences();

            DeleteCustomer();
        }

        private static void AddCustomer()
        {
            var command = new AddCustomer(new Customer());
            bus.Send(command);
        }

        private static void UpdateName()
        {
            var command = new UpdateCustomerName(new CustomerName());
            bus.Send(command);
        }

        private static void UpdateMarketingPreferences()
        {
            var command = new UpdateCustomerMarketingPreferences(new CustomerMarketingPreferences());
            bus.Send(command);
        }

        private static void DeleteCustomer()
        {
            var command = new DeleteCustomer(1);
            bus.Send(command);
        }
    }
}
