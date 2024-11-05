using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            sb += String.Format("Nombre de pièces = {0}", this.NbPieces);
            sb.AppendLine($"Présence d'un jardin = {(Riviere ? "Oui" : "Non")}");
            sb.AppendLine($"> VALEUR = {EvaluationValeur()}$");
            return sb.ToString();
        }

        public float EvaluationValeur()
        {
            float valeur = 0;

            return valeur;
        }

        public int CoutFinirCloture()
        {
            int cout = 0;
            return cout;
        }
    }
}
