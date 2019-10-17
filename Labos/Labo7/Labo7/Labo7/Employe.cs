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
       public int intSalaire { get; private set; }
    


        public Employe()
        {

        }

        public Employe(int intNumero,string strPrenom,string strNom,int intSalaire)
        {
            this.intNumero = intNumero;
            this.strPrenom = strPrenom;
            this.strNom = strNom;
            this.intSalaire = intSalaire;
        }

        static void main(string[] args)
        {

        }
    }
}
