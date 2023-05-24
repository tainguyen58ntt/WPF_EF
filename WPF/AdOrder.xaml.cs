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

namespace WPF
{
    /// <summary>
    /// Interaction logic for AdOrder.xaml
    /// </summary>
    public partial class AdOrder : Window
    {
        IOderRepository _oderRepository;
        public AdOrder(IOderRepository oderRepository)
        {
            InitializeComponent();
            _oderRepository = oderRepository;
            LvPro.ItemsSource = _oderRepository.GetOrders();
        }
        //private Order GetOrder()
        //{
        //    Order order = new Order()
        //    {
        //        OrderId = int.Parse(txtOrCusId.Text),

        //    };  
        //    return order;
        //}
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadOrderList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Cus list");
            }
        }


        public void LoadOrderList()
        {
            LvPro.ItemsSource = _oderRepository.GetOrders();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = GetOrderObject();
                _oderRepository.InsertOrder(order);
                LoadOrderList();
                MessageBox.Show($"{order.OrderId} inserted successfully", "insert pro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "insert pro");
            }
        }

        private Order GetOrderObject()
        {
            Order order = null;
            try
            {
                order = new Order
                {
                    OrderId = int.Parse(txtOrId.Text),
                    CustomerId = int.Parse(txtOrCusId.Text),
                    OrderDate = DateTime.Parse(txtOrDate.Text),
                    ShippedDate = DateTime.Parse(txtShipDate.Text),
                    Total = Decimal.Parse(txtOrTotal.Text),
                    OrderStatus = txtOrStatus.Text,
                    

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");

            }
            return order;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = GetOrderObject();
                _oderRepository.Update(order);
                LoadOrderList();
                MessageBox.Show($"{order.OrderId} updated successfully", "update pro");
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
                Order order = GetOrderObject();
                _oderRepository.DeleOrder(order);
                LoadOrderList();
                MessageBox.Show($"{order.OrderId} delete successfully", "delete pro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "delete pro");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();   
       

       

        private void btn_AD_View_OrderDetail(object sender, RoutedEventArgs e)
        {
            AdOrderDetail adOrderDetail = new AdOrderDetail(int.Parse(txtOrId.Text));
            adOrderDetail.Show();   
        }

        private void btnDStatistics_Click(object sender, RoutedEventArgs e)
        {
            Ad_Statistics ad_Statistics = new Ad_Statistics();
            ad_Statistics.Show();
        }
    }
}
