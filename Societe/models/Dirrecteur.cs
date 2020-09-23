namespace Societe.models
{
    public class Dirrecteur : Chef
    {
        private string societe;

        public Dirrecteur(string nom, string prenom, int age, double salaire, string service, string societe) : base(nom, prenom, age, salaire, service) {
            this.societe = societe;
        }

        public override string ToString()
        {
            return $"Nom:{this.nom}, Prenom:{this.prenom}, age:{this.age}, salaire:{this.salaire}, service:{this.service}, societe:{this.societe}";
        }
    }
}