using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Model
{
    internal class Excursio
    {
        private string descripcio;
        private DateTime data;
        private int codi;
        private decimal preu;
        private int ndies;

        public string Descripcio { get => descripcio; set => descripcio = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Codi { get => codi; set => codi = value; }
        public decimal Preu { get => preu; set => preu = value; }
        public int Ndies { get => ndies; set => ndies = value; }
        public override string ToString()

        {
            return Descripcio + "\n" + Codi + " \n " + Data +
                   Preu + Ndies;
        }
    }
}
