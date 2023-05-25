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

namespace WPF.Ad_OrderDetail
{
    /// <summary>
    /// Interaction logic for ADInsertOrderDetail.xaml
    /// </summary>
    public partial class ADInsertOrderDetail : Window
    {
        IFlowerRepository flowerRepository;
        private int _orderId;
        public ADInsertOrderDetail(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            flowerRepository = new FlowerRepository(); 
            SetFlower();
            txtOrderId.Text = orderId.ToString();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void SetFlower()
        {
            List<FlowerBouquet> flowerBouquets = new List<FlowerBouquet>();
            flowerBouquets = flowerRepository.GetFlowerBouquets();




            cbFlower.ItemsSource = flowerBouquets;




        }
    }
}
