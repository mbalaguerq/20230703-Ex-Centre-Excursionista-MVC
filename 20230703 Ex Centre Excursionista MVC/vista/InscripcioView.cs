using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.vista
{
    internal class InscripcioView
    {
        InscripcioController inscripcioController;

        public InscripcioView() { } 
        public InscripcioView(InscripcioController pinscripcioController)
        {
            inscripcioController = pinscripcioController;
        }
    }
}
