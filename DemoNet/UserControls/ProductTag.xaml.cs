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
    /// Interaction logic for ProductTag.xaml
    /// </summary>
    public partial class ProductTag : UserControl
    {
        public ProductTag()
        {
            InitializeComponent();
        }

        // Cho button
        public static readonly DependencyProperty
            ButtonContentproperty = DependencyProperty.Register(
                "ButtonContent", typeof(object), typeof(ProductTag),
                new UIPropertyMetadata("Action"));
        public static readonly DependencyProperty
                   ButtonVisibleTextproperty = DependencyProperty.Register(
                       "ButtonVisible", typeof(string), typeof(ProductTag),
                       new UIPropertyMetadata("Hidden"));


        // Cho textBox
        public static readonly DependencyProperty
                    TextBoxTextproperty = DependencyProperty.Register(
                        "TextBoxText", typeof(string), typeof(ProductTag),
                        new UIPropertyMetadata("No text"));
        // Cho Image
        public static readonly DependencyProperty
                   Imageproperty = DependencyProperty.Register(
                       "ImageSource", typeof(string), typeof(ProductTag),
                       new UIPropertyMetadata("https://dvdn247.net/wp-content/uploads/2020/07/avatar-mac-dinh-2.jpg"));
        // Cho header
        // Cho Image
        public static readonly DependencyProperty
                   Headerproperty = DependencyProperty.Register(
                       "HeaderContent", typeof(string), typeof(ProductTag),
                       new UIPropertyMetadata("Null"));

        //test 
        public static readonly DependencyProperty
            ButtonCommandproperty = DependencyProperty.Register(
                "TestCommand", typeof(ICommand), typeof(ProductTag),
                null);

        public static readonly DependencyProperty
          ButtonCommandParametertproperty = DependencyProperty.Register(
              "ButtonCommandParameter", typeof(object), typeof(ProductTag),
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

        // Cho button
        public object ButtonContent
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return GetValue(ButtonContentproperty); }
            set { SetValue(ButtonContentproperty, value); }
        }

        public string ButtonVisible
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(ButtonVisibleTextproperty); }
            set { SetValue(ButtonVisibleTextproperty, value); }
        }

        // Cho textBox
        public string TextBoxText
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(TextBoxTextproperty); }
            set { SetValue(TextBoxTextproperty, value); }
        }
        // Cho Image
        public string ImageSource
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(Imageproperty); }
            set { SetValue(Imageproperty, value); }
        }
        // Cho header
        public string HeaderContent
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(Headerproperty); }
            set { SetValue(Headerproperty, value); }
        }

    }
}
