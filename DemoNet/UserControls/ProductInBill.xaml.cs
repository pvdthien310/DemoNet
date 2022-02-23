using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoNet.UserControls
{
    /// <summary>
    /// Interaction logic for ProductInBill.xaml
    /// </summary>
    public partial class ProductInBill : UserControl
    {
        public ProductInBill()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty
                Nameproperty = DependencyProperty.Register(
                    "NamePr", typeof(string), typeof(ProductInBill),
                    new UIPropertyMetadata("No text"));
        public static readonly DependencyProperty
                   Priceproperty = DependencyProperty.Register(
                       "PricePr", typeof(string), typeof(ProductInBill),
                       new UIPropertyMetadata("0"));
        public static readonly DependencyProperty
                   Amountproperty = DependencyProperty.Register(
                       "AmountPr", typeof(int), typeof(ProductInBill),
                       new UIPropertyMetadata(0));
        public static readonly DependencyProperty
                 Totalproperty = DependencyProperty.Register(
                     "TotalPr", typeof(string), typeof(ProductInBill),
                     new UIPropertyMetadata("0"));
        public static readonly DependencyProperty
                 Imageproperty = DependencyProperty.Register(
                     "ImageSource", typeof(string), typeof(ProductInBill),
                     new UIPropertyMetadata("https://dvdn247.net/wp-content/uploads/2020/07/avatar-mac-dinh-2.jpg"));

        // Button command 
        //test 
        public static readonly DependencyProperty
            ButtonCommandproperty = DependencyProperty.Register(
                "TestCommand", typeof(ICommand), typeof(ProductInBill),
                null);

        public static readonly DependencyProperty
          ButtonCommandParametertproperty = DependencyProperty.Register(
              "ButtonCommandParameter", typeof(object), typeof(ProductInBill),
              null);

        public object ButtonCommandParameter
        {
            get { return GetValue(ButtonCommandParametertproperty); }
            set { SetValue(ButtonCommandParametertproperty, value); }
        }

        public ICommand TestCommand
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (ICommand)GetValue(ButtonCommandproperty); }
            set { SetValue(ButtonCommandproperty, value); }
        }
        public string NamePr
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(Nameproperty); }
            set { SetValue(Nameproperty, value); }
        }
        public string PricePr
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(Priceproperty); }
            set { SetValue(Priceproperty, value); }
        }
        public int AmountPr
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (int)GetValue(Amountproperty); }
            set { SetValue(Amountproperty, value); }
        }
        public string TotalPr
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(Totalproperty); }
            set { SetValue(Totalproperty, value); }
        }
        public string ImageSource
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(Imageproperty); }
            set { SetValue(Imageproperty, value); }
        }
    }
}
