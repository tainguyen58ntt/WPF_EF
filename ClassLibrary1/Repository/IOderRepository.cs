using ClassLibrary1.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public interface IOderRepository
    {
        List<Order> GetOrders();
        List<Order> GetOrdersByCustomerID(int customerID);


        void InsertOrder(Order order);
        void Update(Order order);
        void DeleOrder(Order order);
        //void InserFlower(FlowerBouquet flowerBouquet);
        ////void Update(Customer customer);
        //bool DeleteFlower(FlowerBouquet flowerBouquet);
    }
}
