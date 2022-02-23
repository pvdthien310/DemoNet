using DemoNet.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace DemoNet.ViewModel
{
    class BillViewModel:BaseViewModel
    {
        public BillViewModel()
        {
            listOrder = InitOrderList(DemoNet.Database.order.GetOrders());
            LoadCommand = new RelayCommand<object>(
             (obj) => true,
             (obj) =>
             {
                 ListOrder = InitOrderList(DemoNet.Database.order.GetOrders());
             }
                 );
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

        private ObservableCollection<Order> listOrder;
        public ObservableCollection<Order> ListOrder
        {
            get { return listOrder; }
            set
            {
                listOrder = value;
                OnPropertyChanged("ListOrder");
            }
        }

        public ICommand LoadCommand { get; set; }
    }
}
