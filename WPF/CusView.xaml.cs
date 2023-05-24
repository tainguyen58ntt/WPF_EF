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

namespace WPF
{
    /// <summary>
    /// Interaction logic for CusView.xaml
    /// </summary>
    public partial class CusView : Window
    {
        private Customer _customerLogin;
        ICustomerRepository _customerRepository;
        IOderRepository oderRepository;
        public CusView(ICustomerRepository customerRepository, Customer customerLogin)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _customerLogin = customerLogin;
            LoadCustomerLogin();
        }

        private void LoadCustomerLogin()
        {
            txtCusId.Text = _customerLogin.CustomerId.ToString();

            txtCusEmail.Text = _customerLogin.Email.ToString();
            txtCusName.Text = _customerLogin.CustomerName.ToString();
            txtCusCity.Text = _customerLogin.City.ToString();
            txtCusCountry.Text = _customerLogin.Country.ToString();
            txtCusPassword.Text = _customerLogin.Password.ToString();
            txtCusBirth.Text = _customerLogin.Birthday.ToString();


        }


        private Customer GetCustomerObject()
        {
            Customer customer = null;
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
                    Birthday = DateTime.Parse(txtCusBirth.Text)

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Customer");

            }
            return customer;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Customer customer = GetCustomerObject();
                if (customer.Email.Equals(""))
                {
                    MessageBox.Show($"Email not be empty, updated fail", "update Customer");
                    LoadCustomerLogin();
                }
                else if(customer.Password.Equals(""))
                {
                    MessageBox.Show($"Password not be empty, updated fail", "update Customer");
                    LoadCustomerLogin();
                }
                else
                {
                    _customerRepository.Update(customer);
                    _customerLogin = customer;
                    LoadCustomerLogin();
                    MessageBox.Show($"{customer.CustomerName} updated successfully", "update Customer");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "update pro");
            }
        }


        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();




        private void btn_CusViewOrder_Click(object sender, RoutedEventArgs e)
        {
            IOderRepository oderRepository = new OrderRepository();
            int cusId = int.Parse(txtCusId.Text);
            CusOrder cusOrder = new CusOrder(oderRepository, cusId);
            this.Close(); 
            cusOrder.Show();
        }
    }
}
