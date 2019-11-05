using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demoLinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
         /*     
               // 1- Création d'un élément XML
               XElement unElement = new XElement("Cours", "420-5B6");
               // Écrire l'élément
               Console.WriteLine(unElement);
               // Écrire le nom de l'élément
               Console.WriteLine(unElement.Name); 
               // Écrire la valeur de l'élément
               Console.WriteLine((String) unElement); 
               //ou
               Console.WriteLine(unElement.Value);
               Console.ReadKey();
                // ***********************************************************************************/

            /*
           
              // 2- Création d'un élément XML avec un attribut
              XElement unElement = new XElement("Cours", new XAttribute("Prof", "Ferroudja"), "420-5B6");
              // Écrire l'élément
              Console.WriteLine(unElement);
              // Écrire le nom de l'élément
              Console.WriteLine(unElement.Name); 
              // Écrire la valeur de l'élément
              Console.WriteLine((String)unElement);
              // Écrire l'attribut Prof
              Console.WriteLine(unElement.Attribute("Prof"));
            
              // Écrire la valeur de l'attribut Prof
              Console.WriteLine((string) unElement.Attribute("Prof"));
             
              Console.ReadKey();
            // ***********************************************************************************/

            /*
                  // 3- Création d'un document XML avec des sous-éléments
                  XDocument unDocument = new XDocument();
                  // Ajout d'un élément au document
                  unDocument.Add(new XComment("Commentaire"));
                  unDocument.Add(new XElement("Cegep", new XAttribute("Lieu", "Ste-Geneviève"), "Gerald-Godin", new XElement("Prof", "Alain"), new XElement("Prof", "Louis-Marie")));
                   // Écrire le document
                  Console.WriteLine(unDocument);
                  Console.ReadKey();
                  // ***********************************************************************************/
            
            /*
           // 4- Création et sauvegarde d'un document XML
           XDocument unDocument = new XDocument();
           // Ajout d'un élément au document
           unDocument.Add(new XComment("Par moi"));
           unDocument.Add(new XElement("Cours", new XAttribute("Prof", "Ferroudja"), "420-5B6", new XElement("Annee", "2018")));
           // Écrire le document
           Console.WriteLine(unDocument);
           Console.ReadKey();
           // Sauver le document
           unDocument.Save("Test.xml");
      // ***********************************************************************************/
            /*
               // 5- Chargement d'un document XML et écriture du document 
               XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
               Console.WriteLine(docResto);
               Console.ReadKey();

               // ***********************************************************************************/

            
           /*
            // 6- Tous les types de menus
            XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
            var TousLesTypesDeMenus = from unResto in docResto.Elements("restaurant")
                                      from unMenu in unResto.Elements("menu") 
                                      select unMenu.Attribute("type");
            
            // Peut être de type var ( l'inférence de type)
            foreach (XAttribute unTypeDeMenu in TousLesTypesDeMenus)
                Console.WriteLine(unTypeDeMenu);

            foreach (XAttribute unTypeDeMenu in TousLesTypesDeMenus)
                Console.WriteLine((string) unTypeDeMenu);

            Console.ReadKey();
          
              // **********************************************************************************/
            
            /*
                 // 7- Tous les desserts qui ont moins que 300 calories
                 XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
                 var TousLesDessertsMoinsDe300Calories =
                     from unResto in docResto.Elements("restaurant")
                     from unMenu in unResto.Elements("menu")
                     from unDessert in unMenu.Elements("desserts")
                     from unNom in unDessert.Elements("nom")
                     where (int)unNom.Attribute("calories") < 300
                     select unNom;

                 foreach (XElement unDessert in TousLesDessertsMoinsDe300Calories)
                     Console.WriteLine(unDessert);

                 foreach (XElement unDessert in TousLesDessertsMoinsDe300Calories)
                    Console.WriteLine((string) unDessert);
               

                 Console.ReadKey();
            
                  // ***********************************************************************************/
            
            /*
                  // 8a- Tous les mets qui ont moins de 500 calories
                  XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
                  var TousLesMetstquiOntMontMoinsDe500Calories =
                      from unResto in docResto.Elements("restaurant")
                         from unMenu in unResto.Elements("menu")
                         from elementMenu in unMenu.Elements()  // Ici,ce sont tous les sous-élements du menu
                          from unNom in elementMenu.Elements("nom")
                      where unNom.Attribute("calories") != null && (int)unNom.Attribute("calories") < 500 
                          select unNom;

                  foreach (XElement unMetsDeMoinsDe500Calories in TousLesMetstquiOntMontMoinsDe500Calories)
                      Console.WriteLine(unMetsDeMoinsDe500Calories);

                  Console.ReadKey();
                  // ***********************************************************************************/

            /*
                    // 8b- Tout ce qui a un nom et qui a moins que 500 calories (autre façon pour la 8a)
                   XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
                   var TousLesMestquiOntMoinsDe500Calories =
                       from unNom in docResto.Descendants("nom") // On recherche dans tous les descendants du resto - tant qu'ils ont un nom
                       where unNom.Attribute("calories") != null && (int)unNom.Attribute("calories") < 500 
                           select unNom;

                   foreach (XElement unAffaire in TousLesMestquiOntMoinsDe500Calories)
                       Console.WriteLine(unAffaire);


                   Console.ReadKey();
                    // ***********************************************************************************/
           /*
   
           // 9- Tout ce qui a des calories et tout ce qui n'a pas de calories (regroupés) 
           XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
           var CategoriesOntDesCalories =
               from unNom in docResto.Descendants("nom") // On recherche dans tous les descendants du resto - tant qu'ils ont un nom
               group unNom by unNom.Attribute("calories") != null;

            foreach (var uneCategorieCalorie in CategoriesOntDesCalories)
                if (uneCategorieCalorie.Key)
                {
                    Console.WriteLine("Ont des calories:\n");
                    foreach (XElement uneCatCalorie in uneCategorieCalorie)
                        Console.WriteLine(uneCatCalorie);
                }
                else
                
                {
                    Console.WriteLine("\n\nN'ont pas de calories:\n");
                    foreach (XElement uneCatCalorie in uneCategorieCalorie)
                        Console.WriteLine(uneCatCalorie);
                }
            
             Console.ReadKey();
            // ***********************************************************************************/
            /*
             // 10- Sélectionnez le nombre d'entrées qu'il y a dans chaque menu
              XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
              var NbEntreesParMenu =
                  from unResto in docResto.Elements("restaurant")
                     from unMenu in unResto.Elements("menu")
                         from uneEntree in unMenu.Elements("entrees")
                        // select new { typeMenu = (string)unMenu.Attribute("type"), nbEntrees = uneEntree.Elements("nom").Count() };
                  select new { typeMenu = unMenu.Attribute("type").Value, nbEntrees = uneEntree.Elements("nom").Count() };


              foreach (var unMenu in NbEntreesParMenu)
              {
                  Console.WriteLine("Le menu de type {0} a {1} entrées", unMenu.typeMenu, unMenu.nbEntrees );
              }

              Console.ReadKey();
             // ***********************************************************************************/

            /*
            // 11- Calculez la moyenne des prix des tous les menus.
             XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
             var PrixDesMenus =
                 from unResto in docResto.Elements("restaurant")
                    from unMenu in unResto.Elements("menu")
                        select new  {prix = (double) unMenu.Attribute("prix")};
            

             double moyenneDesPrix = PrixDesMenus.Average(unMenu => unMenu.prix);

             Console.WriteLine("La moyenne des prix est {0:C}", moyenneDesPrix,3);
             Console.ReadKey();
              // ***********************************************************************************/

           
                  /* 12- Augmentez le prix de 10% de tous les menus
                  XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
                  var TousLesMenus =
                      from unResto in docResto.Elements("restaurant")
                      from unMenu in unResto.Elements("menu")
                      select unMenu;

                  foreach (XElement unMenu in TousLesMenus)
                  {
                      unMenu.Attribute("prix").SetValue((double) unMenu.Attribute("prix") * 1.1); 
                  }

                 docResto.Save("RestoAvecMenuDuJourEtPrixModifie.xml");
                 // ***********************************************************************************/

            
              /*13- Supprimer le poulet au curry du menu gatronomique
            
              XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
              var ElementPouletAuCurry =
                  from unMenu in docResto.Descendants("menu")
                  where (string) unMenu.Attribute("type") == "gastronomique"
              
                   from unNom in unMenu.Descendants("nom")
                   where (string) unNom== "poulet au curry"
                    select unNom;


              ElementPouletAuCurry.Remove();         
              Console.ReadKey();
              docResto.Save("RestoSansPouletAuCurry.xml");   
              // ***********************************************************************************/

            
            // 14- Ajouter un canard à l'orange de 700 calories dans les plats du menu gastronomqiue
            XDocument docResto = XDocument.Load("RestoAvecMenuDuJour.xml");
            var ElementPlatsMenuGastronomique =
                from unMenu in docResto.Descendants("menu")
                where (string)unMenu.Attribute("type") == "gastronomique"
                select unMenu.Element("plats");

            XElement unPlat = new XElement("nom", new XAttribute("calories","700"), "canard à l'orange");
  
            ElementPlatsMenuGastronomique.Last().Add(unPlat); // ajouté en tant qu'enfant
          

            Console.ReadKey();
            docResto.Save("RestoAvecCanardALorange.xml");   
             // ***********************************************************************************/

        }

        //public static IEnumerable<XElement> TousLesMetsquiOntMontMoinsDe500Calories { get; set; }
        
    }
}
