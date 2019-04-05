using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_De_Grattage
{
    class Jeu
    {
        private int[,] carte;

        public Jeu(int[,] carte)
        {
            for (int i = 0; i < carte.Length; i++ )
            {
                for (int j = 0; j < carte.Length; j++)
                {

                }
            }

            this.carte = carte;
        }

        public int Gagne()
        {
            return -1;
        }

        public override string  ToString()
        {
 	         return "";
        }
    }
}
