using _20230703_Ex_Centre_Excursionista_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.model
{
    internal class Inscripcio
    {
        private int nIns;
        private Excursio excursio;
        private Soci Soci;

        public int NIns { get => nIns; set => nIns = value; }
        internal Excursio Excursio { get => excursio; set => excursio = value; }
        internal Soci Soci1 { get => Soci; set => Soci = value; }
    }
}
