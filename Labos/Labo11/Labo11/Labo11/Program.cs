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


            Console.WriteLine("requete A");

            foreach (XAttribute unNomDepartement in tousLesNomsDepartement)
                Console.WriteLine(unNomDepartement);

            Console.ReadKey();


            /*********************************************************/
            /*b) Tous les éléments « noemploye » qu’il y a dans le
            //collège en ordre de numéro d’employé.

            var tousLesElementsNoEmploye = from unCollege in docCollege.Elements("college")
                                           from unDepartement in unCollege.Elements("departement")
                                           from unEnseignent in unDepartement.Elements("enseignant")
                                           from unEMploye in unEnseignent.Elements("noemploye")
                                           orderby (int)unEMploye 
                                           select unEMploye;

            Console.WriteLine("requete B");

            foreach (var unNoEmploye in tousLesElementsNoEmploye)
                Console.WriteLine(unNoEmploye);

            Console.ReadKey();


            /*********************************************************/

            //c) Le prénom et le nom de famille de tous les enseignants.

            var tousLesPrenomNomsFamilleEnseignents = 


           /*********************************************************/
        }
    }
}
