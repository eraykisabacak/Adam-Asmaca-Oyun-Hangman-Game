using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmacaOyunu
{
    class SkorTablosu
    {
        string ad;
        int puan;
        public static List<SkorTablosu> skorTablo = new List<SkorTablosu>();

        public SkorTablosu(string ad, int puan)
        {
            this.Ad = ad;
            this.Puan = puan;
        }

        public string Ad { get => ad; set => ad = value; }
        public int Puan { get => puan; set => puan = value; }
    }
}
