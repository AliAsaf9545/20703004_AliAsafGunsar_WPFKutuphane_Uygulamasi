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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Masaustu_Uygulama
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ktpEkle_Click(object sender, RoutedEventArgs e)
        {
            KitapEkle kt = new KitapEkle();
            kt.ShowDialog();
        }

        private void emanetKitap_Click(object sender, RoutedEventArgs e)
        {
            KayitliUyeler emktp = new KayitliUyeler();
            emktp.ShowDialog();
        }

        private void uyeEkle_Click(object sender, RoutedEventArgs e)
        {
            KayitliUyeler uyee = new KayitliUyeler();
            uyee.ShowDialog();
        }

        private void emanetListesi_Click(object sender, RoutedEventArgs e)
        {
            KayitliUyeler emanet = new KayitliUyeler();
            emanet.ShowDialog();
        }

        private void UyeListesi_Click(object sender, RoutedEventArgs e)
        {
            KayitliUyeler uyeListe = new KayitliUyeler();
            uyeListe.ShowDialog();
        }

        private void KitaplarBak_Click(object sender, RoutedEventArgs e)
        {
            KayitliKitap ktp = new KayitliKitap();
            ktp.ShowDialog();
        }

        private void UylereBak_Click(object sender, RoutedEventArgs e)
        {
            KayitliUyeler uye = new KayitliUyeler();
            uye.ShowDialog();
        }

        private void KitaplariListele_Click(object sender, RoutedEventArgs e)
        {
            KayitliKitap KtpL = new KayitliKitap();
            KtpL.ShowDialog();
        }
    }
}
