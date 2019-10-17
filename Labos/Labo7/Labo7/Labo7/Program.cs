using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo7
{
    class Program
    {
        public static List<Employe> lstEmployes = new List<Employe>();
        public static List<Contrat> lstContrats = new List<Contrat>();



        static void Main(string[] args)
        {

            // Remplir la liste des employés
            lstEmployes.Add(new Employe(1001, "toto", "LeBeau", 777));
            lstEmployes.Add(new Employe(1002, "France", "Bedard", 14.5));
            lstEmployes.Add(new Employe(1003, "Jean", "Sergio", 8.50));
            lstEmployes.Add(new Employe(1004, "Martin", "Cochon", 278.5));
            lstEmployes.Add(new Employe(1005, "Martine", "Lachance", 850));
            lstEmployes.Add(new Employe(1006, "Claude", "Coté", 77));
            lstEmployes.Add(new Employe(1007, "Lise", "Lavoie", 770));
            lstEmployes.Add(new Employe(1008, "Marc", "Bodormir", 75));
            lstEmployes.Add(new Employe(1009, "Marcel", "LeBeau", 777));
            lstEmployes.Add(new Employe(1010, "Paul", "Coté", 150.5));
            lstEmployes.Add(new Employe(1011, "Angelique", "Lavoie", 87.5));
            lstEmployes.Add(new Employe(1012, "Angele", "Vitiro", 77.5));
            lstEmployes.Add(new Employe(1013, "Virgule", "Deguillemets", 377));
            lstEmployes.Add(new Employe(1014, "Ti", "LeBeau", 475));

            // Remplir la liste des contrats
            lstContrats.Add(new Contrat(404001, 250.00, 1006));
            lstContrats.Add(new Contrat(404002, 125.00, 1003));
            lstContrats.Add(new Contrat(404003, 225.00, 1003));
            lstContrats.Add(new Contrat(404004, 325.00, 1005));
            lstContrats.Add(new Contrat(404005, 425.00, 1003));
            lstContrats.Add(new Contrat(404006, 255.00, 1007));
            lstContrats.Add(new Contrat(404007, 258.00, 1006));
            lstContrats.Add(new Contrat(404008, 325.00, 1008));
            lstContrats.Add(new Contrat(404009, 265.00, 1006));
            lstContrats.Add(new Contrat(404010, 275.00, 1005));
            lstContrats.Add(new Contrat(404011, 525.00, 1005));
            lstContrats.Add(new Contrat(404012, 625.00, 1003));
            lstContrats.Add(new Contrat(404013, 525.00, 1005));
            lstContrats.Add(new Contrat(404014, 625.00, 1007));
            lstContrats.Add(new Contrat(404015, 325.00, 1006));
            lstContrats.Add(new Contrat(404016, 275.00, 1006));
            lstContrats.Add(new Contrat(404017, 25.00, 1003));
            lstContrats.Add(new Contrat(404018, 25.00, 1003));



            /*3- Affichez toutes les informations sur les employés (numéro, prénom, nom, salaire)
            

            var tousLesEmployes = from unEmploye
                                  in lstEmployes
                                  select unEmploye;
            Console.WriteLine(" Affichez toutes les informations sur les employés (numéro, prénom, nom, salaire)");
            foreach(Employe unEmp in tousLesEmployes)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}",unEmp.intNumero,unEmp.strPrenom,unEmp.strNom,unEmp.dblSalaire);
            }

            Console.ReadKey();
            /************************************************************************************/

            /*4- En utilisant un type anonyme, afficher seulement les noms et prénoms de tous les employés, 
            //précédés du type de l’objet(.GetType())
            
            var toutLesNomsEtPrenoms = from unEmploye
                                       in lstEmployes
                                       select new {unEmploye.strPrenom,unEmploye.strNom };

             Console.WriteLine("En utilisant un type anonyme, afficher seulement les noms et prénoms de tous les employés");
            foreach(var unEmp in toutLesNomsEtPrenoms)
            {
                Console.WriteLine("{0}: {1}, {2}",unEmp.strPrenom,unEmp.strNom,unEmp.GetType());
            }
            Console.ReadKey();
            /************************************************************************************/


            /*5- Affichez le nom, prénom et le salaire 
            //de tous les employés dont le salaire est inférieur à 150$.
            var tousEmployesSalaireInferieur = from unEmploye
                                               in lstEmployes
                                               where unEmploye.dblSalaire < 150
                                               select unEmploye;

            Console.WriteLine("Tous les employés dont le salaire est inférieur à 150$");
            foreach(Employe emp in tousEmployesSalaireInferieur) //j'aurai pu mettre (var emp)
            {
                Console.WriteLine("{0}, {1}, {2}",emp.strPrenom,emp.strNom,emp.dblSalaire);
            }
            Console.ReadKey();
            /************************************************************************************/

            /*6- Pour tous les employés, affichez le nom, prénom, numéro 
            //de contrat et le montant du contrat. Utilisez une jointure interne

            var employeJointureInterne = from unEmploye in lstEmployes
                                         join unContrat in lstContrats
                                         on unEmploye.intNumero equals unContrat.intNumEmploye
                                         select new { unEmploye.strPrenom, unEmploye.strNom, unContrat.intNumEmploye, unContrat.dblMontant };

            Console.WriteLine("Pour tous les employés, affichez le nom, prénom, numéro de contrat et le montant du contrat.\n Utilisez une jointure interne");
            foreach (var unEmployeContrat in employeJointureInterne)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}",unEmployeContrat.intNumEmploye, unEmployeContrat.strPrenom,unEmployeContrat.strNom,unEmployeContrat.dblMontant);
            }
            Console.ReadKey();
            /************************************************************************************/
            /*7- Reprenez la question 6, mais en affichant même les employés qui n’ont pas de contrats.
            // Mettez une valeur par défaut lorsque l’employé n’a pas de contrat

            var employeJointureExterne = from unEmploye in lstEmployes
                                         join unContrat in lstContrats
                                         on unEmploye.intNumero equals unContrat.intNumEmploye
                                         into lstEmployeContrat
                                         // Crée un cours vide si l'employé n'a pas de contrat
                                         from unContrat in lstEmployeContrat.DefaultIfEmpty(new Contrat())
                                         select new { unEmploye.strPrenom, unEmploye.strNom, unContrat.intNumEmploye, unContrat.dblMontant };

            Console.WriteLine("Reprenez la question 6, mais en affichant même les employés qui n’ont pas de contrats \n Mettez une valeur par défaut lorsque l’employé n’a pas de contrat ");
            foreach (var unEmployeContrat in employeJointureExterne)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}", unEmployeContrat.intNumEmploye, unEmployeContrat.strPrenom, unEmployeContrat.strNom, unEmployeContrat.dblMontant);

            }
            Console.ReadKey();

            /************************************************************************************/

            /*8- Pour tous les employés, affichez par ordre décroissant des montants, le nom, 
            //prénom, numéro de contrat et le montant du contrat 

            var employeJointureInterneDescmontant = from unEmploye in lstEmployes
                                         join unContrat in lstContrats
                                         on unEmploye.intNumero equals unContrat.intNumEmploye
                                         orderby unContrat.dblMontant descending
                                         select new { unEmploye.strPrenom, unEmploye.strNom, unContrat.intNumEmploye, unContrat.dblMontant };

            Console.WriteLine("Pour tous les employés, affichez par ordre décroissant des montants, le nom, \nprénom, numéro de contrat et le montant du contrat");
            foreach (var unEmployeContrat in employeJointureInterneDescmontant)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}", unEmployeContrat.intNumEmploye, unEmployeContrat.strPrenom, unEmployeContrat.strNom, unEmployeContrat.dblMontant);
            }
            Console.ReadKey();

            /************************************************************************************/

            //9- Affichez toutes les informations sur les contrats (Rendu la)
            //en les regroupant par numéro d’employé.

            var infoSurLesContrat = from unContrat
                                    in lstContrats
                                    //order by
                                    select unContrat;


            /************************************************************************************/
        }
    }
}
