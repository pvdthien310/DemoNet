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
    /// Interaction logic for UserInfo.xaml
    /// </summary>
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        // Cho textBox
        public static readonly DependencyProperty
                    TextBoxText1property = DependencyProperty.Register(
                        "TextBoxText1", typeof(string), typeof(UserInfo),
                        new UIPropertyMetadata("No text"));
        public static readonly DependencyProperty
                   TextBoxText2property = DependencyProperty.Register(
                       "TextBoxText2", typeof(string), typeof(UserInfo),
                       new UIPropertyMetadata("No text"));

        public string TextBoxText1
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(TextBoxText1property); }
            set { SetValue(TextBoxText1property, value); }
        }
        public string TextBoxText2
        {
            // Property này sẽ truy xuất đến DependencyProperty trên kia
            get { return (string)GetValue(TextBoxText2property); }
            set { SetValue(TextBoxText2property, value); }
        }
    }
}
