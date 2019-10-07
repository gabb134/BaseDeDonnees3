using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DemoAdoConnecte
{
    class Program
    {
      
        static String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDVoyages;User ID=**********;Password=********";
        static void Main(string[] args)
        {
            // Ouvrir la connexion
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            /********************************************************************************************************  
            // Utilisation de ExecuteReader(): la requête SELECT retourne plusieurs résultats
            String maRequeteSQL = " SELECT empPrenom, empNom FROM employe";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            SqlDataReader monReader = maCommande.ExecuteReader();
            while (monReader.Read()) // Lire le prochain enregistrement (la prochaine ligne)
            {
                // L'index peut être un numéro de colonne ou le nom d'une colonne
                Console.WriteLine("Prénom = " + monReader[0] + ", Nom = " + monReader["empNom"]);  
            }
            monReader.Close();   // IMPORTANT: Libérer les ressources  

            Console.ReadKey();
            *******************************************************************************************************/

            /********************************************************************************************************
            
            // Utilisation de ExecuteNonQuery(): Mise à jour avec UPDATE
            // La requête ne retourne aucun résultat; la méthode retourne le nombre d'enregistrements modifiés
             String maRequeteSQL1 = " UPDATE employe SET empPrenom = empPrenom + '12' WHERE empNo = 1001";
             String maRequeteSQL2 = " UPDATE employe SET empPrenom = 'toto' WHERE empNo = 1002 OR empNo=1003";
             SqlCommand maCommande1 = new SqlCommand(maRequeteSQL1, maConnexion);
             SqlCommand maCommande2 = new SqlCommand(maRequeteSQL2, maConnexion);
                            
            int nbLignesModifies = maCommande1.ExecuteNonQuery();
            Console.WriteLine(nbLignesModifies.ToString() + " ligne(s) modifiée(s) dans la commande 1");
            nbLignesModifies = maCommande2.ExecuteNonQuery();
            Console.WriteLine(nbLignesModifies.ToString() + " ligne(s) modifiée(s) dans la commande 2");
            Console.ReadKey(); 
            /********************************************************************************************************

            /********************************************************************************************************         
            // Utilisation de ExecuteScalar(): Comptage avec COUNT
            // La requête retourne un seul résultat
            String maRequeteSQL = " SELECT COUNT(empNo) FROM employe WHERE empEmploi = 'AN'";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
 
            // Toujours convertir car ExecuteScalar retourne un objet sans type
            int compteur = (int) maCommande.ExecuteScalar(); 
            
            Console.WriteLine("Il y a " + compteur + " employés qui ont l'emploi AN");
            Console.ReadKey();
              
            // Autre manière pour convertir:
            // String compteur2 = maCommande.ExecuteScalar().ToString(); // La plupart des objets se convertissent en String
            // Console.WriteLine(" Il y a " + compteur2 + " employés qui ont l'emploi AN");
            // Console.ReadKey(); 
            /********************************************************************************************************

            /*********************************************************************************************************           
            // Utilisation de ExecuteScalar(): SELECT avec un seul résultat
            // Un seul résultat est retourné

             String maRequeteSQL = " SELECT empEmploi FROM employe WHERE empNo = 1001";
             SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
 
             String emploi = maCommande.ExecuteScalar().ToString(); 
             Console.WriteLine("L'employé a l'emploi " + emploi);
             Console.ReadKey();
             /********************************************************************************************************

            /********************************************************************************************************        
            // Utilisation de ExecuteScalar(): SELECT
            // Aucun résulat n'est retourné: Ça "plante"

            String maRequeteSQL = " SELECT empEmploi FROM employe WHERE empNo = 1000";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);

            String emploi = maCommande.ExecuteScalar().ToString();
            Console.WriteLine("L'employé a l'emploi " + emploi);
            Console.ReadKey();
            /********************************************************************************************************

            /********************************************************************************************************         
            // Utilisation de ExecuteScalar(): SELECT
            // Solution 1: Le mettre dans une variable de type Object et vérifier si c'est null

            String maRequeteSQL = " SELECT empEmploi FROM employe WHERE empNo = 1000";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);

            Object emploi = maCommande.ExecuteScalar();
            if (emploi == null)
               Console.WriteLine("Cet employé n'existe pas. ");
            else
               Console.WriteLine(" Cet employé a l'emploi " + emploi);
            Console.ReadKey();

           /********************************************************************************************************/

            /********************************************************************************************************         
             // Utilisation de ExecuteScalar(): SELECT
             // Solution 2: Le mettre dans une variable de type dynamic
             // Le type va être déterminé à l'exécution
             // Attention: Il n'y a pas d'intellisense sur les variables de type dynamic

             String maRequeteSQL = " SELECT empEmploi FROM employe WHERE empNo = 1000";
             SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
             dynamic emploi = maCommande.ExecuteScalar();

             if (emploi == null)
                  Console.WriteLine("Cet employé n'existe pas. ");
             else
                  Console.WriteLine(" Cet emploi a l'emploi " + emploi);
             Console.ReadKey();

             /********************************************************************************************************

            /*********************************************************************************************************
            // Utilisation d'un paramètre C# dans la commande
            // A) Construction dynamique d'instruction SQL par concaténation avec un nombre entier

            Console.Write("Entrez un numéro d'employé: ");
            String num = Console.ReadLine().Trim();

            String maRequeteSQL = " SELECT empNom FROM employe WHERE empNo = " + num;
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            dynamic nom = maCommande.ExecuteScalar();
            if (nom == null)
              Console.WriteLine("Cet employé n'existe pas. ");
            else
              Console.WriteLine("Son nom est " + nom);

            Console.ReadKey();  
           /********************************************************************************************************

            /********************************************************************************************************
             // Utilisation d'un paramètre C# dans la commande
             // B) Construction dynamique d'instruction SQL par concaténation avec une chaîne
             // Observer le cas ou le paramètre est une chaîne de caractères 
             // Exemple: on entre le prénom, pour faire afficher le nom
             // Noter les risques d'erreurs : oubli de ' ' pour encadrer une valeur de type chaîne de caractères. 

              Console.Write("Entrez un prénom: ");
              String prenom = Console.ReadLine().Trim();
              String maRequeteSQL = " SELECT empNom FROM employe WHERE empPrenom = '" + prenom + "'";
              SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
              dynamic nom = maCommande.ExecuteScalar();
              if (nom == null)
                  Console.WriteLine("Cet employé n'existe pas. ");
              else
                  Console.WriteLine("Son nom est " + nom);
              Console.ReadKey();  
             /********************************************************************************************************

            /********************************************************************************************************
            // Utilisation d'un paramètre C# dans la commande
            // C) Construction dynamique d'instruction SQL par concaténation avec une chaîne
            //    mais en utilisant String.Format (de C#)

            Console.Write("Entrez un prénom: ");
            String prenom = Console.ReadLine().Trim();
            Console.Write("Entrez un nom: ");
            String nom = Console.ReadLine().Trim();

            String maRequeteSQL = String.Format("SELECT empNo FROM employe WHERE empPrenom = '{0}' AND  empNom = '{1}'", prenom, nom);
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
         
            dynamic no = maCommande.ExecuteScalar();
            if (no == null)
                Console.WriteLine("Cet employé n'existe pas. ");
            else
                Console.WriteLine("Son no est " + no);
            Console.ReadKey();  
           /*******************************************************************************************************/

            /********************************************************************************************************

             // Utilisation d'un paramètre SQL Server dans la commande
             // A) Construction dynamique d'instruction SQL par concaténation avec un paramètre SQL Server

             Console.Write("Entrez un numéro d'employé: ");
             String num = Console.ReadLine().Trim();

             String maRequeteSQL = "SELECT empPrenom + ' ' + empNom FROM employe WHERE empNo = @numero";
             SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
 
             // Ajout d'un paramètre SQL Server qui porte le nom de @numero
             SqlParameter monParametreSQL = new SqlParameter("@numero", num);
             maCommande.Parameters.Add(monParametreSQL);
   
             dynamic nomComplet = maCommande.ExecuteScalar();
             if (nomComplet == null)
                 Console.WriteLine("Cet employé n'existe pas. ");
             else
                 Console.WriteLine("Son nom complet est " + nomComplet);
             Console.ReadKey();  
           /********************************************************************************************************/

            // Utilisation d'un paramètre SQL Server dans la commande
            // B) Construction dynamique d'instruction SQL par concaténation avec un paramètre SQL Server
  
            Console.Write("Entrez un prénom: ");
            String prenom = Console.ReadLine().Trim();
            Console.Write("Entrez un nom: ");
            String nom = Console.ReadLine().Trim();

            // On me met pas d'apostrophes car @prenom est une variable et non pas un littéral
            String maRequeteSQL = "SELECT empNo FROM employe WHERE empPrenom = @prenom AND empNom = @nom";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            // On me met pas d'apostrophes car @prenom est une variable
            // Ajout d'un paramètre SQL Server qui porte le nom de @prenom et un autre qui porte le nom de @nom
            SqlParameter monParametreSQL1 = new SqlParameter("@prenom", prenom);
            SqlParameter monParametreSQL2 = new SqlParameter("@nom", nom);
            maCommande.Parameters.Add(monParametreSQL1);
            maCommande.Parameters.Add(monParametreSQL2);

            dynamic no = maCommande.ExecuteScalar();
            if (no == null)
                    Console.WriteLine("Cet employé n'existe pas. ");
            else
                    Console.WriteLine("Son no est " + no);
            Console.ReadKey();

 
            // Utilisation d'un paramètre SQL Server dans la commande
            // C) Paramètre en sortie




            String maRequeteSQL = "SELECT @nbContrats = COUNT(conNo) FROM contrat";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);

            // Ajout d'un paramètre SQL Server. Il n'a aucune valeur au point de départ
            SqlParameter paramNbContrats = new SqlParameter("@nbContrats", null);
            // On indique que @nbContrats doit être un int et que c'est un paramètre en sortie
            paramNbContrats.Direction = ParameterDirection.Output;  // Obligatoire
            paramNbContrats.SqlDbType = SqlDbType.Int; // Obligatoire
            maCommande.Parameters.Add(paramNbContrats);

            // Exécution de la commande
            maCommande.ExecuteNonQuery();
            // Aller chercher la valeur du nombre de contrats
            dynamic nbContrats = maCommande.Parameters["@nbContrats"].Value;
            Console.WriteLine("Il y a {0} contrat(s)", nbContrats);
                 
            Console.ReadKey();
            /********************************************************************************************************/

           
            
            // Plusieurs requêtes dans la commande
            // Exemple:  afficher les dates de départ et d'arrivée d'un voyage dont la destination est passée en paramètre
            // puis afficher le nombre de voyages qui ont cette destination. Ce nombre est un paramètre en sortie. 

            Console.Write("Entrez une destination: ");
            String destination = Console.ReadLine().Trim();

            // Il ya 2 requêtes dans cette requête
            String maRequeteSQL = "SELECT voyDateDepart, voyDateArrive FROM voyage WHERE voyDestination = @destinationVoyage; " +
                "SELECT @nbVoyages = COUNT(voyNo) FROM voyage WHERE voyDestination = @destinationVoyage; ";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);

            // Ajout du paramètre SQL Server @destinationVoyage en entrée
            SqlParameter paramNumEmploye = new SqlParameter("@destinationVoyage", destination);
            paramNumEmploye.SqlDbType = SqlDbType.VarChar;  // On indique que la donnée est de type varchar (pas obligatoire)
            paramNumEmploye.Direction = ParameterDirection.Input; // On indique que c'est en entrée (pas obligatoire)
            maCommande.Parameters.Add(paramNumEmploye); // On ajoute ce paramètre dans la commande

            // Ajout du paramètre SQL Server @nbVoyages en sortie
            SqlParameter paramNbContrats = new SqlParameter("@nbVoyages", null);
            paramNbContrats.SqlDbType = SqlDbType.Int;  // On indique que la donnée en sortie est de type int (nécessaire)
            paramNbContrats.Direction = ParameterDirection.Output; // On indique que c'est en sortie (nécessaire)
            maCommande.Parameters.Add(paramNbContrats); // On ajoute ce paramètre dans la commande

            // Utilisation d'un DataReader car il y a plusieurs résultats
            SqlDataReader monReader = maCommande.ExecuteReader();
            while (monReader.Read())
            {
                Console.WriteLine("Date de départ: {0} et date d'arrivée {1}", monReader["voyDateDepart"], monReader["voyDateArrive"]);

            }
            monReader.Close();   // Libérer les ressources ; Important pour avoir la valeur du paramètre SQL Server en sortie 

            // Paramètre en sortie
            Console.WriteLine("Lecture du paramètre en sortie:");
            Console.WriteLine("Il y a {0} voyages pour cette destination ", maCommande.Parameters["@nbVoyages"].Value);

            Console.ReadKey();
            
           
            // Fermer la connexion
            maConnexion.Close();

        }
    }
}
