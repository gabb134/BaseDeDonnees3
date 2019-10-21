﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo8
{
    class Program
    {
        private static List<Produit> lstProduits = new List<Produit>();
        private static List<Client> lstClients = new List<Client>();

        static void Main(string[] args)
        {
            // Remplissage des produits
            lstProduits.Add(new Produit(1, 10));
            lstProduits.Add(new Produit(2, 20));
            lstProduits.Add(new Produit(3, 30));
            lstProduits.Add(new Produit(4, 40));
            lstProduits.Add(new Produit(5, 50));
            lstProduits.Add(new Produit(6, 60));

            // Remplissage des clients
            Client unClient = new Client("Joseph", "Montréal", "Canada");
            unClient.ajouteCommande(new Commande(1, 3, false, Mois.Janvier, 1));
            unClient.ajouteCommande(new Commande(2, 5, true, Mois.Mai, 2));
            lstClients.Add(unClient);

            unClient = new Client("John", "Winnipeg", "Canada");
            unClient.ajouteCommande(new Commande(3, 10, false, Mois.Juillet, 1));
            unClient.ajouteCommande(new Commande(4, 20, true, Mois.Decembre, 3));
            lstClients.Add(unClient);

            unClient = new Client("James", "Dallas", "USA");
            unClient.ajouteCommande(new Commande(5, 20, true, Mois.Decembre, 3));
            lstClients.Add(unClient);

            unClient = new Client("Frank", "Seatle", "USA");
            unClient.ajouteCommande(new Commande(6, 20, false, Mois.Juillet, 5));
            lstClients.Add(unClient);

            /*I.L’évaluation différée*/
            /*2- Créez une requête LINQ qui permet de récupérer les produits qui coûtent plus que 30.00$.

            var produitPlusDetrenteMile = from unProduit in lstProduits
                                          let nbProduit = lstProduits.Count( x => x.prix >30) //Compte les produits qui son plus grand que 30.
                                          select new { nbProduit };

          
            Console.WriteLine("Nombre de produits: "+produitPlusDetrenteMile.First().nbProduit);
            Console.ReadKey();                     

            /*********************************************************************/

            /*3- Exécutez la requête  en 1-   pour afficher le nombre de produits et la moyenne des prix.

            //PREMIERE FACON
            var produitPlusDetrenteMileEtMoyenne = from unProduit in lstProduits
                                          let nbProduit = lstProduits.Count(x => x.prix > 30) //Compte les produits qui son plus grand que 30.

                                          let moyenneProduitPrix = lstProduits.Where(i => i.prix > 30).Average(n => n.prix) //Moyenne des produits dont le prix est plus grand que 30

                                          select new {nbProduit,moyenneProduitPrix};

            Console.WriteLine("Nombre de produits: " + produitPlusDetrenteMileEtMoyenne.FirstOrDefault().nbProduit + " Moyenne des prix: " + produitPlusDetrenteMileEtMoyenne.FirstOrDefault().moyenneProduitPrix);
            //4- Ajoutez un nouveau produit à la liste des produits. Le numéro du nouveau produit est  7 et son prix est de 70.00$.
            lstProduits.Add(new Produit(7, 70));
            //5- Exécutez encore la requête à nouveau.  Notez que les valeurs affichées ont été mises à jour. 
            //La requête est définie unefois mais peut être exécutée plusieurs fois.
            Console.WriteLine("Nombre de produits: " + produitPlusDetrenteMileEtMoyenne.FirstOrDefault().nbProduit+" Moyenne des prix: "+ produitPlusDetrenteMileEtMoyenne.FirstOrDefault().moyenneProduitPrix);
            Console.ReadKey();

            //DEUXIEME FACON

            var produitsPlusQue30Dollars = from unProduit in lstProduits
                                           where unProduit.prix > 30
                                           select unProduit;


            Console.WriteLine("Nombre de produits: {0}, Moyenne des prix: {1}",
                            produitsPlusQue30Dollars.Count(), produitsPlusQue30Dollars.Average(unPrix => unPrix.prix));

            /*********************************************************************/


            /*II.Quelques requêtes LINQ */
            /*1- Affichez la liste de commandes passées par des clients américains. Afficher toutes les informations d’une commande..
            //PREMIRERE FACON
           var commandesPasseesUsa = from clients
                                   in lstClients
                                  // let clientAmenricain = unClient.pays.Where(i => i.Equals("USA"))
                                   select clients;
                                  


            Console.WriteLine("Commandes passées par des clients américains:");
            foreach(var client in commandesPasseesUsa)
            {

                if (client.pays.Equals("USA"))
                {
                    foreach (var commande in client.listeCommandes)
                    {
                        Console.WriteLine(commande);
                    }
                }
                
                  
                
                 
            }
            Console.ReadKey();


            //DEUXIEME FAÇON
            var commandesPasseesUsa1 = from unClients in lstClients //Va chercher les clients
                                         where unClients.pays.Contains("USA")
                                         from uneCommande in unClients.listeCommandes //Pour ce client, va chercher les commandes
                                         select uneCommande;

            Console.WriteLine("Commandes passées par des clients américains:");
            foreach (var uneUSA in commandesPasseesUsa1)

                Console.WriteLine(uneUSA);
            Console.WriteLine();
            Console.ReadKey();

            /*********************************************************************/

            /*2- Affichez la liste des produits commandés par des clients canadiens.


            var commandesPasseesCanada = from unClients in lstClients //Va chercher les clients
                                         where unClients.pays.Contains("Canada")
                                         from uneCommande in unClients.listeCommandes //Pour ce client, va chercher les commandes
                                         join unProduit in lstProduits
                                         on uneCommande.idproduit equals unProduit.produitID
                                         into lstProduitClient
                                         select new { unClients,uneCommande, lstProduitClient };

            Console.WriteLine("Produits commandées par des clients canadiens:");                          
            foreach(var uneC in commandesPasseesCanada)
            {
                foreach(var produit in uneC.lstProduitClient)
                {
                    Console.WriteLine(produit);
                }
            }

            Console.ReadKey();


            /*********************************************************************/

            /*3- Pour chaque client. Affichez son nom ainsi que le cout de ses commandes.  
            //Le cout est égal à quantité * prix. 

            var coutCommandes = from unClients in lstClients //Va chercher les clients
                                      
                                         from uneCommande in unClients.listeCommandes //Pour ce client, va chercher les commandes
                                         join unProduit in lstProduits
                                         on uneCommande.idproduit equals unProduit.produitID
                                         into lstProduitClient
                                         let cout = lstProduitClient.Sum(x=>x.prix * uneCommande.quantite) 
                                         select new { unClients.nom, uneCommande, lstProduitClient,cout};
            
            Console.WriteLine("Nom".PadRight(10)+"Coût");
            foreach (var commande in coutCommandes)
            {
                
                Console.WriteLine(commande.nom.PadRight(10)+commande.cout+"$.");
            }
            Console.ReadKey();
            /*********************************************************************/

            //4- Utilisez la requête en 3 (le résultat), pour afficher les noms des clients 
            //avec le montant total des couts de leurs commandes.
            var coutCommandesTotal = from unClients in lstClients //Va chercher les clients

                                     from uneCommande in unClients.listeCommandes //Pour ce client, va chercher les commandes
                                     join unProduit in lstProduits
                                     on uneCommande.idproduit equals unProduit.produitID
                                     into lstProduitClient
                                     let cout = lstProduitClient.Sum(x => x.prix * uneCommande.quantite)
                                     
                                   
            //*** comment ramener le total sans que les noms se repete                        
                                    select new { unClients.nom, cout,lstProduitClient };

            Console.WriteLine("Nom".PadRight(10) + "Montant Total");
            foreach (var client in coutCommandesTotal)
            {
                
                Console.WriteLine(client.nom.PadRight(10) + client.cout + "$.");
            }
            Console.ReadKey();

            /*********************************************************************/
        }
    }
}
    

