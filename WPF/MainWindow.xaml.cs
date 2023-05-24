using ClassLibrary.Repository;
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
                MessageBox.Show("nto null");
            }
            else
            {
                if (txtEmail.Equals(emailAdmin) && txtPassword.Equals(passwordAdmin))
                {
                    MessageBox.Show("ok admin");
                    ManageOption manageOption = new ManageOption();
                    manageOption.Show();
                }
                else if (CustomerRepository.CheckLogin(txtEmail, txtPassword) != null)
                {
                    MessageBox.Show("ok customer");
                    CusView cusView = new CusView(CustomerRepository,CustomerRepository.CheckLogin(txtEmail,txtPassword));    
                    cusView.Show();
                    //CustomerView customerView = new CustomerView(); 
                    //customerView.Show();
                    //CustomerView customerView = new CustomerView();
                    //customerView.Show();
                }
                else
                {
                    MessageBox.Show("fail");
                }
            }
        }
    }
}
