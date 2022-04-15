using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi :"+ urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi : "+ urunAdi);

        }
    }
}
