using System;
using System.Collections;
using PersonneNS;
using Societe.models;

namespace SocieteListe
{
    public class Liste
    {
        private Element debut;
        private int nbElement;
        
        public Liste() {
            this.debut = null;
            this.nbElement = 0;
        }

        public int NbElement {
            get { return this.nbElement; }
        }

        // Define the indexer to allow client code to use [] notation.
        public Element this[ int index ]
        {
            get // élément [index] lu
            {
                if (index > this.nbElement) {
                    throw new Exception("Out the limits.");
                }
                Element actual = this.debut;
                for (int i = 0 ; i < index ; i++) {
                    actual = actual.Suivant;
                }
                return actual;
            } 
        }


        public void InsererFin(Object objet) {
            Element element = new Element(objet);
            if (this.debut == null) {
                this.debut = element;
                return;
            }

            Element actual = this.debut;
            while (actual.Suivant != null) {
                actual = actual.Suivant;
            }

            // SUivant == null
            actual.Suivant = element;
            this.nbElement++;
        }

        public void InsererFinR(Object objet, Element current = null) {
            if (this.debut == null) {
                this.debut = new Element(objet);
            }
            if (current == null) {
                current = this.debut;
            }
            if (current.Suivant != null) {
                InsererFinR(objet, current.Suivant);
            }
            current.Suivant = new Element(objet);
            this.nbElement++;

        }

        public void InsererDebut(Object objet) {
            Element element = new Element(objet);
           
           if (this.debut == null) {
               this.debut = element;
               return;
           }

           Element temp = this.debut;
           this.debut = element;
           this.debut.Suivant = temp;
           this.nbElement++;
        }

        public void Lister() {
            Element actual = this.debut;
            if (this.debut != null) {
                while (actual.Suivant != null) {
                    Console.WriteLine(actual.Objet);
                    actual = actual.Suivant;
                }
                Console.WriteLine(actual.Objet);
            }
        }

        public void Vider() {
            this.debut = null;
        }
    }
}