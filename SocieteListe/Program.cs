using System;
using Societe.models;

namespace SocieteListe
{
    class Program
    {
        static void Main(string[] args)
        {
            Liste maListe = new Liste();
            maListe.Lister();

            Employe emp1 = new Employe("emp1", "emp1", 22, 2200.00);
            Employe emp2 = new Employe("emp2", "emp2", 22, 2200.00);
            Employe emp3 = new Employe("emp3", "emp3", 22, 2200.00);
            Employe emp4 = new Employe("emp4", "emp4", 22, 2200.00);
            Chef chf1 = new Chef("chef1", "chef1", 40, 32000, "Informatique");
            Chef chf2 = new Chef("chef2", "chef2", 40, 32000, "Comptabilité");
            Dirrecteur dir1 = new Dirrecteur("dir1", "dir1", 55, 80000, "CEO", "Orange");

            /**maListe.InsererDebut(emp1);
            maListe.InsererDebut(emp2);
            maListe.InsererDebut(emp3);
            maListe.InsererDebut(emp4);
            maListe.InsererDebut(chf1);
            maListe.InsererDebut(chf2);
            maListe.InsererDebut(dir1); */


            maListe.InsererDebut(emp1);
            maListe.InsererDebut(emp2);
            maListe.InsererDebut(emp3);
            maListe.InsererDebut(emp4);
            maListe.InsererDebut(chf1);
            maListe.InsererDebut(chf2);
            maListe.InsererDebut(dir1);

            maListe.Lister();
            Console.WriteLine(maListe[0]);
            Console.WriteLine(maListe[6]);
        }
    }
}
