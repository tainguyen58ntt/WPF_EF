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
            try
            {
                if (string.IsNullOrEmpty(txtCusId.Text))
                {
                    MessageBox.Show("Need to input Customer Id");
                }
                else
                {
                    if (!dbBirth.SelectedDate.HasValue)
                    {

                        MessageBoxResult result = MessageBox.Show("Set default birthday (2002/1/1) ", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                        if (result == MessageBoxResult.Yes)
                        {
                            // User clicked Yes
                            Customer customer = GetCustomerObject();

                            _customerRepository.InsertCustomer(customer);
                            //LoadCusList();
                            MessageBox.Show($"{customer.CustomerName} inserted successfully", "insert Cus");
                            // Perform your desired actions
                        }
                        else
                        {
                            // User clicked No or closed the message box
                            // Perform other actions
                            MessageBox.Show("Input your birthday");
                        }
                        //Customer customer = GetCustomerObject();

                        //_customerRepository.InsertCustomer(customer);
                        //LoadCusList();
                        //MessageBox.Show($"{customer.CustomerName} inserted successfully", "insert Cus");

                    }




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "insert Cus");
            }

        }
    }
}
