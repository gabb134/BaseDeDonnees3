using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    class Program
    {

        static String maChaineDeConnexion = "Data Source=424-SQL2017,5433;Initial Catalog=BDVoyagesMarrero;User ID=5B6Marrero;Password=Linuxmaster134";
        // Réseau rouge( Local 444/424) 424-SQL2017,5433
        // Réseau bleu (Maison)tcp:424sql.cgodin.qc.ca,5433

        static void Main(string[] args)
        {

            // Ouvrir la connexion
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            // A.
          

            String maRequeteSql = "SELECT empNom, empPrenom, empEmploi from employe";
            SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
            SqlDataReader monReader = maCommande.ExecuteReader();
            Console.WriteLine("Requête A ************************************************");
            while (monReader.Read())
            {
                Console.WriteLine(monReader[0]+", "+monReader["empPrenom"]+", "+monReader["empEmploi"]);
            }
            maConnexion.Close();
            Console.ReadKey();

             //B.
            
          /*  String maRequeteSql1 = "select conNo,conDate,empNom from contrat c inner join employe e on e.empNo = c.empNo";
            SqlCommand maCommande1 = new SqlCommand(maRequeteSql1, maConnexion);
            SqlDataReader monReader1 = maCommande1.ExecuteReader();
            Console.WriteLine("Requête B ************************************************");
            while (monReader1.Read())
            {
                Console.WriteLine(monReader1[0] + ", " + monReader1["conDate"] + ", " + monReader1["empNom"]);
            }
    
            Console.ReadKey(); */
            //C
            
          /*   String maRequeteSql = "select c.empNo,empNom,count(c.empNo) from contrat c inner join employe e on e.empNo = c.empNo group by c.empNo,empNom";
             SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
             SqlDataReader monReader = maCommande.ExecuteReader();
             Console.WriteLine("Requête C ************************************************");
             while (monReader.Read())
             {
                 Console.WriteLine(monReader[0] + ", " + monReader["empNom"] + ", " + monReader[2]);
             }
            
             Console.ReadKey();*/
            //D. 1.
            //	select 'Nombre d''hôtels à Montréal: '+convert(varchar,count(hotNom)) from hotel where hotNom like '%Montréal%'


              
             /*   String maRequeteSql = "select count(hotNom) from hotel where hotNom like '%Montréal%'";
                SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
                int compteur = (int)maCommande.ExecuteScalar();
                Console.WriteLine("Requête D *****************************");
                Console.WriteLine("Nombre d''hôtels à Montréal: "+compteur);
                Console.ReadKey();*/

            //D. 2.

            //À faire(demander au prof)


            //E. e. A l’aide d’un DataReader, affichez le numéro, la date de départ, la date
            //d’arrivée et la destination de tous les voyages à destination de Montréal

            
        /*   String maRequeteSql = "select voyNo, voyDateDepart,voyDateArrive,voyDestination from voyage where voyDestination = 'Montréal'";
            SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
            SqlDataReader monReader = maCommande.ExecuteReader();
            Console.WriteLine("Requête E ***********************************");
            while (monReader.Read())
            {
               Console.WriteLine(monReader["voyNo"]+", "+monReader["voyDateDepart"]+", "+monReader["voyDateArrive"]+", "+monReader["voyDestination"]);
            }

        
            Console.ReadKey();*/

            //F. Augmentez le tarif simple de 10% du tarif actuel pour tous les voyages à
            // destination de Montréal(affichez le nombre d’enregistrements qui ont
            //été mises à jour).Vous devez utiliser ExecuteNonQuery.Vérifiez si cela a
            //bien été fait.
/*
            String maRequeteSQL1 = "update voyage set tarifSimple = tarifTriple * 1.10 where voyDestination = 'Montréal'";
             SqlCommand maCommande1 = new SqlCommand(maRequeteSQL1, maConnexion);
             int nbLignesModifies = maCommande1.ExecuteNonQuery();
             Console.WriteLine("Requête F ****************************************************");
             Console.WriteLine("Nombre de lignes modifiée(s): " + nbLignesModifies.ToString());
            // Console.ReadKey();

            /*G. A l’aide d’un DataReader, pour chaque employé qui a des contrats,
           affichez le numéro de l’employé et le montant total de ses contrats. */
         /*      String maRequeteSql = "select empNo,sum(conMontant) from contrat group by empNo";
               SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
               SqlDataReader monReader = maCommande.ExecuteReader();
               Console.WriteLine("Requêt G ***********************************");
               while (monReader.Read())
               {
                   Console.WriteLine(monReader[0]+", "+monReader[1]);
               }

                  monReader.Close();*/


            /*H.  Affichez le nom de l’hôtel affecté à un numéro de voyage entré par
                 l’utilisateur. Utiliser un paramètre SQL Serveur en entrée. 
                             */
               /*  Console.Write("Entrez un numéro d'employé: ");
                 String num = Console.ReadLine().Trim();

                 String maRequeteSql = "select hotNom,h.hotno from hotel h inner join voyage v on h.hotNo = v.hotno where  v.voyNo like @noVoyageur";
                 SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
                 SqlParameter monParametreSQL = new SqlParameter("@noVoyageur", num);
                 maCommande.Parameters.Add(monParametreSQL);

                 dynamic numVoyage = maCommande.ExecuteScalar();
                 Console.WriteLine("Requête H ****************************************************");

                 if (numVoyage == null)
                     Console.WriteLine("Numéro de voyage inéxistant!");
                 else
                     Console.WriteLine("Hôtel: " + numVoyage);*/



            /*I. Insérez un nouvel enregistrement dans la table faitLeVoyage. Le numéro
            de contrat est 444014 et le numéro de client est 123024. Affichez le
             nombre d’enregistrements qui ont été ajoutées. Vous devez utiliser
               ExecuteNonQuery. */

             /* String maRequeteSql = "insert into faitLeVoyage values(444014,123024)";
              SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
              Console.WriteLine("Requête I ****************************************************");
              int nbLignesModifies = maCommande.ExecuteNonQuery();
              Console.WriteLine("Nombre de lignes ajoutées: "+ nbLignesModifies.ToString());*/




            /*J. Supprimez, dans la table faitLeVoyage, ce que vous venez d’ajouter.
         Affichez le nombre d’enregistrements qui ont été supprimés. Vous devez
        utiliser ExecuteNonQuery. 
            */

          /*  String maRequeteSql = "delete from faitLeVoyage where conNo = 444014 and cliNo = 123024";
             SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);
             Console.WriteLine("Requête J ****************************************************");
             int nbLignesModifies = maCommande.ExecuteNonQuery();
             Console.WriteLine("Nombre de lignes supprimées: " + nbLignesModifies);
             */



            /*K.*/
       /*     Console.WriteLine("Requête K ****************************************************");
            Console.Write("Entrez un numéro d'employé: ");
            String num = Console.ReadLine().Trim();
            String maRequeteSql = "select empPrenom,empNom from employe where empNo = "+num;
            SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);*/
         //   SqlParameter monParametreSQL = new SqlParameter("@employe", num);
          //  maCommande.Parameters.Add(monParametreSQL);

           /* dynamic employe = maCommande.ExecuteReader();

            if (employe.Read() == false)
                Console.WriteLine("Numéro d'employé inéxistant!");
            else
            {
                Console.WriteLine("Nom et prénom de l'employé "+ employe[1]+" "+ employe[0]);
                employe.Close();
                String maRequeteSql2 = "select count(voyActivite) from voyage where empNo = " + num+" group by empNo";
                SqlCommand maCommande2 = new SqlCommand(maRequeteSql2, maConnexion);
                dynamic voyage = maCommande2.ExecuteScalar();

                if (voyage == null)
                    Console.WriteLine("Cet employé anime 0 voyage(s)");
                else
                    Console.WriteLine("Cet employé anime "+voyage + " voyage(s)");
                
            }   


            Console.ReadKey();*/
                maConnexion.Close();
        }
    }
}