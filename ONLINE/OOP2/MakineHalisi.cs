//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP2
//{
//    // Teacher's example
//    internal class MakineHalisi : Hali 
//    {
//        public int makinesayisi;
//        public string makinetipi;
//        public string iptipi;

//        public override int Hesap(int fiyat, string model)
//        {
//            if (model == "sanat dokusu")
//            {
//                fiyat += fiyat * 5 / 100;
//                return fiyat;
//            }
//            else if (model == "huzur")
//            {
//                fiyat += fiyat * 7 / 100;
//                return fiyat;
//            }
//            else
//            {
//                return fiyat;
//            }
//        }

//        public override int vergi(int fiyat)
//        {
//            fiyat += fiyat * 4 / 100;
//            return fiyat;
//        }
//    }
//}
