using KutuphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class Form1 : Form
    {
        List<Kisi>kisilerim=new List<Kisi>();
        List<Kitap>kitaplarim=new List<Kitap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";

            kullaniciAdi = txt_kullaniciAdi.Text;
            sifre = txt_sifre.Text;

            bool kontrol = false;

            foreach(Kisi kisi in kisilerim)
            {
                if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "admin")
                {
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim,kitaplarim);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if(kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    UyeSayfasi uyeSayfasi = new UyeSayfasi(kitaplarim);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }                
            }

            if (!kontrol)
            {
                MessageBox.Show("Bir hata oluştu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1,"Enes","Bayram",DateTime.Now,"enes","1","admin"));
            kisilerim.Add(new Kisi(2,"Yakup","Reçber",DateTime.Now,"yakup","2","uye"));
            kisilerim.Add(new Kisi(3,"Bilal","Çamur",DateTime.Now,"bilal","3", "uye"));
            kisilerim.Add(new Kisi(4,"Yasin","Yazıcı",DateTime.Now,"yasin","4","uye"));

            kitaplarim.Add(new Kitap(1, "içimizdeki şeytan", "sebahattain ali", "türkçe", "yapı kredi yayınları", "roman", 100, 250, 2016));
            kitaplarim.Add(new Kitap(2, "tutunamayanlar", "oğuz atay", "türkçe", "iletişim yayınları", "roman", 300, 750, 2015));
            kitaplarim.Add(new Kitap(3, "uçurtma avcısı", "khaled hosseini", "ingilizce", "everest yayınları", "roman", 300, 550, 2010));
            kitaplarim.Add(new Kitap(4, "küçük prens", "antoine de saint exupery", "türkçe", "can çocukyayınları", "roman", 50, 60, 2013));
            kitaplarim.Add(new Kitap(5, "kürk mantolu madonna", "m.Berk cercik", "türkçe", "akbank yayınları", "roman", 1100, 2250, 2009));
        }
    }
}
