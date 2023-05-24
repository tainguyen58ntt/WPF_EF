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
    /// Interaction logic for CusOrderDetail.xaml
    /// </summary>
    public partial class CusOrderDetail : Window
    {
        IOderRepository _oderRepository;
        IOrderDetailRepository _orderDetailRepository;
        public CusOrderDetail(int orderId)
        {
            InitializeComponent();
            _orderDetailRepository = new OrderDetailRepository();

            LvPro.ItemsSource = GetOrderDetailsByOrderId(orderId);

        }
      private List<OrderDetail> GetOrderDetailsByOrderId(int orderId) { 
            return _orderDetailRepository.GetOrderDetailsByOrderId(orderId);    
        }
            

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();

    }
}
