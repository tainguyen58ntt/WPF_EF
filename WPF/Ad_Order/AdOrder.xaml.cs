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
using WPF.AD_Flower;
using WPF.Ad_Order;

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
            //try
            //{
            //    Order order = GetOrderObject();
            //    _oderRepository.InsertOrder(order);
            //    LoadOrderList();
            //    MessageBox.Show($"{order.OrderId} inserted successfully", "insert pro");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "insert pro");
            //}
            ADInsertOrder childWindow = new ADInsertOrder();
            childWindow.Owner = this; // Set the parent window as the owner of the child window
            childWindow.ShowDialog();
        }

        private Order GetOrderObject()
        {
            Order order = null;
            DateTime? shipDate;
            try
            {
                if (txtShipDate.Text.Length == 0)
                {
                    shipDate = null;
                    order = new Order
                    {
                        OrderId = int.Parse(txtOrId.Text),
                        CustomerId = int.Parse(txtOrCusId.Text),
                        OrderDate = DateTime.Parse(txtOrDate.Text),
                        ShippedDate = shipDate,
                        Total = Decimal.Parse(txtOrTotal.Text),
                        OrderStatus = txtOrStatus.Text,


                    };
                }
                else
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");

            }
            return order;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    Order order = GetOrderObject();
            //    _oderRepository.Update(order);
            //    LoadOrderList();
            //    MessageBox.Show($"{order.OrderId} updated successfully", "update pro");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "update pro");
            //}
            try
            {
                string check = txtOrId.Text;
                if (check.Length != 0)
                {
                    Order order = GetOrderObject();
                    if (order != null)
                    {
                        //_customerRepository.DeleteProduct(customer);
                        //LoadCusList();
                        //MessageBox.Show($"{customer.CustomerName} delete successfully", "delete pro");
                        AdUpdateOrder childWindow = new AdUpdateOrder(order);
                        childWindow.Owner = this; // Set the parent window as the owner of the child window
                        childWindow.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Select record to update");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "update flo");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {


            if (txtOrId.Text.Length != 0)
            {
                MessageBoxResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
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

            }
            else
            {
                MessageBox.Show("Select record to delete  order");
            }



            //try
            //{
            //    string check = txtCusId.Text;
            //    if (check.Length != 0)
            //    {
            //        MessageBoxResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //        if (result == MessageBoxResult.Yes)
            //        {
            //            Customer customer = GetCustomerObject();
            //            if (customer != null)
            //            {
            //                _customerRepository.DeleteProduct(customer);
            //                LoadCusList();
            //                MessageBox.Show($"{customer.CustomerName} delete successfully", "delete pro");

            //            }
            //        }
            //        else
            //        {

            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Select record to delete");
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "delete pro");
            //}
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();




        private void btn_AD_View_OrderDetail(object sender, RoutedEventArgs e)
        {
            if (txtOrId.Text.Length != 0)
            {
                AdOrderDetail adOrderDetail = new AdOrderDetail(int.Parse(txtOrId.Text));
                adOrderDetail.Show();

            }
            else
            {
                MessageBox.Show("Select record to view detail order");
            }
        }

        private void btnDStatistics_Click(object sender, RoutedEventArgs e)
        {
            Ad_Statistics ad_Statistics = new Ad_Statistics();
            ad_Statistics.Show();
        }
    }
}
