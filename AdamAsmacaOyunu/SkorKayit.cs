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
                List<SkorTablosu> skorTablo = new List<SkorTablosu>(); 
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
                    FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.ReadWrite);
                    StreamReader sr = new StreamReader(fs);
                    string yazi = sr.ReadLine();

                    while (yazi != null)
                    {
                        string[] parca = yazi.Split('|');
                        Console.WriteLine(" Puan :" + parca[1]+"aa");
                        skorTablo.Add(new SkorTablosu(parca[0], int.Parse(parca[1])));
                        yazi = sr.ReadLine();
                    }
                    fs.Flush();
                    sr.Close();
                    fs.Close();
                    
                    skorTablo.Add(new SkorTablosu(adiniz.Text, yeniSkor));
                    skorTablo=skorTablo.OrderBy(x=>x.Puan).ToList();
                    skorTablo.Reverse();


                    FileStream fs2 = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs2);

                    for(int i = 0; i < skorTablo.Count; i++)
                    {
                        sw.WriteLine(skorTablo[i].Ad + "|" + skorTablo[i].Puan);
                    }
                    sw.Flush();
                    fs2.Close();
                    //DosyaIslemleri.DosyayaYazma(dosya_yolu);

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
