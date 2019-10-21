using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class GroupeEtudiants
    {
        public String nomGroupe { get; private set; }
        public List<Etudiant> lstEtudiants { get; private set; }

        public GroupeEtudiants(String nomGroupe)
        {
            lstEtudiants = new List<Etudiant>();
            this.nomGroupe = nomGroupe;
        }

        public void ajouteEtudiant(Etudiant unEtudiant)
        {
            lstEtudiants.Add(unEtudiant);
        }

        public override string ToString()
        {  // Remplace la méthode ToString qui a déjà été définie
            // On retourne le nom du groupe suivi de chacun des étudiants
            string chaine = string.Format("{0} :", nomGroupe);
            foreach (Etudiant unEtudiant in lstEtudiants)
                chaine += "\t" + unEtudiant;
            return chaine;
        }
    }
}
