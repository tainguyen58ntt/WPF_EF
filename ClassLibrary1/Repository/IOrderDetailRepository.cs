using ClassLibrary1.BussinessObject;
using ClassLibrary1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public interface IOrderDetailRepository
    {

        List<OrderDetail> GetOrderDetails();

        //List<OrderDetail> GetOrdersByCustomerID(int customerID);
       

        List<OrderDetail> GetOrderDetailsByOrderId(int orderId);
        void DeleteOrderDetail(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void InsertOrderDetail(OrderDetail orderDetail);
    }
}
