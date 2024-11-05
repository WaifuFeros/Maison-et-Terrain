using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplePOO
{
    public class Proprietaire
    {
        public string Nom;
        public string Prenom;
        public List<Bien> Biens;

        public Proprietaire(string Nom, string Prenom, List<Bien> Biens)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Biens = Biens;
        }
    }
}
