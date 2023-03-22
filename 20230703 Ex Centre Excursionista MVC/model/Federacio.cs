using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Model
{
    internal class Federacio
    {
        private int codi;
        private string nom;

        public int Codi { get => codi; set => codi = value; }
        public string Nom { get => nom; set => nom = value; }
        public override string ToString()
        {
            return  "\nCodi: " + "\t" + codi + "\n" + nom;
        }
    }
}
