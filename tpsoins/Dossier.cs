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

        /// <summary>
        /// Constructeur de la classe dossier
        /// </summary>
        /// <param name="unNomPatient"></param>
        /// <param name="unPrenomPatient"></param>
        /// <param name="uneDate"></param>
        public Dossier (string unNomPatient, string unPrenomPatient, DateTime uneDate)
        {
            this.nomPatient = unNomPatient;
            this.prenomPatient = unPrenomPatient;
            this.dateNaissancePatient = uneDate;
            mesPrestations = new List<Prestation>();
        }


        /// <summary>
        /// Constructeur de la classe dossier
        /// </summary>
        /// <param name="unNomPatient"></param>
        /// <param name="unPrenomPatient"></param>
        /// <param name="uneDate"></param>
        /// <param name="unePrestation"></param>
        public Dossier(string unNomPatient, string unPrenomPatient, DateTime uneDate, Prestation unePrestation)
        {
            this.nomPatient = unNomPatient;
            this.prenomPatient = unPrenomPatient;
            this.dateNaissancePatient = uneDate;
            mesPrestations = new List<Prestation>();
            mesPrestations.Add(unePrestation);
        }

        /// <summary>
        /// Ajoute une préstation à la liste de préstation
        /// </summary>
        /// <param name="unLibelle"></param>
        /// <param name="uneDate"></param>
        /// <param name="unIntervenant"></param>
        public void ajouterPrestation(string unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            this.mesPrestations.Add(new Prestation(unLibelle, uneDate, unIntervenant));
        }

        /// <summary>
        /// Obtient le nombre de prestatation Externe
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Obtient le nombre de prestation
        /// </summary>
        /// <returns></returns>
        public int getNbPrestations()
        {
            return mesPrestations.Count;
        }
        
        /// <summary>
        /// Obtient le nombre de jours de soins
        /// </summary>
        /// <returns></returns>
        public int getNbJoursSoins()
        {
            List<DateTime> mesDates = new List<DateTime>();
            foreach (Prestation unePrestation in mesPrestations)
            {
                if (!mesDates.Contains(unePrestation.getDateSoin().Date))
                {
                    mesDates.Add(unePrestation.getDateSoin());
                }
            }
            return mesDates.Count();
        }

        /// <summary>
        /// Affiche les elements d'un dossier
        /// </summary>
        /// <returns></returns>
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

    }
}
