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
    /// Interaction logic for ADUpdateCus.xaml
    /// </summary>
    public partial class ADUpdateCus : Window
    {
        private Customer _customer;
        ICustomerRepository _customerRepository;
        public ADUpdateCus()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
        }
        public ADUpdateCus(Customer customer)
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
            _customer = customer;
            AttachToTextBox();
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
        private void AttachToTextBox()
        {
            txtCusId.Text = _customer.CustomerId.ToString();
            txtCusEmail.Text = _customer.Email.ToString();
            txtCusName.Text = _customer.CustomerName.ToString();    
            txtCusCity.Text = _customer.City.ToString();    
            txtCusCountry.Text = _customer.Country.ToString();
            txtCusPassword.Text = _customer.Password.ToString();    
            dbBirth.Text = _customer.Birthday.ToString();



       
    }
        private Customer GetCustomerObject()
        {
            Customer customer = null;
            DateTime? selectedDate = dbBirth.SelectedDate;
            DateTime defaultBirthday = new DateTime(2002, 1, 1);

            DateTime customerBirthday = selectedDate ?? defaultBirthday;
            try
            {
                customer = new Customer
                {
                    CustomerId = int.Parse(txtCusId.Text),
                    Email = txtCusEmail.Text,
                    CustomerName = txtCusName.Text,
                    City = txtCusCity.Text,
                    Country = txtCusCountry.Text,
                    Password = txtCusPassword.Text,
                    Birthday = customerBirthday

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Customer");

            }
            return customer;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            //try
            //{
            //    Customer customer = GetCustomerObject();
            //    _customerRepository.Update(customer);

            //    MessageBox.Show($"{customer.CustomerName} updated successfully", "update pro");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "update pro");
            //}
          
        }
    }
}
