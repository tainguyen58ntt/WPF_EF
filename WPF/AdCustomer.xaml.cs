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
    /// Interaction logic for AdCustomer.xaml
    /// </summary>
    public partial class AdCustomer : Window
    {
        ICustomerRepository _customerRepository;
        public AdCustomer(ICustomerRepository customerRepository)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            LvPro.ItemsSource = customerRepository.GetCustomer();
        }

        //public AdCustomer()
        //{
        //}

        public void LoadCusList()
        {
            LvPro.ItemsSource = _customerRepository.GetCustomer();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadCusList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Cus list");
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Customer customer = GetCustomerObject();
                _customerRepository.InsertCustomer(customer);
                LoadCusList();
                MessageBox.Show($"{customer.CustomerName} inserted successfully", "insert pro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "insert pro");
            }
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
                MessageBox.Show(ex.Message, "Get Product");

            }
            return customer;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Customer customer = GetCustomerObject();
                _customerRepository.Update(customer);
                LoadCusList();
                MessageBox.Show($"{customer.CustomerName} updated successfully", "update pro");
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
                Customer customer = GetCustomerObject();
                _customerRepository.DeleteProduct(customer);
                LoadCusList();
                MessageBox.Show($"{customer.CustomerName} delete successfully", "delete pro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "delete pro");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();   
    }
}
