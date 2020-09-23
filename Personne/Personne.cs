using System;

namespace PersonneNS
{
    public class Personne : IDisposable
    {
        protected string nom;
        protected string prenom;
        protected int age;

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
            return $"Nom:{this.nom}, Prenom:{this.prenom}, age:{this.age}";
        }

        public virtual void Afficher() {
            Console.WriteLine(this);
        }

        public static int Combien() {
            return nbPersonne;
        }

        public static Personne operator ++(Personne p)
        {
            p.age += 1; 
            return p;
        }
    }
}