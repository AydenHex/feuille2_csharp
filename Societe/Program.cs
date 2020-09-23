using System;
using PersonneNS;
using Societe.models;

namespace societe
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe emp1 = new Employe("emp1", "emp1", 22, 2200.00);
            Employe emp2 = new Employe("emp2", "emp2", 22, 2200.00);
            Employe emp3 = new Employe("emp3", "emp3", 22, 2200.00);
            Employe emp4 = new Employe("emp4", "emp4", 22, 2200.00);
            Chef chf1 = new Chef("chef1", "chef1", 40, 32000, "Informatique");
            Chef chf2 = new Chef("chef2", "chef2", 40, 32000, "Comptabilité");
            Dirrecteur dir1 = new Dirrecteur("dir1", "dir1", 55, 80000, "CEO", "Orange");
            Personne[] tableauPersonne = new Personne[] {
                emp1,
                emp2,
                emp3,
                emp4,
                chf1,
                chf2,
                dir1
            };

            for (var i = 0 ; i < tableauPersonne.Length ; i++ ) {
                tableauPersonne[i].Afficher();
            }

            tableauPersonne[0]++;
            chf1.Salaire = 70000;
            chf1.Service = "BTP";

            foreach(var personne in tableauPersonne) {
                personne.Afficher();
            }
        }
    }
}
