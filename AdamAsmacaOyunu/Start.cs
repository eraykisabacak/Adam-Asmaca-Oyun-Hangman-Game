using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            Skor.skorList = new List<Skor>();
            Skor.startForm = this;
        }

        private void Start_Load(object sender, EventArgs e)
        {
            string dosya_yolu = @"../../Skor.txt";
            DosyaIslemleri.DosyaOkuma(dosya_yolu);
            Skor.ilk10Yazdir();
        }

        
        private void cb_Rastgele_Click(object sender, EventArgs e)
        {
            if (cb_Rastgele.Checked)
            {
                cb_Sayi.Enabled = false;
            }
            else
            {
                cb_Sayi.Enabled = true;
            }
           
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if ((cb_Rastgele.Checked) || (cb_Sayi.SelectedItem != null))
            {
                
                if(cb_Sayi.SelectedItem == null)
                {
                    Random random = new Random();
                    int rndSayi = random.Next(3, 6);
                    Form1 form1 = new Form1(random.Next(3,6),true);
                    form1.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    Form1 form1 = new Form1(int.Parse(cb_Sayi.SelectedItem.ToString()),false);
                    form1.Visible = true;
                    form1.gelenSayi = int.Parse(cb_Sayi.SelectedItem.ToString());
                    this.Visible = false;
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen Rastgeleyi veya Bir Sayı Giriniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KelimeEkleSil kelimeEkleSil = new KelimeEkleSil();
            kelimeEkleSil.Visible = true;
        }
    }
}
