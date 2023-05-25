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
    /// Interaction logic for AdFlower_V2.xaml
    /// </summary>
    public partial class AdFlower_V2 : Window
    {
        IFlowerRepository _flower;
        ICategoryRepository categoryRepository;
        ISupplier supplierepository;
        int _cateId;
        int _supplierId;
        public AdFlower_V2()
        {
            InitializeComponent();
            _flower = new FlowerRepository();
            categoryRepository = new CategoryRepository();
            supplierepository = new SupplierRepository();
            SetCateAndSupplier();
        }



            private bool checkAllValid()
            {
                // check id
                string mess = "";
                bool checkId = int.TryParse(txtFlId.Text, out int id);
                if (checkId == false)
                {
                    mess = "id need to be int";
                    MessageBox.Show(mess);
                    return false;
                }
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

                FlowerBouquet flowerBouquet = GetFlowerBouquetObject();
                bool check = checkDuplicateId(flowerBouquet);
                if (check == true)
                {
                    _flower.InserFlower(flowerBouquet);
                    MessageBox.Show("imsert fl success");

                }
                else
                {
                    MessageBox.Show("aldread have fl with that id");

                }
            }

        }
        private bool checkDuplicateId(FlowerBouquet flowerBouquet)
        {
            FlowerBouquet fl = _flower.GetObjetByFlId(flowerBouquet);
            if (fl != null)
            {
                return false;
            }
            return true;
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


        private void SetCateAndSupplier()
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
    }
}
