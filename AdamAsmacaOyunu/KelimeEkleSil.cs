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
    public partial class KelimeEkleSil : Form
    {
        public KelimeEkleSil()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_Kelime.Text != "")
            {
                if(txt_Kelime.Text.Length < 6 && txt_Kelime.Text.Length > 2)
                {
                    string kelime = txt_Kelime.Text.ToUpper();
                    string dosya_yolu = @"../../Kelimeler.txt";

                    // Dosya Yoksa bir dosya oluşturur.
                    if (!File.Exists(dosya_yolu))
                    {
                        FileStream stream = File.Create(dosya_yolu);
                        stream.Close();
                    }
                   
                  
                    FileStream fs2 = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                    StreamReader sw2 = new StreamReader(fs2);
                    string yazi = sw2.ReadLine();
                    while (yazi != null)
                    {
                        if (yazi.Equals(txt_Kelime.Text.ToUpper()))
                        {
                            MessageBox.Show("Bu Kelime Daha Önce Eklenmiştir.");
                            return;
                        }
                        yazi = sw2.ReadLine();
                    }
                    sw2.Close();
                    fs2.Close();

                    // Dosyaya kelime ekler

                    StreamWriter sw = File.AppendText(dosya_yolu);
                    sw.WriteLine(kelime);
                    sw.Flush();
                    sw.Close();         
                    MessageBox.Show("Kelime Eklendi");                  
                }
                else
                {
                    MessageBox.Show("Lütfen 3 ile 5 arasındaki harfli kelime giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Eklemek istediğiniz bir kelime giriniz");
            }

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (txt_Kelime.Text != "")
            {
                if (txt_Kelime.Text.Length < 6 && txt_Kelime.Text.Length > 2)
                {
                    string kelime = txt_Kelime.Text.ToUpper();
                    string dosya_yolu = @"../../Kelimeler.txt";
                    List<string> satir = new List<string>();

                    // Kelimeyi Bulur
                    FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.ReadWrite);

                    StreamReader sw = new StreamReader(fs);
                    string yazi = sw.ReadLine();
                    while (yazi != null)
                    {
                        satir.Add(yazi);
                        yazi = sw.ReadLine();
                    }
                    fs.Close();
                    sw.Close();

                    bool kelimeSilindi = false;
                    foreach (string item in satir)
                    {
                        if (kelime.Equals(item))
                        {
                            satir.Remove(kelime);
                            kelimeSilindi = true;
                            break;
                        }
                    }
                    if (!kelimeSilindi)
                    {
                        MessageBox.Show("Kelime Bulunmadı");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Kelime Silindi");
                    }
                    FileStream fs2 = new FileStream(dosya_yolu, FileMode.Truncate);
                    StreamWriter sw2 = new StreamWriter(fs2);
                    for (int i = 0; i < satir.Count; i++)
                    {
                        sw2.WriteLine(satir[i]);
                    }

                    sw2.Close();
                    fs2.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen 3 ile 5 arasındaki harfli kelime giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Silmek istediğiniz bir kelime giriniz");
            }

        }
    }
}






