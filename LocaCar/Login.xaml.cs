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
using LocaCar.Views;

namespace LocaCar
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            TelaPrincipal TlPrincipal = new TelaPrincipal();
            TlPrincipal.ShowDialog();
            
            //if (con.State == System.Data.ConnectionState.Open)
            //{
            //    con.Close();
            //}
            //if (VerifyUser(txtUsername.Text, txtPassword.Password))
            //{
            //    MessageBox.Show("Login Successfully", "Congrats", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }
        private bool VerifyUser(string username, string password)
        {
            //con.Open();
            //com.Connection = con;
            //com.CommandText = "select Status from Users where username='" + username + "' and password='" + password + "'";
            //dr = com.ExecuteReader();
            //if (dr.Read())
            //{
            //    if (Convert.ToBoolean(dr["Status"]) == true)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    return false;
            //}

            return true;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
