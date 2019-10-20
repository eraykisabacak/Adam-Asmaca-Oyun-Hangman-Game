using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmacaOyunu
{
    class Skor
    {
        public static List<Skor> skorList;
        string name { get; set; }
        int puan { get; set; }
        public static Start startForm { get; set; }

        public Skor(string name,int puan)
        {
            this.name = name;
            this.puan = puan;
        }

        public static void ilk10Yazdir()
        {
            foreach (var skor in skorList)
                startForm.ilk10.Text += skor.name + " " + skor.puan + "\n";
        }

    }
}
