using System;

namespace use_OperatorMethods {
    class Program {
        static void Main(string[] args) {

            CollectionCartes col = new CollectionCartes();
            Carte c1 = new Carte("Rockanos");
            Carte c2 = new Carte("Djiinaos");

            // ajouter des cartes
            col += c1;
            col += c1; 
            col += c2;
            foreach (var c in col.Cartes) {
                Console.WriteLine("key {0}, value {1}",c.Key.Name,c.Value);
            }
            Console.WriteLine();

            // Recherche d'une carte par index
            var c3 = col["Djiinaos"];
            Console.WriteLine("key {0}, value {1}", c3.Key.Name, c3.Value);
            c3 = col["blah"];
            Console.WriteLine("key {0}, value {1}", c3.Key.Name, c3.Value);



        }
    }
}
