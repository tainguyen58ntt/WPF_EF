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

namespace WPF
{
    /// <summary>
    /// Interaction logic for AdFlower.xaml
    /// </summary>
    public partial class AdFlower : Window
    {
        IFlowerRepository _flower;
        public AdFlower(IFlowerRepository flower)
        {
            InitializeComponent();
            _flower = flower;
            LvPro.ItemsSource = _flower.GetFlowerBouquets();
        }
        public void LoadFLList()
        {
            LvPro.ItemsSource = _flower.GetFlowerBouquets();
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadFLList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load FL list");
            }
        }
        private FlowerBouquet GetFlowerBouquetObject()
        {
            FlowerBouquet flowerBouquet = null;
            try
            {
                flowerBouquet = new FlowerBouquet()
                {
                    FlowerBouquetId  = int.Parse(txtFlId.Text),
                    CategoryId = int.Parse(txtFlCate.Text),
                    FlowerBouquetName = txtFlName.Text,
                    Description = txtFlDes.Text,
                    UnitPrice = decimal.Parse(txtFlPrice.Text),
                    UnitsInStock = int.Parse(txtFlUnitStock.Text),
                    FlowerBouquetStatus = byte.Parse(txtFlStatus.Text),
                    SupplierId = int.Parse(txtFlSupplierId.Text),

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");

            }
            return flowerBouquet;
        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FlowerBouquet flowerBouquet = GetFlowerBouquetObject();
                _flower.InserFlower(flowerBouquet);
                LoadFLList();
                MessageBox.Show($"{flowerBouquet.FlowerBouquetName} inserted successfully", "insert pro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "insert pro");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FlowerBouquet flowerBouquet = GetFlowerBouquetObject();

                bool checkInOrderDetain = _flower.DeleteFlower(flowerBouquet);
                if(checkInOrderDetain)
                {
                LoadFLList();
                MessageBox.Show($"{flowerBouquet.FlowerBouquetName} delete successfully", "delete pro");

                }
                else {
                    LoadFLList();
                    MessageBox.Show($"{flowerBouquet.FlowerBouquetName} can not delete successfully", "delete pro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "delete pro");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();

    }
}
