using ClassLibrary1.BussinessObject;
using ClassLibrary1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF.Ad_Order;
using WPF.Ad_OrderDetail;

namespace WPF
{
    /// <summary>
    /// Interaction logic for AdOrderDetail.xaml
    /// </summary>
    public partial class AdOrderDetail : Window
    {
        IOderRepository _oderRepository;
        IOrderDetailRepository _orderDetailRepository;
        int _orderId = 0;
        public AdOrderDetail(int orderId)
        {
            InitializeComponent();
            _orderDetailRepository = new OrderDetailRepository();
            _orderId  = orderId;    
            LvPro.ItemsSource = GetOrderDetailsByOrderId(orderId);
        }
        public void LoadOrderDetail()
        {
            LvPro.ItemsSource = GetOrderDetailsByOrderId(_orderId);
        }
        private List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            return _orderDetailRepository.GetOrderDetailsByOrderId(orderId);
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadOrderDetail();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load orderDetail list");
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    OrderDetail orderDetail = GetOrderDetail();
            //    _orderDetailRepository.InsertOrderDetail(orderDetail);
            //    LoadOrderDetail();
            //    MessageBox.Show($"{orderDetail.OrderId} inserted successfully", "insert pro");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "insert pro");
            //}
            ADInsertOrderDetail childWindow = new ADInsertOrderDetail(_orderId);
            childWindow.Owner = this; // Set the parent window as the owner of the child window
            childWindow.ShowDialog();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderDetail orderDetail = GetOrderDetail();
                _orderDetailRepository.Update(orderDetail);
                LoadOrderDetail();
                MessageBox.Show($"{orderDetail.OrderId} updated successfully", "update pro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "update pro");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderDetail orderDetail = GetOrderDetail();
                _orderDetailRepository.DeleteOrderDetail(orderDetail);
                LoadOrderDetail();
                MessageBox.Show($"{orderDetail.OrderId} delete successfully", "delete orderdetail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "delete ordertail");
            }
        }
        private OrderDetail GetOrderDetail()
        {
            OrderDetail orderDetail = null;
            try
            {
                orderDetail = new OrderDetail()
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    FlowerBouquetId = int.Parse(txtFlowerBouquetId.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = int.Parse(txtDiscount.Text),
                   

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get OrderDetail");

            }
            return orderDetail;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();
       
    }
}
