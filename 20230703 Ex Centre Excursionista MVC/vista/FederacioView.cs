using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Vista
{
    internal class FederacioView
    {
        FederacioController federacioController;

        public FederacioView() { }
        public FederacioView(FederacioController pfederacioController)
        {
            federacioController = pfederacioController;
        }
    }
}
