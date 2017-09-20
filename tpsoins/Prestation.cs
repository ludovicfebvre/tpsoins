using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpsoins
{
    class Prestation
    {
        private string libelle;
        private DateTime dateSoin;
        private Intervenant l_Intervenant;

        public Prestation(string unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            this.libelle = unLibelle;
            this.dateSoin = uneDate;
            this.l_Intervenant = unIntervenant;


        }

        public int compareTo(Prestation unePrestation)
        {
            if (this.dateSoin.Equals(unePrestation.getDateSoin()))
            {
                return 0;
            }
            else if (this.dateSoin>unePrestation.getDateSoin()){
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public DateTime getDateSoin()
        {
            return this.dateSoin;
        }

        public Intervenant getL_Intervenant()
        {
            return this.l_Intervenant;
        }
        
        public override string ToString()
        {
            string prestation = libelle + " - " + dateSoin.Day + "/" + dateSoin.Month + "/";
            prestation += +dateSoin.Year + " " + dateSoin.Hour + ":" + dateSoin.Minute + ":" + dateSoin.Second + " - ";
            prestation += "Intervenant : Dr " + l_Intervenant.ToString();
            return prestation;
        }
    }
}
