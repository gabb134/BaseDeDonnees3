using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{


    class Program
    {
        private static List<GroupeEtudiants> lstGroupeEtudiants = new List<GroupeEtudiants>();

        static void Main(string[] args)
        {
            // 3 étudiants dans le groupe LMB
            GroupeEtudiants groupeLMB = new GroupeEtudiants("LMB");
            groupeLMB.ajouteEtudiant(new Etudiant("Michel", 100));
            groupeLMB.ajouteEtudiant(new Etudiant("Jacques", 55));
            groupeLMB.ajouteEtudiant(new Etudiant("Roger", 55));

            // 3 étudiants dans le groupe FC
            GroupeEtudiants groupeFC = new GroupeEtudiants("FC");
            groupeFC.ajouteEtudiant(new Etudiant("Joachim", 87));
            groupeFC.ajouteEtudiant(new Etudiant("Carole", 78));
            groupeFC.ajouteEtudiant(new Etudiant("Josée", 58));

            // 2 étudiants dans le groupe HL
            GroupeEtudiants groupeHL = new GroupeEtudiants("HL");
            groupeHL.ajouteEtudiant(new Etudiant("Akim", 76));
            groupeHL.ajouteEtudiant(new Etudiant("Jim", 56));

            // Ajouter les 3 groupes dans la liste des groupes.
            lstGroupeEtudiants.Add(groupeLMB);
            lstGroupeEtudiants.Add(groupeFC);
            lstGroupeEtudiants.Add(groupeHL);

               
         //Requêtes sur des ensembles hiérarchisés
        // Requête qui va chercher chaque étudiant dans chacun des groupes
        // Les from sont imbriqués
            
       var tousLesEtudiants = from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                                    from unEtudiant in unGroupe.lstEtudiants // Pour ce groupe va chercher un étudiant
                                    select unEtudiant;  // Sélectionne-le
              
             
        //                                 
        Console.WriteLine("Exécution 1 de la requête");
        foreach (var unEtudiant in tousLesEtudiants)
            Console.WriteLine(unEtudiant);
        Console.WriteLine();
        Console.ReadKey();
            
            
            
        // Observation: La requête a déjà été créée
        groupeFC.ajouteEtudiant(new Etudiant("Le nerde", 100));

        Console.WriteLine("Exécution 2 de la même requête");
        foreach (var unEtudiant in tousLesEtudiants)
            Console.WriteLine(unEtudiant);
        Console.WriteLine();

        Console.ReadKey();
        // ***********************************************************************************/
            
            
            // Requête sur des ensembles hiérarchisés
            // Requête qui récupère les étudiants qui sont en bas de 60 dans chacun des groupes dont le nom contient la lettre L

             var tousLesEtudiantsDesGroupesL = from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                                               where unGroupe.nomGroupe.Contains("L")
                                                    from unEtudiant in unGroupe.lstEtudiants // Pour ce groupe va chercher un étudiant
                                                    where unEtudiant.note < 60
                                               select new { unGroupe.nomGroupe, unEtudiant.nom, unEtudiant.note};  // Sélectionne-le


             foreach (var unEtudiant in tousLesEtudiantsDesGroupesL)
                 Console.WriteLine("Groupe: {0} --- Nom: {1}  Note: {2}", unEtudiant.nomGroupe, unEtudiant.nom, unEtudiant.note);
             Console.WriteLine();
             Console.ReadKey();
            // ***********************************************************************************/

            
            //Utilisation d'une requête à l'intérieur d'une autre requête
            // Faire passer tous les étudiants qui ont entre 55 et 60
            var etudiantsEntre55et60 = 
                           from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                                   from unEtudiant in unGroupe.lstEtudiants // Dans ce groupe va chercher un étudiant
                                   where unEtudiant.note >= 55 && unEtudiant.note < 60
                                   select unEtudiant;  // Sélectionne-le

            foreach (var unEtudiant in etudiantsEntre55et60)
                Console.WriteLine(unEtudiant);
            Console.WriteLine();
            Console.ReadKey();
           
            // Attention: La note est modifiée dans etudiantsEntre55et60Ont60 
            // mais pas dans etudiantsEntre55et60
            var etudiantsEntre55et60Ont60 = from unEtudiant in etudiantsEntre55et60
                           select new {unEtudiant.nom, note = 60};

            Console.WriteLine("Les anciennes notes:");
            foreach (var unEtudiant in etudiantsEntre55et60)
            Console.WriteLine("Nom de l'étudiant: {0} --- Note: {1}", unEtudiant.nom, unEtudiant.note);
            Console.WriteLine();

            Console.WriteLine("Les nouvelles notes:");
            foreach (var unEtudiant in etudiantsEntre55et60Ont60)
            Console.WriteLine("Nom de l'étudiant: {0} --- Note: {1}", unEtudiant.nom, unEtudiant.note);
            Console.WriteLine();
            Console.ReadKey();


          

            //***********************************************************************************/
            
            // Utilisation des deux requêtes imbriquées
            // Même chose que les deux requêtes précédentes mais les requêtes sont imbriquées
            var etudiantsEntre55et60Ont60Imbriques =         
                           from unEtudiantEntre55Et60 in 
                           (  // Cette requête va chercher tous les étudiants qui ont entre 55 et 60 
                              from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                              from unEtudiant in unGroupe.lstEtudiants
                              where unEtudiant.note >= 55 && unEtudiant.note < 60
                              select unEtudiant
                            )
                           select new { unEtudiantEntre55Et60.nom, ancienneNote = unEtudiantEntre55Et60.note, nouvelleNote = 60 };

             foreach (var unEtudiant in etudiantsEntre55et60Ont60Imbriques)
                 Console.WriteLine("Nom de l'étudiant: {0} --- Son ancienne note: {1} ----  Sa nouvelle note: {2}",
                                    unEtudiant.nom, unEtudiant.ancienneNote, unEtudiant.nouvelleNote);
             Console.WriteLine();
             Console.ReadKey();
             //************************************************************************************/

            // la méthode aggregate attend deux paramètres. 
            // Un accumulateur et une fonction sous forme de lamda-expresion dans le cas de C#

            // elle effectue un calcul récurrent sur toutes les valeurs de la liste. 
            // A chaque étape, la fonction est appelée avec la valeur courante de l'accumulateur comme premier argument et 
            // la valeur courante de la séquence comme deuxième argument.  
            // à la fin de l'itération, la valeur cumulée est retournée. 
            // On peut mettre une valeur initiale.

      
            // Exemple 1:
            // Calcul de la somme des notes

             // Ici on répète mais on pourrait ne pas répéter car la requête a déjà été construite
            var tousLesEtudiants3 = from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                                   from unEtudiant in unGroupe.lstEtudiants // Dans ce groupe va chercher un étudiant
                                   select unEtudiant;  // Sélectionne-le
           
            int sommeDesNotesSansAggregate = tousLesEtudiants3.Sum(unEtudiant => unEtudiant.note);
            int sommeDesNotesAvecAggregate = tousLesEtudiants3.Aggregate(0, (somme, unEtudiant) => somme + unEtudiant.note);
            Console.WriteLine("somme sans aggregate: {0}", sommeDesNotesSansAggregate);
            Console.WriteLine("somme avec aggrerate: {0}", sommeDesNotesAvecAggregate);
            Console.ReadKey();
            //*************************************************************************************************/
            
            //Exemple 2:
            // Calcul de la moyenne des notes

            // Ici on répète mais on pourrait ne pas répéter car la requête a déjà été construite
            var tousLesEtudiants2 = from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                                   from unEtudiant in unGroupe.lstEtudiants // Dans ce groupe va chercher un étudiant
                                   select unEtudiant;  // Sélectionne-le

            double moyenneDesNotesSansAggregate = tousLesEtudiants2.Average(unEtudiant => unEtudiant.note);
            double moyenneDesNotesAvecAggregate = tousLesEtudiants2.Aggregate(0, (somme, unEtudiant) => somme + unEtudiant.note, somme => (double)somme / tousLesEtudiants.Count());
            Console.WriteLine("moyenne sans aggregate: {0}", moyenneDesNotesSansAggregate);
            Console.WriteLine("moyenne avec aggregate: {0}", moyenneDesNotesAvecAggregate);
            Console.ReadKey();
            //****************************************************************************************************/

            //Exemple 3
            // Calcul de la plus petite note

            // Ici on répète mais on pourrait ne pas répéter car la requête a déjà été construite
            var tousLesEtudiants1 = from unGroupe in lstGroupeEtudiants // Va chercher un groupe
                                   from unEtudiant in unGroupe.lstEtudiants // Dans ce groupe va chercher un étudiant
                                   select unEtudiant;  // Sélectionne-le

            // Calcul de la plus petite note
            int minSansAggregate = tousLesEtudiants1.Min(unEtudiant => unEtudiant.note);
            int minAvecAggregate = tousLesEtudiants1.Aggregate(int.MaxValue, (min, unEtudiant) => (unEtudiant.note < min) ? unEtudiant.note : min);

            Console.WriteLine("min sans aggregate: {0}", minSansAggregate);
            Console.WriteLine("min avec aggregate: {0}", minAvecAggregate);
            Console.ReadKey();
            
            //****************************************************************************************************/
        }
    }
}
