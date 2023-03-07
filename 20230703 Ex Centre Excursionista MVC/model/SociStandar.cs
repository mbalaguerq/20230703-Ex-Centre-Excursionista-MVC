using _20230703_Ex_Centre_Excursionista_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.model
{
    internal class SociStandar : Soci
    {
        private string nif;
        private TipoSeguro tipusasseg;
        public string Nif { get => nif; set => nif = value; }
        internal TipoSeguro Tipusasseg { get => tipusasseg; set => tipusasseg = value; }
    }
}
