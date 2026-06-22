using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    abstract class Departman
    {
        private int DepartmanNo;
        private string DepartmanSorumlusu;
        private int CalisanSyisi;

        // Properties
        public int DeptNo { get { return DepartmanNo; } set { DepartmanNo = value; } }
        public string DeptHead { get { return DepartmanSorumlusu; } set { DepartmanSorumlusu = value; } }
        public int HeadCount { get { return CalisanSyisi; } set { CalisanSyisi = value; } }

        // Methods
        public void GenelBilgiVer()
        {
            Console.WriteLine("Bu mesaj size ana class'tan gönderilmiştir.");
        }

        public virtual void CalismaSaatleriniGoster()
        {
            Console.WriteLine("Standart çalışma saatleri: 09:00 - 18:00");
        }

        public abstract void IsTanimi();
    }
}

