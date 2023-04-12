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
                       
            Console.WriteLine("1.Gestió Excursions ");
            Console.WriteLine("2.Gestió de Socis ");
            Console.WriteLine("3.Gestió d'Inscripcions ");            
            Console.WriteLine("0. Sortir");
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
            Console.WriteLine("1.Afegir Excusió ");
            Console.WriteLine("2.Mostrar Excusions");// con filtro entre fechas
            Console.WriteLine("3.Llegir excursions d'un arxiu CSV");
            Console.WriteLine("4.Gravar excursions a CSV");
            Console.WriteLine("Afegir excursions a partir de CSV ");
            Console.WriteLine("0. Sortir");
            opcion = pedirOpcionMenuExc();
            
            switch (opcion)
            {
                case "1":
                    return "2.1";   //afegirExcursio();             
                case "2":
                    return "2.2";   //mostrarExcursio();
                case "3":
                    return "2.3";   //leerCSV()
                case "4":
                    return "2.4";   //grabarCSV();
                case "5":
                    return "2.5";   //carregaCSV();
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
            } while (!"012345".Contains(opcion));

            return opcion;
        }
        public string menuGestionSocios()
        {
            string opcion;
            Console.WriteLine();
            Console.WriteLine("1.Afegir Soci Standar ");
            Console.WriteLine("2.Modificar tipus d'assegurança d'un soci Sstandar ");       
            Console.WriteLine("3.Afegir Soci Federat ");
            Console.WriteLine("4.Afegir Soci Infantil ");
            Console.WriteLine("5.Eliminar soci ");
            Console.WriteLine("6.Mostrar Socis"); //(Todos o por tipo de socio)
            Console.WriteLine("7.Mostrar Factura mensual per socis ");
            Console.WriteLine("0.Sortir");
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
            Console.WriteLine("1.Afegir Inscripció ");
            Console.WriteLine("2.Eliminar Inscripció ");
            Console.WriteLine("3.Mostar inscripcions");// con las opciones de filtrar por socio y/o fecha           
            Console.WriteLine("0. Sortir");
            opcion = pedirOpcionMenuIns();
            switch (opcion)
            {
                case "1":
                    return "4.1"; //afegirInscripcio();                    
                case "2":
                    return "4.2"; //eliminarInscripcio();                    
                case "3":
                    return menuLlistaIns(); //mostrarInscripcions();
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
        public string menuLlistaIns()
        {
            string opcion;
            Console.WriteLine();
            Console.WriteLine("1.Filtrar per Soci: ");
            Console.WriteLine("2.Filtrar per Data: ");                       
            Console.WriteLine("0. Sortir");
            opcion = pedirOpcionListaIns();

            switch (opcion)
            {
                case "1":
                    return "5.1"; //LlistaInscripBySoci();                    
                case "2":
                    return "5.2"; //LlistaInscripByData();                    
                
                default:
                    return "0";
            }
        }
        private string pedirOpcionListaIns()
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

    }
}

    

