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

        public override string ToString()
        {
            string toString = $"Nom = {Nom}\n";
            toString += $"Prénom = {Prenom}\n";
            toString += "Biens :\n";
            foreach (var bien in Biens)
                toString += bien.ToString() + "\n";
            return toString;
        }
    }
}
