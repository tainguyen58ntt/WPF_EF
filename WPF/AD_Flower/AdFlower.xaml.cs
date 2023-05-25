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
using WPF.AD_Flower;

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
            //try
            //{
            //    FlowerBouquet flowerBouquet = GetFlowerBouquetObject();
            //    _flower.InserFlower(flowerBouquet);
            //    LoadFLList();
            //    MessageBox.Show($"{flowerBouquet.FlowerBouquetName} inserted successfully", "insert pro");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "insert pro");
            //}
            AdFlower_V2 childWindow = new AdFlower_V2();
            childWindow.Owner = this; // Set the parent window as the owner of the child window
            childWindow.ShowDialog();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //if (txtFlId.Text.Length > 0)
            //{
            //    MessageBoxResult result = MessageBox.Show("Do you want to bring record you select to update ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //    if (result == MessageBoxResult.Yes)
            //    {
            //        FlowerBouquet flowerBouquet = GetFlowerBouquetObject();
            //        if (flowerBouquet != null)
            //        {
            //            //_customerRepository.DeleteProduct(customer);
            //            //LoadCusList();
            //            //MessageBox.Show($"{customer.CustomerName} delete successfully", "delete pro");
            //            AdUpdateFlower childWindow = new AdUpdateFlower(flowerBouquet);
            //            childWindow.Owner = this; // Set the parent window as the owner of the child window
            //            childWindow.ShowDialog();
            //        }
            //    }
            //}
            //else
            //{
            //    ADUpdateCus childWindow = new ADUpdateCus();
            //    childWindow.Owner = this; // Set the parent window as the owner of the child window
            //    childWindow.ShowDialog();
            //}

            try
            {
                string check = txtFlId.Text;
                if (check.Length != 0)
                {
                    FlowerBouquet flowerBouquet = GetFlowerBouquetObject();
                    if (flowerBouquet != null)
                    {
                        //_customerRepository.DeleteProduct(customer);
                        //LoadCusList();
                        //MessageBox.Show($"{customer.CustomerName} delete successfully", "delete pro");
                        AdUpdateFlower childWindow = new AdUpdateFlower(flowerBouquet);
                        childWindow.Owner = this; // Set the parent window as the owner of the child window
                        childWindow.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Select record to update");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "update flo");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    FlowerBouquet flowerBouquet = GetFlowerBouquetObject();

            //    bool checkInOrderDetain = _flower.DeleteFlower(flowerBouquet);
            //    if(checkInOrderDetain)
            //    {
            //    LoadFLList();
            //    MessageBox.Show($"{flowerBouquet.FlowerBouquetName} delete successfully", "delete pro");

            //    }
            //    else {
            //        LoadFLList();
            //        MessageBox.Show($"{flowerBouquet.FlowerBouquetName} can not delete successfully", "delete pro");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "delete pro");
            //}
            try
            {
                string check = txtFlId.Text;
                if (check.Length != 0)
                {
                    MessageBoxResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        FlowerBouquet flowerBouquet = GetFlowerBouquetObject();
                        if (flowerBouquet != null)
                        {
                            _flower.DeleteFlower(flowerBouquet);
                            LoadFLList();
                            MessageBox.Show($"{flowerBouquet.FlowerBouquetName} delete successfully", "delete pro");

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
                MessageBox.Show(ex.Message, "delete flower");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();

        public void LoadFLListByName()
        {
            LvPro.ItemsSource = _flower.GetFlowerBouquetsByName(txtSearchByName.Text);
        }

        private void btnSearchName_click(object sender, RoutedEventArgs e)
        {
            LoadFLListByName();
        }
    }
}
