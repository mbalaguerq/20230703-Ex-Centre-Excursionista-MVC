using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.vista
{
    internal class SociView
    {
        SociController SociController;
        public SociView() { }
        public SociView(SociController psociController) 
        {
            SociController = psociController;
        }

    }
}
