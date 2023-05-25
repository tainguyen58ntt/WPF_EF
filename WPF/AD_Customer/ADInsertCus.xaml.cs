using ClassLibrary.Repository;
using ClassLibrary1.BussinessObject;
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
    /// Interaction logic for ADInsertCus.xaml
    /// </summary>
    public partial class ADInsertCus : Window
    {
        ICustomerRepository _customerRepository;
        public ADInsertCus()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository(); 
        }

        private bool checkAllValid()
        {
            // check id
            string mess = "";
            bool checkId = int.TryParse(txtCusId.Text, out int id);
            if (checkId == false)
            {
                mess = "id need to be int";
                MessageBox.Show(mess);
                return false;
            }
       
         

            DateTime? checkDbOrDate = dbBirth.SelectedDate;

            if (!checkDbOrDate.HasValue)
            {
                //DateTime dateValue = checkDbOrDate.Value;
                //Console.WriteLine(dateValue);
                mess = "Birth date need to be selected";
                MessageBox.Show(mess);
                return false;
            }

          
            return true;
        }

        private bool checkDuplicateId(Customer customer)
        {
            Customer cus = _customerRepository.GetCustomerById(customer);
            if (cus != null)
            {
                return false;
            }
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool checkValid = checkAllValid();
            if (checkValid)
            {

                Customer customer = GetCustomer();
                bool check = checkDuplicateId(customer);
                if (check == true)
                {
                    _customerRepository.InsertCustomer(customer);
                    MessageBox.Show("insert customer success");

                }
                else
                {
                    MessageBox.Show("aldread have customer with that id");

                }
            }

        }

        private Customer GetCustomer()
        {
            Customer customer = null;
            bool checkId = int.TryParse(txtCusId.Text, out int id);
            //bool checkPrie = decimal.TryParse(txtFlPrice.Text, out decimal price);
            //bool checkUnitStock = byte.TryParse(txtFlUnitStock.Text, out byte unitStock);
            //bool checkStatus = byte.TryParse(txtFlStatus.Text, out byte status);
            try
            {
              
                //if (checkPrie == false)
                //{
                //    MessageBox.Show("price need to be a  decimal");
                //}
                //if (checkUnitStock == false)
                //{
                //    MessageBox.Show("unitStock need to be a int ");
                //}
                //if (checkStatus == false && status != 0 && status != 1)
                //{
                //    MessageBox.Show("status need to be a number 1 or 0");
                //}
             

                    customer = new Customer()
                    {
                        CustomerId = id,

                        Email = txtCusEmail.Text,
                        CustomerName = txtCusName.Text,
                        City = txtCusCity.Text,
                        Country = txtCusCountry.Text,
                        Password = txtCusPassword.Text,
                        Birthday = DateTime.Parse(dbBirth.Text),
                        

                    };

                




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Customer");

            }
            return customer;
        }



    }
}
