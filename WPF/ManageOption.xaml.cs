using ClassLibrary.Repository;
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
    /// Interaction logic for ManageOption.xaml
    /// </summary>
    public partial class ManageOption : Window
    {
        public ManageOption()
        {
            InitializeComponent();
        }

        private void btn_ADCustomer(object sender, RoutedEventArgs e)
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            //AdCustomer adCustomer = new AdCustomer(customerRepository);
            //adCustomer.Show();


            AdCustomer adCustomer = new AdCustomer(customerRepository);
            adCustomer.Owner = this; // Set the parent window as the owner of the child window
            adCustomer.Visibility = Visibility.Collapsed;
            adCustomer.ShowDialog();


            //this.Visibility = Visibility.Collapsed;
            //AdCustomer adCustomer = new AdCustomer(customerRepository);
            //adCustomer.Owner = this; // Set the parent window as the owner of the child window

            //adCustomer.ShowDialog();
            //this.Visibility = Visibility.Visible;

        }

        private void btn_ADFlower(object sender, RoutedEventArgs e)
        {
            IFlowerRepository flowerRepository = new FlowerRepository();
            AdFlower adFlower = new AdFlower(flowerRepository);
            adFlower.Show();

        }

        private void btn_ADOrder(object sender, RoutedEventArgs e)
        {
            IOderRepository oderRepositorys = new OrderRepository();
            AdOrder adFlower = new AdOrder(oderRepositorys);
            adFlower.Show();
        }
    }
}
