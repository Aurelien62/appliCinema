using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cinema
{
    public class salle : films
    {
        #region déclarations des variables
        private int nbPlace1;
        private int nbPlaceTarifNormal1;
        private int nbPlaceTarifReduit1;
        private int pourcentageReduction = 80;
        private double prix;
        private string titreFilm;
        private List<salle> lesSalles;
        List<salle> uneSalle = new List<salle>();
        #endregion


        #region fonction/procédure
        public double chiffreAffaires()
        {
            double CA;
            CA = 0;

            return CA;
        }

        public string Salle(String titre, int nbPlace, double prixPlace, String photoAffiche)
        {
            string Ssalle;
            titre = this.titreFilm;
            nbPlace = this.nbPlace1;
            prixPlace = this.prix;
            Ssalle = titre + nbPlace + prixPlace;
            return Ssalle;
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
            laSalle = "la salle : " + titreFilm + nbPlace1 + prix ;
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
        #endregion

        #region accesseur modificateur
        #endregion
    }
}
