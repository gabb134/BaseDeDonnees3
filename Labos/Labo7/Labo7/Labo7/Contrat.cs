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
        public double dblMontant { get; private set; }
        public  int intNumEmploye { get; private set; }

        
        public Contrat()
        {

        }

        public Contrat(int intNumero,double dblMontant, int intNumEmploye)
        {
            this.intNumero = intNumero;
            this.dblMontant = dblMontant;
            this.intNumEmploye = intNumEmploye;
        }


    }
}
