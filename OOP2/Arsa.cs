using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal sealed class Arsa : Emlak
    {
        public string tapuAdi { get; set; }
        public int tapuNo { get; set; }
        private string TapuDurumu; // "Müstakil" veya "Hisseli"
        private string ArsaDurumu; // "Toplu konut", "Spor", "Şahsi"

        // 2 priv fields -> propped
        public string tapuDurumu
        {
            get { return TapuDurumu; }
            set
            {
                if(value == "Müstakil" || value == "Hisseli")
                {
                    TapuDurumu = value;
                }
                else
                {
                    Console.WriteLine("Kabul edilmeyen bir değer girdiniz.");
                }
            }
        }

        public string arsaDurumu
        {
            get { return ArsaDurumu; }
            set
            {
                if(value == "Toplu konut" || value == "Spor" || value == "Şahsi")
                {
                    ArsaDurumu = value;
                }
                else
                {
                    Console.WriteLine("Kabul edilmeyen bir değer girdiniz.");
                }
            }
        }


        // Methods


    }
}
