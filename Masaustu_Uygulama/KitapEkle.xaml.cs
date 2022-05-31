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

namespace Masaustu_Uygulama
{
    /// <summary>
    /// Interaction logic for KitapEkle.xaml
    /// </summary>
    public partial class KitapEkle : Window
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void KtpKaydet_Click(object sender, RoutedEventArgs e)
        {
            lstbxVeriler.Items.Add(ad.Text + "  " + yazar.Text + " " + baskiyili.Text + " " + sayfasayisi.Text + "  " + dil.Text + " " +  yayinevi.Text + " " + aciklama.Text);
            sil();
        }

        private void lstbxVeri_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void temizle_Click(object sender, RoutedEventArgs e)
        {
            Temizle();
        }

        public void Temizle()
        {
            lstbxVeriler.Items.Clear();
        }
        public void sil()
        {
            ad.Clear();
            yazar.Clear();
            baskiyili.ClearValue(DatePicker.SelectedDateProperty);
            sayfasayisi.Clear();
            dil.ClearValue(ComboBox.SelectedItemProperty);
            yayinevi.Clear();
            aciklama.Clear();            
        }

        private void seciliSil_Click(object sender, RoutedEventArgs e)
        {
            lstbxVeriler.Items.Remove(lstbxVeriler.SelectedItem);
        }
    }
}
