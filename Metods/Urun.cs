using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    internal class Urun
    {
        //Property-Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

        public int stokAdedi { get; set; }
    }
}
