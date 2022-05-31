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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Masaustu_Uygulama
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUsername.Text;
            string password = txtPassword.Password;
            con = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=dbWPF;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kullanici where Kullanici_Adi='"+ txtUsername.Text +"'And Sifre='"+ txtPassword.Password+"'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                MainWindow gecis = new MainWindow();
                gecis.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }

            con.Close();
        }
    }
}
