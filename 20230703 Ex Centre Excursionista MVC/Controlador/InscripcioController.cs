using _20230703_Ex_Centre_Excursionista_MVC.Model;
using _20230703_Ex_Centre_Excursionista_MVC.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Controlador
{
    internal class InscripcioController
    {
        CentreExcursionista datos;

        public InscripcioController(CentreExcursionista pdatos)
        {
            datos = pdatos;
        }
    }
}
