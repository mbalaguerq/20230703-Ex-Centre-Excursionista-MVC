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
            Console.WriteLine("1.Carga de parámetros ");
            Console.WriteLine("2.Gestión Excursiones ");
            Console.WriteLine("3.Gestión de Socios ");
            Console.WriteLine("4.Gestión de Inscripciones ");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            Console.WriteLine("8. ");
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenu();
            return opcion;
        }
        private string pedirOpcionMenu()
        {
            string opcion;
            do
            {
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"01234".Contains(opcion));

            return opcion;
        }
        public string menuGestionExcursiones()
        {
            string opcion;
            Console.WriteLine("1.Añadir Excusión ");
            Console.WriteLine("2.Mostrar Excusiones");// con filtro entre fechas
            Console.WriteLine("3.Gestión de Inscripciones ");                                                      
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenuExc();
            return opcion;
        }
        private string pedirOpcionMenuExc()
        {
            string opcion;
            do
            {
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"0123".Contains(opcion));

            return opcion;
        }
        public string menuGestionSocios()
        {
            string opcion;
            Console.WriteLine("1.Añadir Socio Estándar ");
            Console.WriteLine("2.Modificar tipo de seguro de un socio estándar ");
            Console.WriteLine("3.Gestión de Inscripciones ");
            Console.WriteLine("4.Añadir Socio Federado ");
            Console.WriteLine("5.Añadir Socio Infantil ");
            Console.WriteLine("6.Eliminar socio ");
            Console.WriteLine("7.Mostrar Socios"); //(Todos o por tipo de socio)
            Console.WriteLine("8.Mostrar Factura mensual por socios ");
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenuSocio();
            return opcion;
        }
        private string pedirOpcionMenuSocio()
        {
            string opcion;
            do
            {
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"012345678".Contains(opcion));

            return opcion;
        }
        public string menuGestionIns()
        {
            string opcion;
            Console.WriteLine("1.Añadir Inscripción ");
            Console.WriteLine("2.Eliminar Inscripción ");
            Console.WriteLine("3.Mostar inscripciones");// con las opciones de filtrar por socio y/o fecha           
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenuIns();
            return opcion;
        }
        private string pedirOpcionMenuIns()
        {
            string opcion;
            do
            {
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"0123".Contains(opcion));

            return opcion;
        }

    }
}

    

