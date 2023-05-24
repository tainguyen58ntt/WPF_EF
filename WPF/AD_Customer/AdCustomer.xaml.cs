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
            //try
            //{
            //    if (string.IsNullOrEmpty(txtCusId.Text))
            //    {
            //        MessageBox.Show("Need to input Customer Id");
            //    }
            //    else
            //    {
            //        if (!dbBirth.SelectedDate.HasValue)
            //        {

            //            MessageBoxResult result = MessageBox.Show("Set default birthday (2002/1/1) ", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //            if (result == MessageBoxResult.Yes)
            //            {
            //                // User clicked Yes
            //                Customer customer = GetCustomerObject();

            //                _customerRepository.InsertCustomer(customer);
            //                LoadCusList();
            //                MessageBox.Show($"{customer.CustomerName} inserted successfully", "insert Cus");
            //                // Perform your desired actions
            //            }
            //            else
            //            {
            //                // User clicked No or closed the message box
            //                // Perform other actions
            //                MessageBox.Show("Input your birthday");
            //            }
            //            //Customer customer = GetCustomerObject();

            //            //_customerRepository.InsertCustomer(customer);
            //            //LoadCusList();
            //            //MessageBox.Show($"{customer.CustomerName} inserted successfully", "insert Cus");

            //        }




            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "insert Cus");
            //}
            


            // Creating and showing the child window
            ADInsertCus childWindow = new ADInsertCus();
            childWindow.Owner = this; // Set the parent window as the owner of the child window
            childWindow.ShowDialog();

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

        private Customer GetCustomerObject()
        {
            Customer customer = null;
            //DateTime? selectedDate = dbBirth.SelectedDate;
            //DateTime defaultBirthday = new DateTime(2002, 1, 1);

            //DateTime customerBirthday = selectedDate ?? defaultBirthday;
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
                    Birthday = DateTime.Parse(dbBirth.Text)

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Customer");

            }
            return customer;
        }

        //private void btnUpdate_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        Customer customer = GetCustomerObject();
        //        _customerRepository.Update(customer);
        //        LoadCusList();
        //        MessageBox.Show($"{customer.CustomerName} updated successfully", "update pro");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "update pro");
        //    }
        //}

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string check = txtCusId.Text;
                if(check.Length != 0)
                {
                    MessageBoxResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        Customer customer = GetCustomerObject();
                        if (customer != null)
                        {
                            _customerRepository.DeleteProduct(customer);
                            LoadCusList();
                            MessageBox.Show($"{customer.CustomerName} delete successfully", "delete pro");

                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Select record to delete");
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "delete pro");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(txtCusId.Text.Length > 0)
            {
                MessageBoxResult result = MessageBox.Show("Do you want to bring record you select to update ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Customer customer = GetCustomerObject();
                    if (customer != null)
                    {
                        //_customerRepository.DeleteProduct(customer);
                        //LoadCusList();
                        //MessageBox.Show($"{customer.CustomerName} delete successfully", "delete pro");
                        ADUpdateCus childWindow = new ADUpdateCus(customer);
                        childWindow.Owner = this; // Set the parent window as the owner of the child window
                        childWindow.ShowDialog();
                    }
                }
            }
            else
            {
                ADUpdateCus childWindow = new ADUpdateCus();
                childWindow.Owner = this; // Set the parent window as the owner of the child window
                childWindow.ShowDialog();
            }
        }
    }
}
