using ClassLibrary.Repository;
using ClassLibrary1.BussinessObject;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICustomerRepository CustomerRepository;
        public MainWindow()
        {
            InitializeComponent();
            CustomerRepository = new CustomerRepository();
        }

        private IConfiguration Configuration { get; set; }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            string emailAdmin = Configuration["Email"];
            string passwordAdmin = Configuration["Password"];
            var txtEmail = EmailTextBox.Text;
            var txtPassword = PasswordBox.Password;

            if (string.IsNullOrEmpty(txtEmail) || string.IsNullOrEmpty(txtPassword))  // check not null
            {
                MessageBox.Show("Not empty, need to input Email and Password");
            }
            else
            {
                if (txtEmail.Equals(emailAdmin) && txtPassword.Equals(passwordAdmin))
                {
                    MessageBox.Show("ok admin");
                    //ManageOption manageOption = new ManageOption();
                    //manageOption.Show();

                    this.Visibility = Visibility.Collapsed;
                    ManageOption manageOption = new ManageOption();
                    manageOption.Owner = this; // Set the parent window as the owner of the child window
                    
                    manageOption.ShowDialog();
                    this.Visibility = Visibility.Visible;
                }
                else if (CustomerRepository.CheckLogin(txtEmail, txtPassword) != null)
                {
                    MessageBox.Show("customer role");
                    CusView cusView = new CusView(CustomerRepository,CustomerRepository.CheckLogin(txtEmail,txtPassword));    
                    this.Close();   
                    cusView.Show();
                    //CustomerView customerView = new CustomerView(); 
                    //customerView.Show();
                    //CustomerView customerView = new CustomerView();
                    //customerView.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Email or Password");
                }
            }
        }
    }
}
