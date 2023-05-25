using ClassLibrary.Repository;
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

namespace WPF.Ad_Order
{
    /// <summary>
    /// Interaction logic for AdUpdateOrder.xaml
    /// </summary>
    public partial class AdUpdateOrder : Window
    {
        ICustomerRepository customerRepository;
        IOderRepository oderRepository;
        private Order _order;
        int _cusId;
        public AdUpdateOrder()
        {
            InitializeComponent();
        }
        public AdUpdateOrder(Order order)
        {
            InitializeComponent();
            //flowerRepository = new FlowerRepository();
            oderRepository = new OrderRepository();
            _order = order;
            //categoryRepository = new CategoryRepository();
            //supplierepository = new SupplierRepository();
            AttachToTextBox();
            customerRepository = new CustomerRepository();
            SetCustomer();

        }
        private bool checkAllValid()
        {
            // check id
            string mess = "";
            bool checkId = int.TryParse(txtOrId.Text, out int id);
            if (checkId == false)
            {
                mess = "id need to be int";
                MessageBox.Show(mess);
                return false;
            }
            bool checkCus = false;
            if (cbCustomer.SelectedItem is Customer selectCustomer)
            {
                _cusId = selectCustomer.CustomerId;

                checkCus = true;

            }
            if (checkCus == false)
            {
                mess = "Customer need to be select";
                MessageBox.Show(mess);
                return false;
            }
            //bool checkSupplier = false;
            //if (supplierCombox.SelectedItem is Supplier selectSupplier)
            //{
            //    _supplierId = selectSupplier.SupplierId;

            //    checkSupplier = true;

            //}
            //if (checkSupplier == false)
            //{
            //    mess = "Supplier need to be select";
            //    MessageBox.Show(mess);
            //    return false;
            //}

            //bool checkUnitPrice = decimal.TryParse(txtFlPrice.Text, out decimal price);
            //if (checkUnitPrice == false)
            //{
            //    mess = "Price need to be number";
            //    MessageBox.Show(mess);
            //    return false;
            //}
            //bool checkDbOrDate = int.TryParse(dbOrDate.Text, out int orDate);
            //bool checkDbOrDate = false;

            //if (checkDbOrDate == false)
            //{
            //    mess = "Order Date need to be number";
            //    MessageBox.Show(mess);
            //    return false;
            //}

            DateTime? checkDbOrDate = dbOrDate.SelectedDate;

            if (!checkDbOrDate.HasValue)
            {
                //DateTime dateValue = checkDbOrDate.Value;
                //Console.WriteLine(dateValue);
                mess = "Order date need to be selected";
                MessageBox.Show(mess);
                return false;
            }

            //bool checkStatus = int.TryParse(txtFlStatus.Text, out int status);
            //if (checkStatus == false || (!txtFlStatus.Text.Equals("0") && !txtFlStatus.Text.Equals("1")))
            //{
            //    mess = "Status need to be number 0 or 1";
            //    MessageBox.Show(mess);
            //    return false;
            //}

            //bool checkSupplier = false;
            //if (supplierCombox.SelectedItem is Supplier selectSupplier)
            //{
            //    _supplierId = selectSupplier.SupplierId;

            //    checkSupplier = true;

            //}
            //if (checkSupplier == false)
            //{
            //    mess = "Supplier need to be select";
            //    MessageBox.Show(mess);
            //    return false;
            //}
            return true;
        }
        private void SetCustomer()
        {
            List<Customer> customers = new List<Customer>();
            customers = customerRepository.GetCustomer();




            cbCustomer.ItemsSource = customers;




        }
        //private Customer GetCustomerObject()
        //{
        //    Customer customer = null;
        //    DateTime? selectedDate = dbBirth.SelectedDate;
        //    DateTime defaultBirthday = new DateTime(2002, 1, 1);

        //    DateTime customerBirthday = selectedDate ?? defaultBirthday;
        //    try
        //    {
        //        customer = new Customer
        //        {
        //            CustomerId = int.Parse(txtCusId.Text),
        //            Email = txtCusEmail.Text,
        //            CustomerName = txtCusName.Text,
        //            City = txtCusCity.Text,
        //            Country = txtCusCountry.Text,
        //            Password = txtCusPassword.Text,
        //            Birthday = customerBirthday

        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Get Customer");

        //    }
        //    return customer;
        //}
        private Order GetOrderObject()
        {
            Order order = null;
            DateTime? shipDate = dbOrShipdate.SelectedDate;

            if (!shipDate.HasValue)
            {
                shipDate = null;
            }
            try
            {


                order = new Order()
                {
                    OrderId = int.Parse(txtOrId.Text),

                    CustomerId = _cusId,
                    OrderDate = DateTime.Parse(dbOrDate.Text),
                    ShippedDate = shipDate,
                    Total = decimal.Parse(txtOrTotal.Text),
                    OrderStatus = txtOrStatus.Text,


                };

            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get ORder");

            }
            return order;
        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    Order order = GetOrderObject();
            //    oderRepository.Update(order);

            //    MessageBox.Show($"{order.OrderId} updated successfully", "update order");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "update order");
            //}
            bool checkValid = checkAllValid();
            if (checkValid)
            {
                try
                {
                    Order order = GetOrderObject();
                    oderRepository.Update(order);

                    MessageBox.Show($"{order.OrderId} updated successfully", "update order");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "update order");
                }
            }
        }
        private void AttachToTextBox()
        {
            txtOrId.Text = _order.OrderId.ToString();
            //.Text = _flowerBouquet.CategoryId.ToString();
            dbOrDate.Text = _order.OrderDate.ToString();
            dbOrShipdate.Text = _order.ShippedDate.ToString();
            txtOrTotal.Text = _order.Total.ToString();
            txtOrStatus.Text = _order.OrderStatus.ToString();





        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();

    
    
    }
}
