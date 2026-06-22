using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class IT : Departman
    {
        public override void IsTanimi()
        {
            Console.WriteLine("IT departmanı yazılım ve sistem altyapısını yönetir.");
        }

        public override void CalismaSaatleriniGoster()
        {
            Console.WriteLine("IT departmanı çalışma saatleri: 7/24 Esnek Mesai");
        }
    }
}
