using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Etudiant
    {
        public string nom { get; private set; }
        public int note { get; private set; }

        public Etudiant(string nom, int note)
        {
            this.nom = nom;
            this.note = note;
        }

        public override string ToString()
        {  // Remplace la méthode ToString qui a déjà été définie
            // On retourne le nom de l'étudiant et sa note 
            return string.Format("nom : {0}, note : {1}", nom, note);
        }
    }
}
