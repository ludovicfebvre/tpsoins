using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpsoins
{
    class Dossier
    {
        private string nomPatient;
        private string prenomPatient;
        private DateTime dateNaissancePatient;
        private List<Prestation> mesPrestations;

        public Dossier (string unNomPatient, string unPrenomPatient, DateTime uneDate)
        {
            this.nomPatient = unNomPatient;
            this.prenomPatient = unPrenomPatient;
            this.dateNaissancePatient = uneDate;
            mesPrestations = new List<Prestation>();
        }

        public Dossier(string unNomPatient, string unPrenomPatient, DateTime uneDate, Prestation unePrestation)
        {
            this.nomPatient = unNomPatient;
            this.prenomPatient = unPrenomPatient;
            this.dateNaissancePatient = uneDate;
            mesPrestations = new List<Prestation>();
            mesPrestations.Add(unePrestation);
        }

        public void ajouterPrestation(string unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            this.mesPrestations.Add(new Prestation(unLibelle, uneDate, unIntervenant));
        }

        public int getNbPrestationsExternes()
        {
            int cpt = 0;
            foreach (Prestation unePrestation in mesPrestations)
            {
                if (unePrestation.getL_Intervenant() is IntervenantExterne)
                {
                    cpt++;
                }
            }
            return cpt;
        }

        public int getNbPrestations()
        {
            return mesPrestations.Count;
        }
        
        public int getNbJoursSoins()
        {
            List<DateTime> mesDates = new List<DateTime>();
            foreach (Prestation unePrestation in mesPrestations)
            {
                if (!mesDates.Contains(unePrestation.getDateSoin()))
                {
                    mesDates.Add(unePrestation.getDateSoin());
                }
            }
            return mesDates.Count();
        }

        public override string ToString()
        {
            string dossier;
            dossier = "\nNombre de dossiers : 1" + "\n" + "----- Début dossier ---------------\n";
            dossier += "Nom : " + nomPatient + " Prénom : " + prenomPatient + " Date de naissance : " + dateNaissancePatient.Day + "/" + dateNaissancePatient.Month + "/" + dateNaissancePatient.Year + "\n";
            foreach (Prestation unePrestation in mesPrestations)
            {
                dossier += unePrestation.ToString();
            }
            dossier += "\n" + "Nombre de jours de soins V1 : " + this.getNbJoursSoins()+ " \n";
            dossier += "Nombre de soins externes : " + this.getNbPrestationsExternes() + "\n";
            dossier += "----- Fin dossier ---------------\n";
            dossier += "\n";
            return dossier;
        }

        public string AfficherTous()
        {
            return "";
        }
    }
}
