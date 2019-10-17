using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class Program
    {

        private static List<Professeur> lstProfs = new List<Professeur>();
        private static List<Cours> lstCours = new List<Cours>();

        static void Main(string[] args)
        {
            // Remplir la liste de profs
            lstProfs.Add(new Professeur(1, "Brousseau", "Louis-Marie", 18));
            lstProfs.Add(new Professeur(2, "Selka", "Hanane", 2));
            lstProfs.Add(new Professeur(3, "Lewis", "Hélène", 10));
            lstProfs.Add(new Professeur(4, "Cherief", "Ferroudja", 17));
            lstProfs.Add(new Professeur(5, "Landry", "Jean-François", 17));
            lstProfs.Add(new Professeur(6, "Daigle", "Bruno", 7));
            lstProfs.Add(new Professeur(7, "Jean-Julien", "Ronald", 2));
            lstProfs.Add(new Professeur(8, "Airouche", "Mohamed", 4));
            lstProfs.Add(new Professeur(9, "Loyer", "Alain", 4));

            // Remplir la liste des cours
            lstCours.Add(new Cours("420-3B4", 6));
            lstCours.Add(new Cours("420-5W6", 1));
            lstCours.Add(new Cours("420-1A4", 2));

            lstCours.Add(new Cours("420-1P6", 1));
            lstCours.Add(new Cours("420-1P6", 3));

            lstCours.Add(new Cours("420-284", 3));
            

            lstCours.Add(new Cours("420-284", 4));
            lstCours.Add(new Cours("420-5PA", 7));
            lstCours.Add(new Cours("420-3P6", 4));
            lstCours.Add(new Cours("420-5B6", 4));

            lstCours.Add(new Cours("420-5PA", 5));
            lstCours.Add(new Cours("420-0A3", 5));
            
            lstCours.Add(new Cours("420-1X4", 8));
         

            lstCours.Add(new Cours("420-0A3", 8));
            lstCours.Add(new Cours("420-3X4", 8));
            lstCours.Add(new Cours("420-5A6", 7));


            /*Requête 1
            // Les ensembles sources
            // Tous les profs

            var tousLesProfs = from unProfesseur // variable discrète
                               in lstProfs // ensemble à interroger
                               select unProfesseur; // Ce qu'on doit sélectionner

            // Ici, la classe de unProf n'est pas anonyme. Il s'agit d'une instance de la classe Professeur
            foreach (Professeur unProf in tousLesProfs)
            {
                Console.WriteLine("{0}: {1}, {2}", unProf.numero, unProf.nom, unProf.prenom);
            }

            Console.ReadKey();
           /***********************************************************************************/

            //   Requête 2
            // La projection: on détermine ce qu'on veut avoir
            // Utilisation d'une classes anonyme
            
            var tousLesNosEtNoms = from unProfesseur // variable discrète
                                   in lstProfs // ensemble à interroger
                                   select new { unProfesseur.numero, unProfesseur.nom }; // Ce qu'on doit sélectionner
                                  // Création d'une classe anonyme avec numero et nom en tant qu'attributs
                                  
             
            // Ici, le classe de unProf est anonyme.
            // unProf est une instance d'une classe dans laquelle
            // il y a un attribut numero et un attribut nom 
            // mais cette classe ne porte pas de nom. 
            // Le type de unProf est inféré.
            foreach (var unProf in tousLesNosEtNoms)
            {
                Console.WriteLine("{0}: {1}", unProf.numero, unProf.nom);
            }
            Console.ReadKey();
           /************************************************************************************/

            /* Requête 3
            // La clause WHERE
            // Il faut que l'expression à la suite du Where soit booléenne
            var tousLesProfsAvecUnC = from unProfesseur in lstProfs
                                      where unProfesseur.nom.StartsWith("L") // Il faut que ce soit booléen
                                      select unProfesseur; // Ce qu'on doit sélectionner
             

            foreach (var unProf in tousLesProfsAvecUnC)
            {
                Console.WriteLine("{0}: {1}, {2}", unProf.numero, unProf.nom, unProf.prenom);
            }

            Console.ReadKey();
           /************************************************************************************/

            /* Requête 4
            // Les jointures internes: join..on..equals
            // Jointure interne: crée un seul ensemble à partir des 2 ou plusieurs ensembles (INNER JOIN)
             var tousLesProfsCours = from unProfesseur in lstProfs
                                     join unCours      in lstCours
                                     on unProfesseur.numero equals unCours.noProf // La jointure se fait par le no de prof
                                     select new { unProfesseur.prenom, unProfesseur.nom, unCours.numero };

             // Observez que Alain n'est pas présent 
             // car il ne donne pas de cours cette session
             foreach (var unProfCours in tousLesProfsCours)
             {
                 Console.WriteLine("{0} : {1} {2}", unProfCours.numero, unProfCours.prenom, unProfCours.nom);
             }
             Console.ReadKey();
             /************************************************************************************/
            
            /*Requête 5a
            // Les jointures externes: join..on..equals..into 
            // Jointure externe: Chaque prof de l'ensemble des profs est relié à un ensemble de cours (LEFT JOIN)
            // On a deux ensembles reliés. Chaque prof de l'ensemble des profs est relié à 0, 1 ou plusieurs cours
            var tousLesProfsCours = from unProfesseur in lstProfs
                                    join unCours in lstCours
                                    on unProfesseur.numero equals unCours.noProf 
                                        into lstCoursDonnésParCeProf
                                        // On met l'ensemble des cours donnés par le prof
                                    select new { unProfesseur.prenom, unProfesseur.nom, lstCoursDonnésParCeProf }; 

            // Observez que Alain est présent (même s'il ne donne pas de cours)
            // Il est présent en tant que prof mais n'est pas relié à l'ensemble des cours.
            // Deux boucles imbriquées: Une pour les profs, la seconde pour les cours qu'ils donnent
            foreach (var unProf in tousLesProfsCours)
            {
              Console.WriteLine("{0} {1}", unProf.prenom, unProf.nom);

                foreach (var unCours in unProf.lstCoursDonnésParCeProf)
                {

                    Console.WriteLine("\t{0}", unCours.numero);
                }
            }
            Console.ReadKey();
            /************************************************************************************/

            /* Requête 5b
            // Les jointures externes: join..on..equals..into 
            // Jointure externe: Chaque cours de l'ensemble des cours est relié à un ensemble de profs (LEFT JOIN)
            var tousLesCoursProfs = from unCours in lstCours
                                    join unProfesseur in lstProfs
                                    on unCours.noProf equals unProfesseur.numero
                                        into lstProfsQuiDonnentCeCours
                                        // On met l'ensemble des profs dans le cours (il n'y en a qu'un)
                                    select new { unCours.numero, lstProfsQuiDonnentCeCours}; 

            // Observez que Alain n'est pas présent (il ne donne pas de cours)
            // Deux boucles imbriquées: Une pour les cours, la seconde pour les profs qui donnent ce cours
            foreach (var unCours in tousLesCoursProfs)
            {
                Console.WriteLine("{0}", unCours.numero);

                foreach (var unProf in unCours.lstProfsQuiDonnentCeCours)
                {

                    Console.WriteLine("\t{0} {1}", unProf.prenom, unProf.nom);
                }
            }
            Console.ReadKey();
            /************************************************************************************/

            /// Requête 6
            // Les jointures externes: join..on..equals..into et 
            // imbrication des ensembles (from..in imbriqués)
            // Jointure externe: Chaque prof de l'ensemble des profs est relié à un ensemble de cours
            // Pour les profs sans cours. On ajoute un cours vide pour eux.
            // Ici, on a deux from..in imbriqués
             var tousLesProfsCours = from unProfesseur in lstProfs
                                     join unCours in lstCours
                                     on unProfesseur.numero equals unCours.noProf 
                                     into lstCoursDonnésParCeProf
                                        // Crée un cours vide si le prof ne donne pas de cours
                                     from unCours in lstCoursDonnésParCeProf.DefaultIfEmpty(new Cours()) 
                                    select new { unProfesseur.prenom, unProfesseur.nom, unCours.numero }; 

              foreach (var unProfCours in tousLesProfsCours)
               {   
                    Console.WriteLine("{0} {1} : {2}", unProfCours.prenom, unProfCours.nom, unProfCours.numero);
               }
            Console.ReadKey();
            /************************************************************************************/

            /* Requête 7
            // Trier des objets: orderby
             var tousLesProfsCours = from unProfesseur in lstProfs
                                     join unCours      in lstCours
                                     on unProfesseur.numero equals unCours.noProf
                                     orderby unProfesseur.nom, unProfesseur.prenom ascending
                                     // orderby unCours.numero descending
                                     select new { unProfesseur.prenom, unProfesseur.nom, unCours.numero };

             foreach (var unProfCours in tousLesProfsCours)
             {
                 Console.WriteLine("{0} : {1} {2}", unProfCours.numero, unProfCours.prenom, unProfCours.nom);
             }
             Console.ReadKey();
             /************************************************************************************/

            /* Requête 8A
            // Regrouper des éléments: group..by
            // Le résultat produit est un ensemble de regroupements
            // Chaque regroupement possède une clef 
            // et c'est à partir de cette clef qu'on accède aux éléments du groupe.
            // On a donc deux ensembles: le premier contient la clef (après le by..) 
            // Le second, les éléments qui ont cette clef.
            // Fonctionne de la même manière que les jointures externes
            // sauf que les deux ensembles proviennent du même ensemble
       
            var groupesParCours = from unCours in lstCours
                                  group unCours // Tous les cours regroupés
                                  by unCours.numero; // par la clef (le numéro du cours)

            foreach (var unGroupeCours in groupesParCours)
            {
                Console.WriteLine("Le numéro du cours: {0}", unGroupeCours.Key);

                foreach (var unCours in unGroupeCours)
                {
                    Console.WriteLine("\tNo du prof qui donne ce cours: {0}", unCours.noProf);
                }
            }
            Console.ReadKey();
            /************************************************************************************/

            /* Requête 8B
            // Regrouper des éléments: group..by
            // Chaque regroupement a une clef et c'est à partir de cette clef qu'on accède aux éléments du groupe.  
            var groupesParProfs = from unCours in lstCours
                                  group unCours // Tous les cours regroupés
                                  by unCours.noProf; // par la clef (le numéro du prof)

            foreach (var unGroupeCours in groupesParProfs)
            {
                Console.WriteLine("Le numéro du prof: {0}", unGroupeCours.Key);

                foreach (var unCours in unGroupeCours)
                {
                    Console.WriteLine("\tNo du cours donné par ce prof: {0}", unCours.numero);
                }
            }
            Console.ReadKey();
            /************************************************************************************/

            /* Requête 9
            // Regrouper des éléments: group..by unPrédicat
            // La clef vaut true ou false et c'est à partir de cette clef qu'on accède aux éléments du groupe.
            // Ici, il s'agit des cours de 5ième session et ceux qui ne les sont pas.
            var groupesParPredicat = from unCours in lstCours
                                     group unCours by (unCours.numero.Substring(4, 1) == "5");
                                         
                                    


           Console.WriteLine("Cours de 5ième session.");
            foreach (var unGroupeCours in groupesParPredicat)
            {
              if (unGroupeCours.Key)
                  foreach (var unCours in unGroupeCours)
                    {
                        Console.WriteLine("{0}", unCours.numero);
                    }
            }

            Console.WriteLine("Cours qui ne sont pas de 5ième session.");
            foreach (var unGroupeCours in groupesParPredicat)
            {
                if (!unGroupeCours.Key)
                    foreach (var unCours in unGroupeCours)
                    {
                        Console.WriteLine("{0}", unCours.numero);
                    }
            }

            Console.ReadKey();
            // autre façon
            
            foreach (var unGroupeCours in groupesParPredicat)
            {
                Console.WriteLine(unGroupeCours.Key ? "Cours de 5ième session" : "Cours qui ne sont pas de 5ième session");
                    foreach (var unCours in unGroupeCours)
                    {
                        Console.WriteLine("{0}", unCours.numero);
                    }
            }
            Console.ReadKey();

            
            /************************************************************************************/

           /*Requête 10
            // Regrouper des éléments par d'autres types de clefs: group..by uneClef
            // Ici, on les regroupe par la 1ère lettre du nom.
            var groupesProfs = from unProf in lstProfs
                               orderby unProf.nom.ElementAt(0)
                               group unProf by unProf.nom.ElementAt(0);
            
            foreach (var unGroupeProfs in groupesProfs)
            {
                Console.WriteLine("{0}:", unGroupeProfs.Key);
                foreach (var unProf in unGroupeProfs)
                {
                    Console.WriteLine("{0},{1}", unProf.nom, unProf.prenom);
                }
            }

            Console.ReadKey();
            /************************************************************************************/

            /* Requête 11
            // Regroupement externe: group..by..into
            // Même principe que pour les regroupements internes
            // mais on donne un nom à l'ensemble résultant
            // Nécessaire pour faire un select new

            var groupesProfs2 = from unProf in lstProfs
                                orderby unProf.nom.ElementAt(0)
                                group unProf by unProf.nom.ElementAt(0)
                                    into groupeProfsExterne  // Ensemble qui contient une clef et un sous-ensemble
                                select new { groupeProfsExterne.Key, groupeProfsExterne};
                                                
            
            foreach (var unGroupeProfs in groupesProfs2)
            {
                Console.WriteLine("{0}:", unGroupeProfs.Key);
                foreach (var unProf in unGroupeProfs.groupeProfsExterne)
                {
                    Console.WriteLine("{0},{1}", unProf.nom, unProf.prenom);
                }
            }

            Console.ReadKey();
              
            /************************************************************************************/

            /* Requête 12
            // Agrégations: Calculs: moyenne, somme, compteurs,etc 
            // Utilisation des lambdas-fonctions (utilisée en programmation fonctionnelle)
            // "unProf => unprof.anciennete" signifie "Pour chaque prof, va chercher son ancienneté"
            // Cela crée un ensemble d'ancienneté
            // Average en fait la moyenne
            var ancienneteMoyen = lstProfs.Average(unProf => unProf.anciennete);
             // unProf => unProf.anciennete: lamnda expression (voir prochain cours)
            Console.WriteLine("Ancienneté moyen: {0}", ancienneteMoyen);
            Console.ReadKey();
            /*************************************************************************************/

            /* Requête 13a
            // Utilisé dans les jointures externes
            // Voir le nombre de cours que donnent chaque prof
            // Dans l'ensemble, on donne un nom au nombre de cours 

            var tousLesProfsCours = from unProfesseur in lstProfs
                                    join unCours in lstCours
                                    on unProfesseur.numero equals unCours.noProf
                                        into ensembleCours
                                    select new { unProfesseur.prenom, unProfesseur.nom, nbCours = ensembleCours.Count() };

            foreach (var unProf in tousLesProfsCours)
            {
                Console.WriteLine("Le prof {0} {1} donne {2} cours. ", unProf.prenom, unProf.nom, unProf.nbCours);
            }

            Console.ReadKey();
            /************************************************************************************/

            /* Requête 13b
            // Utilisé également dans les regroupements externes
            // Voir le nombre de cours que donnent chaque prof

            var groupesParProf = from unCours in lstCours
                                 group unCours by unCours.noProf
                                      into unGroupeCoursExterne
                                      select new { noProf = unGroupeCoursExterne.Key, nbCours = unGroupeCoursExterne.Count() };

            foreach (var unCours in groupesParProf)
            {
                Console.WriteLine("Le prof {0} donne {1} cours. ", unCours.noProf, unCours.nbCours);
            }
            Console.ReadKey();
            /*************************************************************************************/
       
            
            /* Requête 14
            // Utilisation du let dans la requête (pour donner un nom aux éléments de l'ensemble)

            var groupesProfs = from unProf in lstProfs
                      
                               orderby unProf.nom.ElementAt(0)
                               group unProf by unProf.nom.ElementAt(0)
                               into unGroupeProfs
                               let premiereLettreDuNom = unGroupeProfs.Key
                             
                               let nbProfs = unGroupeProfs.Count()
                               let sommeAnciennete = unGroupeProfs.Sum(unProf => unProf.anciennete)
                                   // unProf => unProf.anciennete est une expression lambda. Théorie au prochain cours
                               let moyenneAnciennete = unGroupeProfs.Average(unProf => unProf.anciennete)
                               select new { premiereLettreDuNom, nbProfs, sommeAnciennete, moyenneAnciennete };
                          
            foreach (var unGroupeProfs in groupesProfs)
            {

                Console.WriteLine("{0} nom(s) de prof débute(nt) par la lettre {1}. ", unGroupeProfs.nbProfs, unGroupeProfs.premiereLettreDuNom);
                Console.WriteLine("\tAncienneté total: {0}. Ancienneté moyen: {1}. ", unGroupeProfs.sommeAnciennete, unGroupeProfs.moyenneAnciennete);
            }
            Console.ReadKey();
            /*************************************************************************************/

            // Requête 15
            // Utilisation des lambdas-expressions dans l'exécution (pas dans la requête)

            var groupesProfs = from unProf in lstProfs
                               orderby unProf.nom.ElementAt(0)
                               group unProf by unProf.nom.ElementAt(0);

            foreach (var unGroupeProfs in groupesProfs)
            {
                var lettreProfs = unGroupeProfs.Key;
                var nbProfs = unGroupeProfs.Count();
                var sommeAnciennete = unGroupeProfs.Sum(unProf => unProf.anciennete);
                var moyenneAnciennete = unGroupeProfs.Average(unProf => unProf.anciennete);

                Console.WriteLine("{0} nom(s) de prof débute par la lettre {1}. ", nbProfs, lettreProfs);
                Console.WriteLine("\tAncienneté total: {0}. Ancienneté moyen: {1}. ", sommeAnciennete, moyenneAnciennete);
            }
            Console.ReadKey();
            /*************************************************************************************/
        }
    }
}


