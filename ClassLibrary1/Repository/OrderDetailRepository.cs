using ClassLibrary1.BussinessObject;
using ClassLibrary1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository

    {
        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
             OrderDetailManagement.Instance.Remmove(orderDetail);
        }

        public List<OrderDetail> GetOrderDetails()
        {
            return OrderDetailManagement.Instance.GetOrdersDetail();
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            return OrderDetailManagement.Instance.GetOrderDetailByOderId(orderId);
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
          OrderDetailManagement.Instance.AddNew(orderDetail);    
        }

        //public List<OrderDetail> GetOrdersByCustomerID(int customerID)
        //{
        //    return OrderDetailManagement.Instance.GetOrdersByCustomerID(customerID);
        //}

        public void Update(OrderDetail orderDetail) =>  OrderDetailManagement.Instance.Update(orderDetail);

    }
}
