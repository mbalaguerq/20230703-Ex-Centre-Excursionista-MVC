using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Vista 
{ 
    internal class View
    {
        public string vistaMenu()
        {
            string opcion;
            bool salir = false;
                       
            Console.WriteLine("1.Gestión Excursiones ");
            Console.WriteLine("2.Gestión de Socios ");
            Console.WriteLine("3.Gestión de Inscripciones ");            
            Console.WriteLine("0. Salir");
            Console.WriteLine();
            opcion = pedirOpcionMenu();
            do
            {
                switch (opcion)
                {
                    
                    case "1":
                        return menuGestionExcursiones();
                    case "2":
                        return menuGestionSocios();
                    case "3":
                        return menuGestionIns();
                    default:
                        return "0";
                }
            }while(!salir);
        }         
        private string pedirOpcionMenu()
        {
            string opcion;
            do
            {
                Console.WriteLine();
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"0123".Contains(opcion));

            return opcion;
        }
        public string menuGestionExcursiones()
        {            
            string opcion;
            Console.WriteLine();
            Console.WriteLine("1.Añadir Excusión ");
            Console.WriteLine("2.Mostrar Excusiones");// con filtro entre fechas                                                                 
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenuExc();
            
            switch (opcion)
            {
                case "1":
                    return "2.1";   //afegirExcursio();             
                case "2":
                    return "2.2";   //mostrarExcursio();                                               
                default:
                    return "0";                   
            }         
        }
        private string pedirOpcionMenuExc()
        {
            string opcion;
            do
            {
                Console.WriteLine();
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"012".Contains(opcion));

            return opcion;
        }
        public string menuGestionSocios()
        {
            string opcion;
            Console.WriteLine();
            Console.WriteLine("1.Añadir Socio Estándar ");
            Console.WriteLine("2.Modificar tipo de seguro de un socio estándar ");       
            Console.WriteLine("3.Añadir Socio Federado ");
            Console.WriteLine("4.Añadir Socio Infantil ");
            Console.WriteLine("5.Eliminar socio ");
            Console.WriteLine("6.Mostrar Socios"); //(Todos o por tipo de socio)
            Console.WriteLine("7.Mostrar Factura mensual por socios ");
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenuSocio();
            switch (opcion)
            {
                case "1":
                    return "3.1"; //afegirSociEstandar();                   
                case "2":
                    return "3.2"; //modificarAssegurança();                    
                case "3":
                    return "3.3"; //afegirSociFederat();                    
                case "4":
                    return "3.4"; //afegirSociInfantil();                    
                case "5":
                    return "3.5"; //eliminarSoci();                    
                case "6":
                    return "3.6"; //mostrarSocis();                    
                case "7":
                    return "3.7"; //facturaMensualSoci();                    
                default:
                    return "0";
            }
        }
        private string pedirOpcionMenuSocio()
        {
            string opcion;
            do
            {
                Console.WriteLine();
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"01234567".Contains(opcion));

            return opcion;
        }
        public string menuGestionIns()
        {
            string opcion;
            Console.WriteLine();
            Console.WriteLine("1.Añadir Inscripción ");
            Console.WriteLine("2.Eliminar Inscripción ");
            Console.WriteLine("3.Mostar inscripciones");// con las opciones de filtrar por socio y/o fecha           
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenuIns();
            switch (opcion)
            {
                case "1":
                    return "4.1"; //afegirInscripcio();                    
                case "2":
                    return "4.2"; //eliminarInscripcio();                    
                case "3":
                    return "4.3"; //mostrarInscripcions();
                default:
                    return "0";
            }
        }
        private string pedirOpcionMenuIns()
        {
            string opcion;
            do
            {
                Console.WriteLine();
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"0123".Contains(opcion));

            return opcion;
        }

    }
}

    

