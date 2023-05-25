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
        IOrderDetailRepository orderDetailRepository;
        IOderRepository orderRepository;    
        private int _orderId;
        int _flId;
        public ADInsertOrderDetail(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            orderDetailRepository = new OrderDetailRepository();
            orderRepository = new OrderRepository();
            flowerRepository = new FlowerRepository(); 
            SetFlower();
            txtOrderId.Text = orderId.ToString();
        }
        private void SetFlower()
        {
            List<FlowerBouquet> flowerBouquets = new List<FlowerBouquet>();
            flowerBouquets = flowerRepository.GetFlowerBouquets();




            cbFlower.ItemsSource = flowerBouquets;




        }
        private bool checkAllValid()
        {
            //// check id
            string mess = "";
            //bool checkId = int.TryParse(txtOrId.Text, out int id);
            //if (checkId == false)
            //{
            //    mess = "id need to be int";
            //    MessageBox.Show(mess);
            //    return false;
            //}
            bool checkFlo = false;
            if (cbFlower.SelectedItem is FlowerBouquet selectFlower)
            {
                _flId = selectFlower.FlowerBouquetId;

                checkFlo = true;

            }
            if (checkFlo == false)
            {
                mess = "Flower need to be select";
                MessageBox.Show(mess);
                return false;
            }
            //bool checkSupplier = false;
            //if (supplierCombox.SelectedItem is Supplier selectSupplier)
            //{
            //    _supplierId = selectSupplier.SupplierId;

            //    checkSupplier = true;

            //}
            //if (checkSupplier == false)
            //{
            //    mess = "Supplier need to be select";
            //    MessageBox.Show(mess);
            //    return false;
            //}

            bool checkUnitPrice = decimal.TryParse(txtUnitPrice.Text, out decimal price);
            if (checkUnitPrice == false)
            {
                mess = "Price need to be number";
                MessageBox.Show(mess);
                return false;
            }
            bool checkQuanity = decimal.TryParse(txtQuantity.Text, out decimal quatity);
            if (checkQuanity == false && quatity < 0)
            {
                mess = "Quantity need to be number and quantity >= 0";
                MessageBox.Show(mess);
                return false;
            }
            bool checkDiscount = decimal.TryParse(txtDiscount.Text, out decimal discount);
            if (checkDiscount == false && discount < 0)
            {
                mess = "Quantity need to be number and discount >= 0";
                MessageBox.Show(mess);
                return false;
            }
            //bool checkDbOrDate = int.TryParse(dbOrDate.Text, out int orDate);
            //bool checkDbOrDate = false;

            //if (checkDbOrDate == false)
            //{
            //    mess = "Order Date need to be number";
            //    MessageBox.Show(mess);
            //    return false;
            //}

            //DateTime? checkDbOrDate = dbOrDate.SelectedDate;

            //if (!checkDbOrDate.HasValue)
            //{
            //    //DateTime dateValue = checkDbOrDate.Value;
            //    //Console.WriteLine(dateValue);
            //    mess = "Order date need to be selected";
            //    MessageBox.Show(mess);
            //    return false;
            //}

            //bool checkStatus = int.TryParse(txtFlStatus.Text, out int status);
            //if (checkStatus == false || (!txtFlStatus.Text.Equals("0") && !txtFlStatus.Text.Equals("1")))
            //{
            //    mess = "Status need to be number 0 or 1";
            //    MessageBox.Show(mess);
            //    return false;
            //}

            //bool checkSupplier = false;
            //if (supplierCombox.SelectedItem is Supplier selectSupplier)
            //{
            //    _supplierId = selectSupplier.SupplierId;

            //    checkSupplier = true;

            //}
            //if (checkSupplier == false)
            //{
            //    mess = "Supplier need to be select";
            //    MessageBox.Show(mess);
            //    return false;
            //}
            return true;
        }
        public decimal GetTotalByOrderId(int _orderId)
        {
            return orderDetailRepository.GetTotalSumOrderDetail(_orderId);  
        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            bool checkValid = checkAllValid();
            if (checkValid)
            {

                OrderDetail orderDetail = GetOrderDetailObject();
                int orderId = orderDetail.OrderId;  
                bool check = checkDupliOderIdAndFlId(orderDetail);
                if (check == true)
                {
                    orderDetailRepository.InsertOrderDetail(orderDetail);
                    // update total 
                    //orderRepository.GetObjectByOrId(orderId);
                    decimal totalUpdate = GetTotalByOrderId(_orderId);
                    Order order = orderRepository.GetObjectByOrId(orderId);
                    order.Total = totalUpdate;
                    orderRepository.Update(order);

                    // update total
                    MessageBox.Show("insert orderdetail success");

                }
                else
                {
                    MessageBox.Show("aldread have orderdeatil with that order id and flower id");

                }

              

              
            }
        }

        private bool checkDupliOderIdAndFlId(OrderDetail orderDetail)
        {
            OrderDetail ord = orderDetailRepository.GetOrderDetailByOderIdAndFlId(orderDetail);
            if (ord != null)
            {
                return false;
            }
            return true;
        }
        private OrderDetail GetOrderDetailObject()
        {
            OrderDetail orderDetail = null;
            
            int _unitQuantity = 0;
            double _discount = 0;
            if(txtDiscount.Text.Length != 0)
            {
              
                _discount = double.Parse(txtDiscount.Text);
            }
          
            if (txtQuantity.Text.Length != 0)
            {
                _unitQuantity = int.Parse(txtQuantity.Text);
            }

            try
            {


                orderDetail = new OrderDetail()
                {
                    OrderId = int.Parse(txtOrderId.Text),

                    FlowerBouquetId =_flId,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = _unitQuantity,
                    Discount = _discount
                    
                    
                };

               

            }





            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get orderdetail");

            }
            return orderDetail;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{GetTotalByOrderId(4002)}");
        }
    }
}
