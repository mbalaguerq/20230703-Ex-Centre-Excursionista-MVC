using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.vista
{
    internal class AssegurView
    {
        AssegurController assegurController;
        public AssegurView() { }
        public AssegurView(AssegurController passegurController)
        {
            assegurController = passegurController;
        }
    }
}
