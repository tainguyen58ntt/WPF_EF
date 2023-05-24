﻿using ClassLibrary1.BussinessObject;
using ClassLibrary1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public class OrderRepository : IOderRepository
    {
        public void DeleOrder(Order order)
        {
            OrderManagement.Instance.Remmove(order);    
        }

        public List<Order> GetOrders()
        {
            return OrderManagement.Instance.GetOrders();    
        }

        public List<Order> GetOrdersByCustomerID(int customerID)
        {
            return OrderManagement.Instance.GetOrdersByCustomerID(customerID);
        }

        public void InsertOrder(Order order)
        {
            OrderManagement.Instance.AddNew(order);
        }

        public void Update(Order order)
        {
            OrderManagement.Instance.Update(order); 
        }
    }
}
