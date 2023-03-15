using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Model
{
    internal class SociStandar : Soci
    {
        private string nif;
        private Assegurança assegurança;
        public string Nif { get => nif; set => nif = value; }
        internal Assegurança Assegurança { get => assegurança; set => assegurança = value; }

        public override string ToString()
        {
            return base.ToString() + "Nif: \t " + nif + "\n" + GetType().Name + "\n" +
                                     "Assegurança: \t" + assegurança;
        }
    }
    
}
