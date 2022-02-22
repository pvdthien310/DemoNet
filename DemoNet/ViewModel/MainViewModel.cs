using DemoNet.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace DemoNet.ViewModel
{
    class MainViewModel
    {
        public ICommand SwitchTabCommand { get; set; }
        public ICommand GetUidCommand { get; set; }

        private string uid;
        public MainViewModel()
        {
            SwitchTabCommand = new RelayCommand<HomeWindow>((p) => { return true; }, (p) => { SwitchTab(p); });
            GetUidCommand = new RelayCommand<Button>((p) => { return true; }, (p) => { uid = p.Uid; });
        }
        public void SwitchTab(HomeWindow homeWindow)
        {
            int index = int.Parse(uid);

            homeWindow.Home.Visibility = System.Windows.Visibility.Hidden;
            homeWindow.Bill.Visibility = System.Windows.Visibility.Hidden;


            switch (index)
            {
                case 1:
                    homeWindow.Home.Visibility = System.Windows.Visibility.Visible;
                    break;
                case 2:
                    homeWindow.Bill.Visibility = System.Windows.Visibility.Visible;
                    break;
            }
        }
    }
}
