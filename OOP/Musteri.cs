using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Musteri
    {
        private int musteriNo;
        private string adSoyadi;
        private bool aktifMi;
        private decimal bakiye;

        public int MusteriNo
        {
            get { return musteriNo; }
            set { musteriNo = value; }
        }

        public string AdSoyadi
        {
            get { return adSoyadi; }
            set { adSoyadi = value; }
        }

        public bool AktifMi
        {
            get { return aktifMi; }
            set { aktifMi = value; }
        }

        public decimal Bakiye
        {
            get { return bakiye; }
            set { bakiye = value; }
        }

        public void BakiyeYukle(decimal miktar)
        {
            Bakiye += miktar;
        }

        public void UyeligiDondur()
        {
            AktifMi = false;
        }
    }
}