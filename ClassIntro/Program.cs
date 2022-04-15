using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            // Console.WriteLine(kurs1.KursAdi + " :  " + kurs1.Egitmen);

            Kurs[] kurslar={kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " :  " + kurs.Egitmen);

            }

         

        }


        class Kurs {
            public string KursAdi { get; set; }

            public string Egitmen { get; set; }

            public int İzlenmeOrani { get; set; }
        }
    }
}
