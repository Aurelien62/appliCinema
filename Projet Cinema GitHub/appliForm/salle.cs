using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cinema
{
    public class salle
    {
        #region déclarations des variables
        private int nbPlace;
        private int nbPlaceTarifNormal;
        private int nbPlaceTarifReduit;
        private int pourcentageReduction = 80;
        private double prix;
        #endregion

        public double chiffreAffaires()
        {
            double CA;
            CA = 0;

            return CA;
        }

        public string Salle(String titre, int nbPlace, double prixPlace, String photoAffiche)
        {
            string salle;
            salle = "";
            return salle;
        }

        public int tauxRemplissage()
        {
            int txRempli;
            txRempli = 0;

            return txRempli;
        }

        public override string ToString()
        {
            string laSalle;
            double ht = this.uneSalle.getPrixHt();
            double tva = this.uneSalle.calculValeurTVA();
            double ttc = this.uneSalle.calculPrixTTC();
            laSalle = "la salle : " + uneSalle;
            return laSalle;
        }

        public int vendrePlaces(int nbre, bool tarifReduit)
        {
            int place;
            place = 0;

            return place;
        }

        public int nbPlacesDisponibles()
        {
            int lesPlace;
            lesPlace = 0;

            return lesPlace;
        }
    }
}
