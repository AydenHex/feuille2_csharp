using System;
using System.Collections;
using PersonneNS;
using Societe.models;

namespace SocieteEnum
{
    public class ListeEnumeration : IEnumerator
    {
        private Liste liste;
        private int indiceCourant;

        public object CurrentObject;

        public ListeEnumeration(Liste liste) {
            this.liste = liste;
            this.indiceCourant = -1;
            this.CurrentObject = null;
        }

        /**public Object Current {
            get {
                this.CurrentObject = this.liste[indiceCourant];
                return this.CurrentObject;
            }
        }*/

        public bool MoveNext() {
            this.indiceCourant++;
            return (this.indiceCourant < this.liste.NbElement);
        }

        public void Reset() {
            this.CurrentObject = null;
            this.indiceCourant = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Element Current
        {
            get
            {
                try
                {
                    return this.liste[this.indiceCourant];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        
    }
}