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
    public partial class Form1 : Form
    {
        public int gelenSayi;
        public static int kalanHakki;
        // Önceki Harfleri kontrol etmek için list
        List<string> basilanHarfler = new List<string>();
        static int skor = 0;
        static int skorArti = 0;
        static int skorEksi = 0;
        string kelime;
        char[] kelimeTek;
        int acilanKelimeler = 0;
        int kacTekrar = 0;
        bool kayit = false;
        
        // Resimler
        PictureBox[] picture = new PictureBox[7];

        public Form1(int gelenSayi = 3 , bool rastgele = false)
        {
            InitializeComponent();
            if (rastgele)
            {
                Random random = new Random();
                           
                this.gelenSayi = random.Next(3, 6);
            }
            else
            {
                this.gelenSayi = gelenSayi;
            }

            // Kutuları Gelen sayı kadar basıyor.
            for (int sayi = 0; sayi < this.gelenSayi; sayi++)
            {
                TextBox txt = (TextBox)this.Controls["textBox" + sayi];
                txt.Visible = true;
            }

            // Deneme Hakkı
            
            kalanHakki = this.gelenSayi + 2;
            denemeHakkiSayacı(kalanHakki);
            
            lbl_Hak.Text = "Kalan Hakkınız: " + kalanHakki.ToString();


        }

        public void denemeHakkiSayacı(int denemeHakki)
        {
            lbl_Hak.Text = "Kalan Hakkınız: " + denemeHakki.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(this.gelenSayi == 3)
            {
                skorArti = 20;
                skorEksi = -7;
            }
            else if(this.gelenSayi == 4)
            {
                skorArti = 15;
                skorEksi = -5;
            }
            else if(this.gelenSayi == 5)
            {
                skorArti = 12;
                skorEksi = -2;
            }

            string dosya_yolu = @"../../Kelimeler.txt";
            if (!File.Exists(dosya_yolu))
            {
                MessageBox.Show("Kelimeler Bulunmuyor. Öncelikle Kelime Ekleyin");
                this.Visible = false;
                this.Close();
                Start start = new Start();
                start.Visible = true;
                return ;
            }
            
            List<string> kelimeler = DosyaIslemleri.KelimeOkuma(dosya_yolu,gelenSayi);

            if (kelimeler.Count == 0)
            {
                MessageBox.Show("Kelimeler dosyanız boştur lütfen ekleyiniz");
                this.Visible = false;
                this.Close();
                Start start = new Start();
                start.Visible = true;
                return;
            }
            
            int kelimeler_sayisi = kelimeler.Count;
            Random random = new Random();
            if (kelimeler_sayisi < 2)
            {
                kelime = kelimeler[0];
            }
            else
            {
                kelime = kelimeler[random.Next(1, kelimeler_sayisi)];
            }      
            label2.Text = kelime.ToString();
            kelimeTek = kelime.ToCharArray();
            

            // Resimleri bir diziye ekle            
            for(int i = 1; i <= picture.Length; i++)
            {
                PictureBox resim = (PictureBox)this.Controls["adam" + (i)];
                picture[i - 1] = resim;
            }


        }

        int kacKere;
        static int acilanResimler = 0;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Q || e.KeyCode == Keys.W || e.KeyCode == Keys.E || e.KeyCode == Keys.R || e.KeyCode == Keys.T || e.KeyCode == Keys.Y ||
                e.KeyCode == Keys.U || e.KeyCode == Keys.I || e.KeyCode == Keys.O || e.KeyCode == Keys.P || e.KeyCode == Keys.G || e.KeyCode == Keys.A ||
                e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.F || e.KeyCode == Keys.G || e.KeyCode == Keys.H || e.KeyCode == Keys.J ||
                e.KeyCode == Keys.K || e.KeyCode == Keys.L || e.KeyCode == Keys.Z || e.KeyCode == Keys.X || e.KeyCode == Keys.C || e.KeyCode == Keys.V ||
                e.KeyCode == Keys.B || e.KeyCode == Keys.N || e.KeyCode == Keys.M)
            {
                label1.Text += " " + (e.KeyCode.ToString().ToUpper());
                string bastigiHarf = e.KeyCode.ToString();

                //Bastığı harfler

                // Verilan Hakkı Aşmamış Olması Lazım
                if (basilanHarfler.Count > 0)
                {
                    kacKere = basilanHarfler.Count;
                    for (int i = 0; i < kacKere; i++)
                    {
                        // Önce basılıp basılmadığının kontrolü
                        if (bastigiHarf.Equals(basilanHarfler[i]))
                        {
                            MessageBox.Show("Bastığınız harfi daha önce bastınız " + bastigiHarf);
                            return;
                        }
                    }
                    bool varMi2 = false;
                    // Basılan tuşları kutucuklarda gösterme
                    for (int i = 0; i < this.kelime.Length; i++)
                    {
                        if (bastigiHarf.Equals(kelimeTek[i].ToString()))
                        {
                            TextBox txt = (TextBox)this.Controls["textBox" + i];
                            txt.Text = e.KeyCode.ToString();
                            acilanKelimeler++;
                            kacTekrar++;
                            basilanHarfler.Add(e.KeyCode.ToString().ToUpper());
                            varMi2 = true;
                        }
                    }

                    if (!varMi2)
                    {
                        basilanHarfler.Add(e.KeyCode.ToString().ToUpper());
                        acilanResimler++;
                        kalanHakki--;
                        skor += skorEksi;
                        lblSkor.Text = skor.ToString();
                        picture[acilanResimler - 1].Visible = true;
                    }
                    else
                    {
                        skor += skorArti * kacTekrar;
                        lblSkor.Text = skor.ToString();
                        kacTekrar = 0;
                    }
                    // Bütün Kelimeler Açıldığında Tebrikler mesajı
                    if (acilanKelimeler == this.gelenSayi)
                    {
                        MessageBox.Show("Tebrikler Skorunuz:" + skor);
                        SkorKayit skorKayit = new SkorKayit();
                        kayit = true;
                        skorKayit.yeniSkor = skor;
                        skorKayit.Visible = true;
                        this.Close();
                    }
                }
                else
                {
                    bool varMi = false;
                    for (int i = 0; i < this.kelime.Length; i++)
                    {
                        if (bastigiHarf.Equals(kelimeTek[i].ToString()))
                        {
                            TextBox txt = (TextBox)this.Controls["textBox" + i];
                            txt.Text = e.KeyCode.ToString();
                            acilanKelimeler++;
                            varMi = true;
                            kacTekrar++;
                            basilanHarfler.Add(e.KeyCode.ToString().ToUpper());
                        }
                    }
                    if (!varMi)
                    {
                        basilanHarfler.Add(e.KeyCode.ToString().ToUpper());
                        acilanResimler++;
                        picture[0].Visible = true;
                        kalanHakki--;
                        skor += skorEksi;
                        lblSkor.Text = skor.ToString();
                    }
                    else
                    {
                        skor += skorArti * kacTekrar;
                        kacTekrar = 0;
                        lblSkor.Text = skor.ToString();
                    }

                }

                // Deneme Hakkını indir

                denemeHakkiSayacı(kalanHakki);

                if (kalanHakki < 1)
                {
                    MessageBox.Show("Oyun Bitti");
                    for (int i = 1; i <= picture.Length; i++)
                    {
                        picture[i - 1].Visible = true;
                    }
                    MessageBox.Show("Üzgünüm Skorunuz: " + skor + "Kelime : " + kelime);
                    SkorKayit skorKayit = new SkorKayit();
                    skorKayit.yeniSkor = skor;
                    skorKayit.Visible = true;
                    this.Close();
                }

                if (acilanKelimeler == this.gelenSayi)
                {
                    if (!kayit)
                    {
                        MessageBox.Show("Tebrikler Skorunuz:" + skor);
                        SkorKayit skorKayit = new SkorKayit();
                        skorKayit.yeniSkor = skor;
                        skorKayit.Visible = true;
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen harflere basınız");
            }
        }
    }
}
