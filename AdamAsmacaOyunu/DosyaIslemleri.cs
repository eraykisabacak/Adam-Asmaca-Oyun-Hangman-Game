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

        

        public static void DosyayaYazma(string dosya_yolu)
        {
            
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
