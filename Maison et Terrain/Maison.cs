using System;
using System.Text.RegularExpressions;

namespace ExemplePOO
{
    public class Maison : Bien
    {
        public int NbPieces;
        public bool Jardin;
        public List<Piece> Pieces;

        public Maison(string adresse, float superficie, int nbPieces, bool jardin, List<Piece> pieces) : base(adresse, superficie)
        {
            NbPieces = nbPieces;
            Jardin = jardin;
            Pieces = pieces;
        }

        public override string ToString()
        {
            string toString = base.ToString();
            toString += String.Format("Nombre de pièces = {0}\n", this.NbPieces);
            toString += String.Format("Présence d'un jardin = {0}\n", this.Jardin ? "Oui" : "Non");
            toString += "Pièces :";
            foreach (Piece piece in Pieces)
                toString += "- " + piece.ToString();
            toString += String.Format("> VALEUR = {0}$\n", this.EvaluationValeur());
            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Jardin) { facteur += 500; }
            if (this.NbPieces > 3) { facteur += 200; }

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.Superficie * facteur;
        }
    }
}