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
    /// Interaction logic for Ad_Statistics.xaml
    /// </summary>
    public partial class Ad_Statistics : Window
    {
        IOderRepository _oderRepository;
        public Ad_Statistics()
        {
            InitializeComponent();
            _oderRepository = new OrderRepository();    
            LvPro.ItemsSource = _oderRepository.GetOrders();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? startDate = dbStarDate.SelectedDate;
            DateTime? endDate = dbEndDate.SelectedDate; 
            if(startDate == null || endDate == null)
            {
                MessageBox.Show("Need to select start date and end date before fill");
            }
            else
            {
                LoadOrderListFill(startDate, endDate);
            }
        }
        public void LoadOrderListFill(DateTime? startDate, DateTime? endDate)
        {
            LvPro.ItemsSource = _oderRepository.GetOrdersAfterFill(startDate, endDate);     
        }

        public void LoadOrderList()
        {
            LvPro.ItemsSource = _oderRepository.GetOrders();
        }
    }
}
