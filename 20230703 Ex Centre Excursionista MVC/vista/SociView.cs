using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using _20230703_Ex_Centre_Excursionista_MVC.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Vista
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
            string nom, nif, tipAss;                       
            TipoSeguro tipus;

            Console.WriteLine();
            Console.WriteLine("Nou Soci:");
            Console.Write("Introdueix Nif:");
            nif= Console.ReadLine();

            sociHash.Add("Nif", nif);
            
            string exist=SociController.buscarSociByNif(nif);

            if(exist.Equals(nif)) 
            {
                Console.WriteLine("El Soci ja existeix");
            }
            else
            {
                Console.Write("Introdueix el nom:");
                nom= Console.ReadLine();
                nsoci = SociController.nouNSoci();
                Console.WriteLine("Numero de soci: " + nsoci);   
                sociHash.Add("Nom",nom);
                sociHash.Add("Soci", nsoci);

                do
                {
                    Console.WriteLine("Seleccioni el tipus d'assegurança: ");
                    Console.WriteLine("1- Bàsica ");
                    Console.Write("2-Completa ");
                    tipAss = Console.ReadLine();
                    if (tipAss.Equals("1"))
                    {
                        tipus = TipoSeguro.basic;
                        sociHash.Add("TipusSeg", tipus);
                    }
                    if (tipAss.Equals("2"))
                    {
                        tipus = TipoSeguro.complert;
                        sociHash.Add("TipusSeg", tipus);
                    }                    
                } while(!"12".Contains(tipAss));
                Console.WriteLine();
            }          
        }
        public void afegirSociFederat()
        {
            Hashtable sociHash = new Hashtable();
            int nsoci;
            string nom, nif, triaFede;
            


            Console.WriteLine();
            Console.WriteLine("Nou Soci Federat :");
            Console.Write("Introdueix Nif:");
            nif = Console.ReadLine();

            sociHash.Add("Nif", nif);

            string exist = SociController.buscarSociByNif(nif);

            if (exist.Equals(nif))
            {
                Console.WriteLine("El Soci ja existeix");
            }
            else
            {
                Console.Write("Introdueix el nom:");
                nom = Console.ReadLine();
                nsoci = SociController.nouNSoci();
                Console.WriteLine("Numero de soci: " + nsoci);
                sociHash.Add("Nom", nom);
                sociHash.Add("Soci", nsoci);

                do
                {
                    Federacio federacio;

                    Console.WriteLine("Seleccioni la seva federació: ");
                    Console.WriteLine("1- Federació Catalana d'excursionistes ");
                    Console.Write("2-Federació d'excursionistes de Casagemes ");
                    triaFede = Console.ReadLine();
                    if (triaFede.Equals("1"))
                    {
                        federacio = federat.fede;
                        sociHash.Add("TipusSeg", federacio);
                    }
                    if (triaFede.Equals("2"))
                    {
                        federacio = TipoSeguro.complert;
                        sociHash.Add("TipusSeg", federacio);
                    }
                } while (!"12".Contains(triaFede));
                Console.WriteLine();
            }
        }
    }
}
