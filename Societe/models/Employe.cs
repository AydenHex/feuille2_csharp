using System;
using PersonneNS;

namespace Societe.models
{
    public class Employe : Personne
    {
        protected double salaire;

        public Employe(string nom, string prenom, int age, double salaire) : base (nom, prenom, age) {
            this.salaire = salaire;
        }

        public double Salaire {
            get { return this.salaire; }
            set { this.salaire = value; }
        }

        public override string ToString() {
            return $"Nom:{this.nom}, Prenom:{this.prenom}, age:{this.age}, salaire:{this.salaire}";
        }

        public override void Afficher() {
            Console.WriteLine(this);
        }
    }
}