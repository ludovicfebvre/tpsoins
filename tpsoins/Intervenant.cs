using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpsoins
{
    class Intervenant
    {
        private string nom;
        private string prenom;
        private List<Prestation> lesPrestations;

    
        public Intervenant(string unNom, string unPrenom)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            lesPrestations = new List<Prestation>();
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public void ajouterPrestation(Prestation unePrestation)
        {
            lesPrestations.Add(unePrestation);
        }

        public override string ToString()
        {
            return nom + " - " + prenom ;
        }
    }
}
