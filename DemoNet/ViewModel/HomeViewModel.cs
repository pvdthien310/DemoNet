using DemoNet.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace DemoNet.ViewModel
{
    class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            listProduct = new ObservableCollection<Product>(); // Danh sach chua cac san pham   
            Order = new ObservableCollection<OrderItem>(); // Danh sach chua cac item duoc chon
            totalOrder = 0; // Tong tien cua order hien tai
            listProduct = InitProductList(DemoNet.Database.product.GetProducts()); // Goi database de lay du lieu

            // Thao tác thanh toán đơn hàng, cập nhập lên database
            Btncommand = new RelayCommand<object>(
                (obj) => Order.Count == 0 || Order == null ? false : true,
                (obj) =>
                {
                    if (OrderOwner == null || PhoneNumber == null || OrderOwner.Length == 0 || PhoneNumber.Length == 0)
                    {
                        MessageBox.Show("Chưa nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                    if (DemoNet.Database.order.AddOrders(new Model.Order(Order, totalOrder, OrderOwner, PhoneNumber)))
                    {
                        Order.Clear();
                        TotalOrder = 0;
                        MessageBox.Show("Thanh toán thành công đơn hàng!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        OrderOwner = "";
                        PhoneNumber = "";
                    }
                    else
                    {
                        MessageBox.Show("Không có sản phẩm!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                    );


            // Thao tác thêm 1 sản phẩm vào trong order
            Btncommand2 = new RelayCommand<object>(
                (obj) => true,
                (obj) =>
                {
                    Product temp = obj as Product;
                    if (temp == null) return;
                    if (Order.Count == 0)
                        Order.Add(new OrderItem(temp));
                    else
                    {
                        int count = 0;
                        for (int i = 0; i < Order.Count; i++)
                        {
                            if (Order[i].Name == temp.Name)
                            {
                                Order[i].Amount = Order[i].Amount + 1;
                                break;
                            }
                            count++;
                        }
                        if (count == Order.Count)
                            Order.Add(new OrderItem(temp));
                    }
                    //tinh tong Order
                    TotalOrder = 0;
                    foreach (OrderItem ite in Order)
                        TotalOrder += ite.Total;
                });

            // Xóa 1 sản phẩm ra khỏi Order hiện tại
            DeleteCommand = new RelayCommand<object>(
             (obj) => true,
             (obj) =>
             {
                 OrderItem temp = obj as OrderItem;
                 if (temp == null) return;

                 for (int i = 0; i < Order.Count; i++)
                 {
                     if (Order[i].Name == temp.Name)
                     {
                         Order[i].Amount = Order[i].Amount - 1;
                         if (Order[i].Amount == 0)
                             Order.RemoveAt(i);
                         break;
                     }
                 }
                 TotalOrder = 0;
                 foreach (OrderItem ite in Order)
                     TotalOrder += ite.Total;
             });

        }


        #region Init list
        public ObservableCollection<Order> InitOrderList(List<Order> list)
        {
            ObservableCollection<Order> result = new ObservableCollection<Order>();
            foreach (Order ite in list)
                result.Add(ite);
            return result;
        }
        public ObservableCollection<Product> InitProductList(List<Product> list)
        {
            ObservableCollection<Product> result = new ObservableCollection<Product>();
            foreach (Product ite in list)
                result.Add(ite);
            return result;
        }
        #endregion

        #region Init variables
        private ObservableCollection<Product> listProduct;
        public ObservableCollection<Product> ListProduct
        {
            get { return listProduct; }
            set
            {
                listProduct = value;
            }
        }
        private ObservableCollection<Order> listOrder;
        public ObservableCollection<Order> ListOrder
        {
            get { return listOrder; }
            set
            {
                listOrder = value;
            }
        }
        private ObservableCollection<OrderItem> order;
        public ObservableCollection<OrderItem> Order
        {
            get { return order; }
            set
            {
                order = value;
            }
        }
        private string orderOwner;
        public string OrderOwner
        {
            get { return orderOwner; }
            set
            {
                orderOwner = value;
                OnPropertyChanged("OrderOwner");
            }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }
        private Product selected;
        public Product Selected
        {
            get { return selected; }
            set
            {
                selected = value;
            }
        }
        private int totalOrder;
        public int TotalOrder
        {
            get { return totalOrder; }
            set
            {
                totalOrder = value;
                OnPropertyChanged("TotalOrder");
            }
        }

        public ICommand Btncommand { get; set; }
        public ICommand Btncommand2 { get; set; }
        public ICommand Btncommand3 { get; set; }
        public ICommand DeleteCommand { get; set; }
        #endregion
    }
}
