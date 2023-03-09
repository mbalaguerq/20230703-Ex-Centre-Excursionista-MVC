using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using _20230703_Ex_Centre_Excursionista_MVC.Model;
using System;
using System.Collections;
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
        public void afegirSociStandar()
        {
            Hashtable sociHash = new Hashtable();
            int nsoci;
            string nom;
            string nif;
            string tipAss;
            TipoSeguro tipus;

            Console.WriteLine();
            Console.WriteLine("Nou Soci:");
            Console.Write("Introdueix Nif:");
            nif= Console.ReadLine();

            sociHash.Add("Nif", nif);

            string exist=SociController.buscarSociByNif(nif);

            if(exist.Equals(nif)) 
            {
                Console.WriteLine("El client ja existeix");
            }
            else
            {
                Console.Write("Introdueix el nom:");
                nom= Console.ReadLine();
                nsoci = SociController.nouNSoci();
                Console.WriteLine("Numero de soci: " + nsoci);
                Console.WriteLine("Seleccioni el tipus d'assegurança: ");
                Console.WriteLine("1- Bàsica ");
                Console.Write("2-Completa ");                
                tipAss=Console.ReadLine();
            }


        }
    }
}
