using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class Professeur
    {
        // {get; private set} signifie qu'on peut aller chercher la valeur de l'attribut mais qu'on ne peut pas la modifier
        public int numero { get; private set; }
        public string nom { get; private set; }
        public string prenom { get; private set; }
        public int anciennete { get; private set; }

        public Professeur()
        { // Constructeur sans paramètre
            prenom = nom = "Anonyme";
            numero = 0;
            anciennete = 0;
        }

        public Professeur(int numero, string nom, string prenom, int anciennete)
        { // Constructeur avec paramètres
            this.numero = numero;
            this.nom = nom;
            this.prenom = prenom;
            this.anciennete = anciennete;
        }

    }
    }

