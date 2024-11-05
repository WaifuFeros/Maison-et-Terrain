using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExemplePOO
{
    public class Terrain
    {
        public string Adresse;
        public float Superficie;
        public int NbCotesClotures;
        public bool Riviere;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Adresse = {Adresse}");
            sb.AppendLine($"Superficie = {Superficie}m²");
            sb.AppendLine($"Nombre de clotures = {NbCotesClotures}");
            sb.AppendLine($"Présence d'un jardin = {(Riviere ? "Oui" : "Non")}");
            sb.AppendLine($"> VALEUR = {EvaluationValeur()}$");
            return sb.ToString();
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            if (Riviere)
                facteur += 500;

            facteur += CoutFinirCloture();

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.Superficie * facteur;
        }

        public int CoutFinirCloture()
        {
            int cout = 0;
            return cout;
        }
    }
}
