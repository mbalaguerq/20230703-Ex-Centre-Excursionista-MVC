using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Model
{
    internal class Federat : Soci
    {
        private string nif;
        private Federacio fede;

        public string Nif { get => nif; set => nif = value; }
        internal Federacio Fede { get => fede; set => fede = value; }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Nif: " + nif + "\n" +  "Federació: " + fede;
        }
    }
   
}
