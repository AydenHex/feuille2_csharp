namespace Societe.models
{
    public class Chef : Employe
    {
        protected string service;

        public Chef(string nom, string prenom, int age, double salaire, string service) : base(nom, prenom, age, salaire) {
            this.service = service;
        }

        public string Service{ 
            get { return this.service; }
            set { this.service = value; }
        }

        public override string ToString()
        {
            return $"Nom:{this.nom}, Prenom:{this.prenom}, age:{this.age}, salaire:{this.salaire} service:{this.service}";
        }
    }
}