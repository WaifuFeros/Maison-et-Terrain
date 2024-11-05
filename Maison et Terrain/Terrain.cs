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
            return base.ToString();
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
