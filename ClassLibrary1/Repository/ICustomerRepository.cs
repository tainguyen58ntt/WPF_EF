
using ClassLibrary1.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomer();
        Customer CheckLogin(string name, string password);


        //Car GetCarByID(int id);
        void InsertCustomer(Customer customer);
        void Update(Customer customer);
        void DeleteProduct(Customer cus);
        List<Customer> GetCustomersByEmail(string email);
        Customer GetCustomerById(Customer customer);
    }
}
