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
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getkitapid(), kitap.getkitapIsim(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getbasimYili());
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int KitapID=Convert.ToInt32(txt_kitapID.Text);
            Kitap hedefKitap = null;

            foreach(Kitap kitap in kitaplarim)
            {
                if (kitap.getkitapid() == KitapID)
                {
                    hedefKitap = kitap;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKitap.getkitapid(), hedefKitap.getkitapIsim(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getbasimYili());
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow); 
            foreach(Kitap hedefKitap in kitaplarim)
            {
                dataGridView1.Rows.Add(hedefKitap.getkitapid(), hedefKitap.getkitapIsim(), hedefKitap.getkitapYazar(), hedefKitap.getkitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getbasimYili());
            }
        }
    }
}
