using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Model
{
    internal abstract class Soci
    {
        private int nsoci;
        private string nom;
       
       
        public int Nsoci { get => nsoci; set => nsoci = value; }
        public string Nom { get => nom; set => nom = value; }
        

        public override string ToString()
        {
            return "Número de soci: " + "\t" + nsoci + "\n" +
                   "Nom: \t" + nom + "\n";
        }
    }
}
