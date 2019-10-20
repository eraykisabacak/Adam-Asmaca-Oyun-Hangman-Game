using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    class DosyaIslemleri
    {
        public static void DosyaOkuma(string dosya_yolu)
        {
            if (!File.Exists(dosya_yolu))
            {
                File.Create(dosya_yolu);
                MessageBox.Show("Dosya Yoktur Şimdi Oluşturulmuştur.");
            }
            else
            {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string yazi = sr.ReadLine();
                int dongu = 0;

                while (yazi != null)
                {
                    dongu++;
                    string[] parca = yazi.Split('|');
                    Skor.skorList.Add(new Skor(parca[0], int.Parse(parca[1])));

                    yazi = sr.ReadLine();
                    if (dongu == 10)
                    {
                        break;
                    }
                }
                fs.Flush();
                sr.Close();
                fs.Close();
                
            }
        }

        public string ad { get; set; }
        public int skor { get; set; }

        public static void SkorKayitDosyaOkuma(string dosya_yolu,string adiniz, int yeniSkor)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();

            while (yazi != null)
            {
                string[] parca = yazi.Split('|');
                Console.WriteLine(" Puan :" + parca[1] + "aa");
                SkorTablosu.skorTablo.Add(new SkorTablosu(parca[0], int.Parse(parca[1])));
                yazi = sr.ReadLine();
            }
            fs.Flush();
            sr.Close();
            fs.Close();

            SkorTablosu.skorTablo.Add(new SkorTablosu(adiniz, yeniSkor));
            SkorTablosu.skorTablo = SkorTablosu.skorTablo.OrderBy(x => x.Puan).ToList();
            SkorTablosu.skorTablo.Reverse();
        }
        

        public static void SkorKayitDosyayaYazma(string dosya_yolu)
        {
            FileStream fs2 = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);

            for (int i = 0; i < SkorTablosu.skorTablo.Count; i++)
            {
                sw.WriteLine(SkorTablosu.skorTablo[i].Ad + "|" + SkorTablosu.skorTablo[i].Puan);
            }
            sw.Flush();
            fs2.Close();
        }

        public static List<string> KelimeOkuma(string dosya_yolu,int gelenSayi)
        {
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
 
            string yazi = sr.ReadLine();

            List<string> kelimeler = new List<string>();

            while (yazi != null)
            {
                if (yazi.Length == gelenSayi)
                {
                    kelimeler.Add(yazi);
                }

                yazi = sr.ReadLine();
            }
            sr.Close();
            fs.Close();

            return kelimeler;
        }

    }
}
