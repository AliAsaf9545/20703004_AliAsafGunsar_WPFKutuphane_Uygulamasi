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
    /// Interaction logic for KayitliUyeler.xaml
    /// </summary>
    public partial class KayitliUyeler : Window
    {
        public KayitliUyeler()
        {
            InitializeComponent();
            List<Uyeler> Uye = new List<Uyeler>();
            Uye.Add(new Uyeler() { ID = 1, Adı = "Çağdaş", Soyadı = "Balkay", Alis = new DateTime(2022, 7, 23), Teslim = new DateTime(2022, 8, 7), mail = "cagdas@gmail.com", Telefon = 0544656583 });
            Uye.Add(new Uyeler() { ID = 2, Adı = "Şehmus", Soyadı = "Çakar", Alis = new DateTime(2022, 1, 17), Teslim = new DateTime(2022, 2, 5), mail = "sehmus@gmail.com", Telefon = 0544656583 });
            Uye.Add(new Uyeler() { ID = 3, Adı = "Yunus Emre", Soyadı = "Doğan", Alis = new DateTime(2022, 11, 20), Teslim = new DateTime(2022, 12, 5), mail = "yunus@gmail.com", Telefon = 0544656583 });
            Uye.Add(new Uyeler() { ID = 4, Adı  = "Burhan", Soyadı = "Mutlu", Alis = new DateTime(2022, 1, 17), Teslim = new DateTime(2022, 2, 6), mail = "burhan@gmail.com", Telefon = 0544656583 });
            Uye.Add(new Uyeler() { ID = 5, Adı = "Elvan", Soyadı = "Ekilsin", Alis = new DateTime(2022, 1, 10), Teslim = new DateTime(2022, 1, 25), mail = "elvan@gmail.com", Telefon = 0544656583 });
            Uye.Add(new Uyeler() { ID = 6, Adı = "Neslihan", Soyadı = "Doğan", Alis = new DateTime(2022, 3, 17), Teslim = new DateTime(2022, 4, 5), mail = "neslihan@gmail.com", Telefon = 0544656583 });
            Uye.Add(new Uyeler() { ID = 7, Adı = "Ali", Soyadı = "Günşar", Alis = new DateTime(2022, 8, 17), Teslim = new DateTime(2022, 9,30), mail = "ali@gmail.com", Telefon = 0544656583 });
            Uye.Add(new Uyeler() { ID = 8, Adı = "Feyza", Soyadı = "Mengüverdi", Alis = new DateTime(2022, 3, 10), Teslim = new DateTime(2022, 3, 25),  mail = "feyza@gmail.com", Telefon = 0544656583 });
            Uye.Add(new Uyeler() { ID = 9, Adı = "Asaf", Soyadı = "Günşar", Alis = new DateTime(2022, 10, 7), Teslim = new DateTime(2022, 10, 22), mail = "asaf@gmail.com", Telefon = 0544656583 });

            kayitliUye.ItemsSource = Uye;
        }

        public class Uyeler
        {
            public int ID { get; set; }

            public string Adı { get; set; }

            public string Soyadı { get; set; }

            public string mail { get; set; }

            public int Telefon { get; set; }

            public DateTime Alis { get; set; }

            public DateTime Teslim { get; set; }

        }
    }
}
