using _20230703_Ex_Centre_Excursionista_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.model
{
    internal class Assegurança
    {
        private decimal precio;
        private TipoSeguro ts;

        public decimal Precio { get => precio; set => precio = value; }
        internal TipoSeguro Ts { get => ts; set => ts = value; }
    }
}
