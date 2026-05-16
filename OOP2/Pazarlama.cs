using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Pazarlama : Departman
    {
        public double ReklamGelir;
        public double ReklamGider;

        public override void IsTanimi()
        {
            Console.WriteLine("Pazarlama departmanı ürün tanıtımı ve satış stratejileri geliştirir.");
        }

        public double ROIHesapla(double reklamGeliri, double reklamGideri)
        {
            double ROI = reklamGeliri - reklamGideri;
            return ROI;
        }
    }
}
