using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpsoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3));
            unDossier.ajouterPrestation("Libelle P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            unDossier.ajouterPrestation("Libelle P1", new DateTime(2015, 9, 1, 12, 0, 0), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"));
            unDossier.ajouterPrestation("Libelle P2", new DateTime(2015, 9, 8, 12, 0, 0), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
            unDossier.ajouterPrestation("Libelle P4", new DateTime(2015, 9, 20, 12, 0, 0), new Intervenant("Maurin", "Joëlle"));
            unDossier.ajouterPrestation("Libelle P6", new DateTime(2015, 9, 8, 9, 0, 0), new Intervenant("Blanchard", "Michel"));
            unDossier.ajouterPrestation("Libelle P5", new DateTime(2015, 9, 10, 6, 0, 0), new Intervenant("Tournier", "Hélène"));

            Console.WriteLine(unDossier);
            Console.ReadKey();
        }
    }
}
