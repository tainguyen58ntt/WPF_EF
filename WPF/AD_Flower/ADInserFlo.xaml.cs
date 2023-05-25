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

namespace WPF.AD_Flower
{
    /// <summary>
    /// Interaction logic for ADInserFlo.xaml
    /// </summary>
    public partial class ADInserFlo : Window
    {
        IFlowerRepository _flower;
        ICategoryRepository categoryRepository;
        ISupplier supplierepository;
        int _cateId;
        int _supplierId;
        public ADInserFlo()
        {
            InitializeComponent();
            _flower = new FlowerRepository();
            categoryRepository = new CategoryRepository();
            supplierepository = new SupplierRepository();
            SetCategory();
        }
        private FlowerBouquet GetFlowerBouquetObject()
        {
            FlowerBouquet flowerBouquet = null;
            bool checkId = int.TryParse(txtFlId.Text, out int id);
            bool checkPrie = decimal.TryParse(txtFlPrice.Text, out decimal price);
            bool checkUnitStock = byte.TryParse(txtFlUnitStock.Text, out byte unitStock);
            bool checkStatus = byte.TryParse(txtFlStatus.Text, out byte status);
            try
            {
                if(checkId == false)
                {
                    MessageBox.Show("Id need to be a int ");
                }
                if (checkPrie == false)
                {
                    MessageBox.Show("price need to be a  decimal");
                }
                if (checkUnitStock == false)
                {
                    MessageBox.Show("unitStock need to be a int ");
                }
                if (checkStatus == false && status != 0 && status != 1)
                {
                    MessageBox.Show("status need to be a number 1 or 0");
                }
                if (checkId == true && checkPrie == true && checkUnitStock == true && checkStatus == true)
                {
                    
                    flowerBouquet = new FlowerBouquet()
                    {
                        FlowerBouquetId = id,

                        CategoryId = _cateId,
                        FlowerBouquetName = txtFlName.Text,
                        Description = txtFlDes.Text,
                        UnitPrice = price,
                        UnitsInStock = unitStock,
                        FlowerBouquetStatus = status,
                        SupplierId = _supplierId

                    };

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Flower");

            }
            return flowerBouquet;
        }

        private void SetCategory()
        {
            List<Category> categories = new List<Category>();
            categories = categoryRepository.GetCategories();
            List<Supplier> suppliers = new List<Supplier>();
            suppliers = supplierepository.GetSuppliers();
            supplierCombox.ItemsSource = suppliers;

            categoryComboBox.ItemsSource = categories;




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                if (string.IsNullOrEmpty(txtFlId.Text))
                {
                    MessageBox.Show("Need to input Flower Id");
                }
                else
                {

                    if (categoryComboBox.SelectedItem is Category selectedCategory && supplierCombox.SelectedItem is Supplier selectSupplier)
                    {
                        _cateId = selectedCategory.CategoryId;
                        _supplierId = selectSupplier.SupplierId;


                    }
                    if (_cateId == 0 || _supplierId == 0)
                    {
                        MessageBox.Show("Need to select cateId and suppler id");
                    }
                    else
                    {

                        // User clicked Yes
                        FlowerBouquet flowerBouquet = GetFlowerBouquetObject();

                        _flower.InserFlower(flowerBouquet);
                        //LoadCusList();
                        MessageBox.Show($"{flowerBouquet.FlowerBouquetName} inserted successfully", "insert Cus");
                        // Perform your desired actions



                        // User clicked No or closed the message box
                        // Perform other actions


                        //Customer customer = GetCustomerObject();

                        //_customerRepository.InsertCustomer(customer);
                        //LoadCusList();
                        //MessageBox.Show($"{customer.CustomerName} inserted successfully", "insert Cus");


                    }






                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "insert Flower");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FlowerBouquet f = new FlowerBouquet();
            f = GetFlowerBouquetObject();
            if (f != null)
            {
                MessageBox.Show("ok");
            }
        }
    }
}
