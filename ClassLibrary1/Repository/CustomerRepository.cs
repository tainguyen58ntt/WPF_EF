
using ClassLibrary1.BussinessObject;
using ClassLibrary1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public class CustomerRepository : ICustomerRepository


    {
      

        public Customer CheckLogin(string name, string password)
        {
            return CustomerManagement.Instance.GetByEmailAndPass(name, password);
        }

        public void DeleteProduct(Customer cus) => CustomerManagement.Instance.Remmove(cus);
      

        public List<Customer> GetCustomer()
        {
            return CustomerManagement.Instance.GetCustomers();
        }

        public Customer GetCustomerById(Customer customer)
        {
            return CustomerManagement.Instance.GetByID(customer.CustomerId);
        }

        public List<Customer> GetCustomersByEmail(string email)
        {
            return CustomerManagement.Instance.GetCustomerByEmail(email);
        }

        public void InsertCustomer(Customer customer) => CustomerManagement.Instance.AddNew(customer);


        public void Update(Customer customer) => CustomerManagement.Instance.Update(customer);

    }
}
