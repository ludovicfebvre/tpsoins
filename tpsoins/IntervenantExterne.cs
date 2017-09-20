using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpsoins
{
    class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        public IntervenantExterne(string unNom, string unPrenom, string uneSpecialite, string uneAdresse, string unTel) : base(unNom, unPrenom)
        {
            this.specialite = uneSpecialite;
            this.adresse = uneAdresse;
            this.tel = unTel;
        }

        public string getSpecialite()
        {
            return this.specialite;
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public string getTel()
        {
            return this.tel;
        }

        public override string ToString()
        {
            return " Spécialité " + specialite + "\n" + "                  " + adresse + " - " + tel + "\n";
        }
    }
}
