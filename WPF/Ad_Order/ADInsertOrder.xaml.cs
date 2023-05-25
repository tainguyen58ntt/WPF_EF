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
    /// Interaction logic for ADInsertOrder.xaml
    /// </summary>
    public partial class ADInsertOrder : Window
    {
        IOderRepository _oderRepository;
        ICustomerRepository customerRepository;
        int _cusId;
        private decimal _total;
        public ADInsertOrder()
        {
            InitializeComponent();
            _oderRepository = new OrderRepository();
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
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            bool checkValid = checkAllValid();
            if (checkValid)
            {

                Order order = GetOrderObject();
                bool check = checkDuplicateId(order);
                if (check == true)
                {
                    _oderRepository.InsertOrder(order);
                    MessageBox.Show("insert order success");

                }
                else
                {
                    MessageBox.Show("aldread have order with that id");

                }
            }

        }

        private bool checkDuplicateId(Order order)
        {
            Order ord = _oderRepository.GetObjectByOrId(order);
            if (ord != null)
            {
                return false;
            }
            return true;
        }
        private void SetCustomer()
        {
            List<Customer> customers = new List<Customer>();
            customers = customerRepository.GetCustomer();




            cbCustomer.ItemsSource = customers;




        }
       
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
                    Total =  0,
                    OrderStatus = ""
                   

                };

            }





            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get ORder");

            }
            return order;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();
     
    }
}
