using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo7
{
    class Employe
    {

       public int intNumero { get; private set; }
       public string strPrenom { get; private set; }
       public string strNom { get; private set; }
       public double dblSalaire { get; private set; }
    


        public Employe()
        {

        }

        public Employe(int intNumero,string strPrenom,string strNom, double dblSalaire)
        {
            this.intNumero = intNumero;
            this.strPrenom = strPrenom;
            this.strNom = strNom;
            this.dblSalaire = dblSalaire;
        }

        static void main(string[] args)
        {

        }
    }
}
