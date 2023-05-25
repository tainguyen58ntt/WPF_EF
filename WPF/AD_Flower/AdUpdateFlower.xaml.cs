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
    /// Interaction logic for AdUpdateFlower.xaml
    /// </summary>
    public partial class AdUpdateFlower : Window
    {
        private FlowerBouquet _flowerBouquet;
        IFlowerRepository flowerRepository;
        ICategoryRepository categoryRepository;
        ISupplier supplierepository;
        int _cateId;
        int _supplierId;
        public AdUpdateFlower()
        {
            InitializeComponent();
            flowerRepository = new FlowerRepository();
            categoryRepository = new CategoryRepository();
            supplierepository = new SupplierRepository();
            SetCategory();
        }
        public AdUpdateFlower(FlowerBouquet flowerBouquet)
        {
            InitializeComponent();
            flowerRepository = new FlowerRepository();
            _flowerBouquet = flowerBouquet;
            categoryRepository = new CategoryRepository();
            supplierepository = new SupplierRepository();
            AttachToTextBox();
            SetCategory();
        }
        private void AttachToTextBox()
        {
            txtFlId.Text = _flowerBouquet.FlowerBouquetId.ToString();
            categoryComboBox.Text = _flowerBouquet.CategoryId.ToString();
            txtFlName.Text = _flowerBouquet.FlowerBouquetName.ToString();
            txtFlDes.Text = _flowerBouquet.Description.ToString();
            txtFlPrice.Text = _flowerBouquet.UnitPrice.ToString();
            txtFlUnitStock.Text = _flowerBouquet.UnitsInStock.ToString();
            txtFlStatus.Text = _flowerBouquet.FlowerBouquetStatus.ToString();
            supplierCombox.Text = _flowerBouquet.SupplierId.ToString();




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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        //private FlowerBouquet GetFlowerBouquetObject()
        //{
        //FlowerBouquet flowerBouquet = null;
        //DateTime? selectedDate = dbBirth.SelectedDate;
        //DateTime defaultBirthday = new DateTime(2002, 1, 1);

        //DateTime customerBirthday = selectedDate ?? defaultBirthday;
        //try
        //{
        //    customer = new Customer
        //    {
        //        CustomerId = int.Parse(txtCusId.Text),
        //        Email = txtCusEmail.Text,
        //        CustomerName = txtCusName.Text,
        //        City = txtCusCity.Text,
        //        Country = txtCusCountry.Text,
        //        Password = txtCusPassword.Text,
        //        Birthday = customerBirthday

        //    };
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message, "Get Customer");

        //}
        //return customer;
        //}
        private bool checkAllValid()
        {
            // check id
            string mess = "";
            //bool checkId = int.TryParse(txtFlId.Text, out int id);
            //if (checkId == false)
            //{
            //    mess = "id need to be int";
            //    MessageBox.Show(mess);
            //    return false;
            //}
            bool checkCate = false;
            if (categoryComboBox.SelectedItem is Category selectedCategory)
            {
                _cateId = selectedCategory.CategoryId;

                checkCate = true;

            }
            if (checkCate == false)
            {
                mess = "Cate need to be select";
                MessageBox.Show(mess);
                return false;
            }
            bool checkUnitPrice = decimal.TryParse(txtFlPrice.Text, out decimal price);
            if (checkUnitPrice == false)
            {
                mess = "Price need to be number";
                MessageBox.Show(mess);
                return false;
            }
            bool checkUnitStock = int.TryParse(txtFlUnitStock.Text, out int stock);
            if (checkUnitStock == false)
            {
                mess = "Stock need to be number";
                MessageBox.Show(mess);
                return false;
            }
            bool checkStatus = int.TryParse(txtFlStatus.Text, out int status);
            if (checkStatus == false || (!txtFlStatus.Text.Equals("0") && !txtFlStatus.Text.Equals("1")))
            {
                mess = "Status need to be number 0 or 1";
                MessageBox.Show(mess);
                return false;
            }

            bool checkSupplier = false;
            if (supplierCombox.SelectedItem is Supplier selectSupplier)
            {
                _supplierId = selectSupplier.SupplierId;

                checkSupplier = true;

            }
            if (checkSupplier == false)
            {
                mess = "Supplier need to be select";
                MessageBox.Show(mess);
                return false;
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool checkValid = checkAllValid();
            if (checkValid)
            {
                try
                {
                    FlowerBouquet flowerBouquet = GetFlowerBouquetObject();
                    flowerRepository.Update(flowerBouquet);

                    MessageBox.Show($"{flowerBouquet.FlowerBouquetName} updated successfully", "update pro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "update pro");
                }
            }
          


            //bool checkValid = checkAllValid();
            //if (checkValid)
            //{

            //    FlowerBouquet flowerBouquet = GetFlowerBouquetObject();
            //    bool check = checkDuplicateId(flowerBouquet);
            //    if (check == true)
            //    {
            //        _flower.InserFlower(flowerBouquet);
            //        MessageBox.Show("imsert fl success");

            //    }
            //    else
            //    {
            //        MessageBox.Show("aldread have fl with that id");

            //    }
            //}
        }

        private FlowerBouquet GetFlowerBouquetObject()
        {
            FlowerBouquet flowerBouquet = null;

            try
            {


                flowerBouquet = new FlowerBouquet()
                {
                    FlowerBouquetId = int.Parse(txtFlId.Text),

                    CategoryId = _cateId,
                    FlowerBouquetName = txtFlName.Text,
                    Description = txtFlDes.Text,
                    UnitPrice = decimal.Parse(txtFlPrice.Text),
                    UnitsInStock = int.Parse(txtFlUnitStock.Text),
                    FlowerBouquetStatus = byte.Parse(txtFlStatus.Text),
                    SupplierId = _supplierId

                };

            }





            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Flower");

            }
            return flowerBouquet;
        }

    }
}

