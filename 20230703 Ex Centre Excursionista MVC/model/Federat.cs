using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.model
{
    internal class Federat : Soci
    {
        private string nif;
        private Federat fede;

        public string Nif { get => nif; set => nif = value; }
        internal Federat Fede { get => fede; set => fede = value; }
    }
}
