using System;

namespace personnes
{
    public class Personne : IDisposable
    {
        private string nom;
        private string prenom;
        private int age;

        private static int nbPersonne;

        public Personne(string nom, string prenom, int age) {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            nbPersonne += 1;
        }
        // Dispose (Avec ça, la méthode statique "Combien" le nombre d'instance en cours d'utilisation (non détruite))
        public void Dispose() {
            nbPersonne -= 1;
            GC.SuppressFinalize(this);
        }

        public override string ToString() {
            return string.Format("Nom : {0}, Prenom : {1}, Age : {2}", this.nom, this.prenom, this.age);
        }

        public void Afficher() {
            Console.WriteLine(this);
        }

        public static int Combien() {
            return nbPersonne;
        }
    }
}