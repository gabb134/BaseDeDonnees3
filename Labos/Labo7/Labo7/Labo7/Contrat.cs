using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo7
{
    class Contrat
    {

        public int intNumero { get; private set; }
        public int intMontant { get; private set; }
        public  int intNumEmploye { get; private set; }


        public Contrat()
        {

        }

        public Contrat(int intNumero,int intMontant,int intNumEmploye)
        {
            this.intNumero = intNumero;
            this.intMontant = intMontant;
            this.intNumEmploye = intNumEmploye;
        }


    }
}
