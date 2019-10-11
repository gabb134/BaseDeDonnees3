using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
        class Cours
        {
            // {get; private set} signifie qu'on peut aller chercher la valeur de l'attribut mais qu'on ne peut pas la modifier
            public string numero { get; private set; }
            public int noProf { get; private set; }

            public Cours()
            { // Constructeur sans paramètre
                numero = "Aucun cours";
                noProf = 0;

            }

            public Cours(string numero, int noProf)
            { // Constructeur avec paramètres
                this.numero = numero;
                this.noProf = noProf;
            }
        }
    
}
