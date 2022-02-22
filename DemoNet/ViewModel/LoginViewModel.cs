using DemoNet.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DemoNet.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        private string _Username = "";
        public string Username { get => _Username; set { _Username = value; OnPropertyChanged(); } }
        private string _Password = "";
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }


        public LoginViewModel()
        {
            LoginCommand = new RelayCommand<LoginWindow>((p) => { return true; }, (p) => { Login(p); });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
        }

        public void Login(LoginWindow loginWindow)
        {
            //MessageBox.Show(Username + "   " + Password);
            if (DemoNet.Database.account.FindAccountByUsernameAndPassword(Username.Trim(),Password))
            {
                HomeWindow homeWindow = new HomeWindow();
                MessageBox.Show("Đăng nhập thành công!");
                loginWindow.Hide();
                homeWindow.ShowDialog();
                loginWindow.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ!");
            }
        }
    }
}
