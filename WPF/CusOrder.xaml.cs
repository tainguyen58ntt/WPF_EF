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
    /// Interaction logic for CusOrder.xaml
    /// </summary>
    public partial class CusOrder : Window
    {
        IOderRepository _oderRepository;
        public CusOrder(IOderRepository oderRepository, int cusId)
        {
            InitializeComponent();
            _oderRepository = oderRepository;
            LvPro.ItemsSource = _oderRepository.GetOrdersByCustomerID(cusId);


        }

        private void btn_View_OrderDetail_Click(object sender, RoutedEventArgs e)
        {
            int orderId;
            if (txtOrId.Text.Length == 0)
            {
                MessageBox.Show("Need to select row in table first");
            }
            else
            {
             orderId = int.Parse(txtOrId.Text);

                //CusOrderDetail cusOrderDetail = new CusOrderDetail(orderId);
                //this.Close();
                //cusOrderDetail.Show();


                CusOrderDetail cusOrderDetail = new CusOrderDetail(orderId);
                cusOrderDetail.Owner = this; // Set the parent window as the owner of the child window
                cusOrderDetail.Visibility = Visibility.Collapsed;
                cusOrderDetail.ShowDialog();
            }



        }


        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();


    }
}
