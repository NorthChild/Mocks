using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindData.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomersList();

        public Customer GetCustomerById(string id);
        public void CreateCustomer(Customer c);
        public void SaveCustomerChanges();
        public void RemoveCustomer(Customer c);


    }
}
