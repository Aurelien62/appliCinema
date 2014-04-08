using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cinema
{
    class films
    {
        private string affiche;
        private string nom;

        public films(string nom, string affiche)
        {
            this.nom = nom;
            this.affiche = affiche;
        }

        public string getAffiche()
        {
            return this.affiche;
        }

        public string getNom()
        {
            return this.nom;
        }

        public void setAffiche(string affiche)
        {
            this.affiche = affiche;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }
    }
}
