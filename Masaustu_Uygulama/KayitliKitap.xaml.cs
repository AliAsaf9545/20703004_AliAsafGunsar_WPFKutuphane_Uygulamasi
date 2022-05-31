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
    /// Interaction logic for KayitliKitap.xaml
    /// </summary>
    public partial class KayitliKitap : Window
    {
        public KayitliKitap()
        {
            InitializeComponent();
            List<Kitap> Ktp = new List<Kitap>();
            Ktp.Add(new Kitap() { ID = 1, Name = "İntibah", Tarihi = new DateTime(1874, 7, 23), Yazar = "Namık Kemal", Tür = "Roman", Sayfa= 250, Mevcut ="Evet"});  
            Ktp.Add(new Kitap() { ID = 2, Name = "Masumiyet Müzesi", Tarihi = new DateTime(2008, 1, 17), Yazar = "Orhan Pamuk", Tür = "Roman", Sayfa = 352, Mevcut = "Evet" });
            Ktp.Add(new Kitap() { ID = 3, Name = "Sergüzeşt", Tarihi = new DateTime(2005, 11, 20), Yazar = "Samipaşazade Sezai", Tür = "Roman", Sayfa = 263, Mevcut = "Evet" });
            Ktp.Add(new Kitap() { ID = 4, Name = "Seyehatname", Tarihi = new DateTime(1610, 1, 17), Yazar = "Evliya Çelebi", Tür = "Gezi Yazısı", Sayfa = 315, Mevcut = "Evet" });
            Ktp.Add(new Kitap() { ID = 5, Name = "Doğu Ekspresinde Cinayet", Tarihi = new DateTime(1934, 1, 17), Yazar = " Agatha Christie", Tür = "Polisiye", Sayfa = 210, Mevcut = "Evet" });
            Ktp.Add(new Kitap() { ID = 6, Name = "Yabancı", Tarihi = new DateTime(1934, 1, 17), Yazar = "Stephan King", Tür = "Polisiye", Sayfa = 378, Mevcut = "Evet" });
            Ktp.Add(new Kitap() { ID = 7, Name = "Hayvan Çiftliği", Tarihi = new DateTime(1945, 8, 17), Yazar = "George Orwell", Tür = "Roman", Sayfa = 158, Mevcut = "Evet" });
            Ktp.Add(new Kitap() { ID = 8, Name = "Simyacı", Tarihi = new DateTime(2014, 3, 10), Yazar = "Paulo Coelho", Tür = "Fantastik", Sayfa = 184, Mevcut = "Evet" });
            Ktp.Add(new Kitap() { ID = 9, Name = "Dönüşüm", Tarihi = new DateTime(1915, 10, 7), Yazar = "Fransız Kafka", Tür = "Fantastik", Sayfa = 104, Mevcut = "Evet" });

            Books.ItemsSource = Ktp;

        }
        public class Kitap
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public string Yazar { get; set; }

            public DateTime Tarihi { get; set; }

            public string Tür { get; set; }
            public string Mevcut { get; set; }

            public int Sayfa { get; set; }
        }
    }
}
 