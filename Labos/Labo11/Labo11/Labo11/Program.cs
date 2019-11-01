using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labo11
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument docCollege = XDocument.Load("college.xml");

            /*a) Affichez les noms de tous les départements du collège.



            //Console.WriteLine(docCollege);
            var tousLesNomsDepartement = from unCollege in docCollege.Elements("college")
                                     from unDepartement in unCollege.Elements("departement")
                                     select unDepartement.Attribute("nom");


            Console.WriteLine("requête A");

            foreach (XAttribute unNomDepartement in tousLesNomsDepartement)
                Console.WriteLine(unNomDepartement);

            Console.ReadKey();


            /*********************************************************/
            /*b) Tous les éléments « noemploye » qu’il y a dans le
            //collège en ordre de numéro d’employé.

            var tousLesElementsNoEmploye = from unCollege in docCollege.Elements("college")
                                           from unDepartement in unCollege.Elements("departement")
                                           from unEnseignant in unDepartement.Elements("enseignant")
                                           from unEMploye in unEnseignant.Elements("noemploye")
                                           orderby (int)unEMploye 
                                           select unEMploye;

            Console.WriteLine("requête B");

            foreach (var unNoEmploye in tousLesElementsNoEmploye)
                Console.WriteLine(unNoEmploye);

            Console.ReadKey();


            /*********************************************************/

            /*c) Le prénom et le nom de famille de tous les enseignants.

            var tousLesPrenomNomsFamilleEnseignents = from unCollege in docCollege.Elements("college")
                                                      from unDepartement in unCollege.Elements("departement")
                                                      from unEnseignant in unDepartement.Elements("enseignant")
                                                      from nom in unEnseignant.Elements("nom")
                                                      from prenom in unEnseignant.Elements("prenom")
                                                      select new {nom,prenom };


            Console.WriteLine("requête C");

            foreach (var nomPrenom in tousLesPrenomNomsFamilleEnseignents)
                Console.WriteLine(nomPrenom.prenom.Value + " " + nomPrenom.nom.Value);

            Console.ReadKey();

            /*********************************************************/

            /*d) Même question qu’en c), mais regroupés par la 1ère lettre
            //du nom de famille en ordre de 1ère lettre du nom de famille
            //puis de nom de famille puis de prénom. 


            var tousLesPrenomNomsFamilleEnseignentsParLettre = from unCollege in docCollege.Elements("college")
                                                               from unDepartement in unCollege.Elements("departement")
                                                               from unEnseignant in unDepartement.Elements("enseignant")
                                                               from nom in unEnseignant.Elements("nom")
                                                               from prenom in unEnseignant.Elements("prenom")
                                                               let nomFamille = nom.Value
                                                               let nomComplet = prenom.Value + " " + nom.Value
                                                               orderby nomFamille[0], nomFamille, prenom.Value
                                                               group nomComplet by nomFamille[0]
                                                               into premiereLettreNomFamille
                                                               select premiereLettreNomFamille ;


            Console.WriteLine("requête D");

            foreach (var premiereLettre in tousLesPrenomNomsFamilleEnseignentsParLettre)
            {
               Console.WriteLine( premiereLettre.Key);

                foreach(var nomComplet in premiereLettre)
                {
                    Console.WriteLine(nomComplet);
                }
            }

            Console.ReadKey();



            /*********************************************************/

            /*e) Même question qu’en d), mais en plus, on affiche le nom
            //du département(suggestion : le faire en deux requêtes
            //imbriquées). 
            var tousLesPrenomNomsFamilleEnseignentsParLettreEtDept = from unCollege in docCollege.Elements("college")
                                                                     from unDepartement in unCollege.Elements("departement")
                                                                     from unEnseignant in unDepartement.Elements("enseignant")
                                                                     from nom in unEnseignant.Elements("nom")
                                                                     from prenom in unEnseignant.Elements("prenom")
                                                                     let nomFamille = nom.Value
                                                                     let nomComplet = prenom.Value + " " + nom.Value
                                                                     let nomDept = unDepartement.Attribute("nom").Value
                                                                     orderby nomFamille[0], nomFamille, prenom.Value
                                                                     group new { nomComplet,nomDept } by nomFamille[0]
                                                                         into premiereLettreNomFamille
                                                                     select premiereLettreNomFamille ;
                                                                        
                                                             
                                                                     
                                                                     
                                                                     


            Console.WriteLine("requête E");

            foreach (var premiereLettre in tousLesPrenomNomsFamilleEnseignentsParLettreEtDept)
            {
                Console.WriteLine(premiereLettre.Key);

                foreach (var nomComplet in premiereLettre)
                {
                    Console.WriteLine("{0} ---- {1}",nomComplet.nomComplet,nomComplet.nomDept);
                }
            }

            Console.ReadKey();

            /*********************************************************/

            //
        }
    }
}
