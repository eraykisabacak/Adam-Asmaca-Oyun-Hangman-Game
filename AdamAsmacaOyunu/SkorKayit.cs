using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdamAsmacaOyunu
{
    public partial class SkorKayit : Form
    {
        public SkorKayit()
        {
            InitializeComponent();
        }

        
        public int yeniSkor = 0;
        List<Tuple<string, int>> list = new List<Tuple<string, int>>();
        private void gonder_Click(object sender, EventArgs e)
        {
            
            string dosya_yolu = @"../../Skor.txt";

            // Dosya Var mı
            if (!File.Exists(dosya_yolu)){
                File.Create("../../Skor.txt");
            }
            else
            {
                string[] skorTablosu = new string[10];
                string[] puan = new string[10]; 

                // Adiniz textbox'ı boş mu
                if (adiniz.Text != "")
                {
                    DosyaIslemleri.SkorKayitDosyaOkuma(dosya_yolu, adiniz.Text, yeniSkor);
                    DosyaIslemleri.SkorKayitDosyayaYazma(dosya_yolu);
                    
                    MessageBox.Show("Paunınız Kayıt Edildi.");
                    Start start = new Start();
                    start.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Bir İsim Giriniz");
                }
            }
        }
    }
}
