using _20230703_Ex_Centre_Excursionista_MVC.Model;
using _20230703_Ex_Centre_Excursionista_MVC.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Controlador
{
    internal class ProgControlador
    {
        CentreExcursionista datos;
        View vista;
        public ProgControlador(CentreExcursionista datos, View vista)
        {
            this.datos = datos;
            this.vista = vista;
        }
        public ProgControlador()
        {
            datos = new CentreExcursionista();
            vista = new View();
        }
        public void gestionMenu()
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion = vista.vistaMenu();
                switch (opcion)
                {
                    case "1":
                        
                        break;
                    case "2":
                       
                        break;
                    case "3":
                        
                        break;
                    case "4":
                       
                        break;
                    case "5":
                        
                        break;
                    case "6":
                        
                        break;
                    case "7":
                        
                        break;
                    case "0":
                        salir = true;
                        break;
                }

            } while (!salir);
        }
    }
}
