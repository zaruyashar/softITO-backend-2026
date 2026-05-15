using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class StandartMusteri : Musteri
    {
        private bool ucretsizKargosuVarMi;
        private bool kuponBirlestirebilirMi;

        public bool UcretsizKargosuVarMi
        {
            get { return ucretsizKargosuVarMi; }
            set { ucretsizKargosuVarMi = value; }
        }

        public bool KuponBirlestirebilirMi
        {
            get { return kuponBirlestirebilirMi; }
            set { kuponBirlestirebilirMi = value; }
        }
    }
}
