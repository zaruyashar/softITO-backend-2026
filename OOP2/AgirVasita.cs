using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class AgirVasita
    {
        // Teacher's example
        public AgirVasita(string vadi, int fiyat, string ozellik)
        {
            this.vadi = vadi;
            this.fiyat = fiyat;
            this.ozellik = ozellik;

        }

        private string vadi;
        private int fiyat;
        private string ozellik;

        public string Vadi
        {
            get { return vadi; }
            set
            {
                if (value == "Kamyon" || value == "Tır")
                {
                    vadi = value;
                }
                else
                {
                    Console.WriteLine("hATALI GİRİŞ SİSTEME ATAMA YAPIYOR.");
                }


            }
        }

        public int Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value > 5000 && value < 10000)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("fiyat uygun değil sistem değer atıcak");
                }
            }
        }


        public string Ozellik
        {
            get { return ozellik; }
            set { ozellik = value; }

        }
    }
}
