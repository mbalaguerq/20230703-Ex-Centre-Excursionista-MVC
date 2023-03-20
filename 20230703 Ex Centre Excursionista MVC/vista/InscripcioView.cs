using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using _20230703_Ex_Centre_Excursionista_MVC.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Vista
{
    internal class InscripcioView
    {
        InscripcioController inscripcioController;
        SociController sociController;
        SociView sociView;

        public InscripcioView() { }
        public InscripcioView(InscripcioController pinscripcioController, SociController pSociController, SociView pSociView)
        {
            inscripcioController = pinscripcioController;
            sociController = pSociController;
            sociView = pSociView;
        }
        public void afegirInscripcio()
        {
            Hashtable inscripHash = new Hashtable();
            Hashtable mostrar = new Hashtable();

            int nIns, codiExc, nSoci;
            string sociTrobat;
            List<string>excurDisponibles = new List<string>();
           

            Console.WriteLine();
            Console.WriteLine("Nova Inscripció");
            Console.WriteLine();
            Console.Write("Introdueix el Número de Soci: ");
            nSoci=int.Parse(Console.ReadLine());
            sociTrobat= inscripcioController.GetSocibyNumero(nSoci);            

            if ( sociTrobat == "" ) 
            {
                Console.WriteLine();
                Console.WriteLine("No hi ha cap soci amb aquest número.");
                Console.WriteLine();
                sociView.afegirSociStandar();
            }
            else
            {
                Console.WriteLine(sociTrobat.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Excursions disponibles :");
            excurDisponibles = inscripcioController.excurDisponibles();
            foreach(string Exc in excurDisponibles) 
            {
                Console.WriteLine(Exc);

            }
            
            Console.WriteLine();
            Console.Write("Introdueix el Codi de la Excursió triada :");
            codiExc = int.Parse(Console.ReadLine());
                       
            nIns = inscripcioController.GetNinscripcio();
            Console.WriteLine("Número d'inscripció:  " + nIns);

            inscripHash.Add("nSoci", nSoci);
            inscripHash.Add("Ninscripcio", nIns);
            inscripHash.Add("codiExc", codiExc);

            mostrar= inscripcioController.addInscripcio(inscripHash);

            Console.WriteLine();
            Console.WriteLine("Inscripció realitzada amb èxit");
            Console.WriteLine("Resum de la seva inscripció: ");
            Console.WriteLine("Número d'inscripció: " + nIns);            
            Console.WriteLine("Soci: " + mostrar["nSoci"]);
            Console.WriteLine("Soci: " + mostrar["SociNom"]);
            Console.WriteLine();
            Console.WriteLine(mostrar["Excursio"]);
        }
        public void eliminarInscripcio()
        {            
            List<string> excurContractades = new List<string>();
            int nSoci, nIns;
            string sociTrobat;
            bool sociExists=false;
            bool eliminat = true;
            
            do
            {
                Console.WriteLine();
                Console.WriteLine("Eliminar Inscripció");
                Console.WriteLine();
                Console.Write("Introdueix el Número de Soci: ");
                nSoci = int.Parse(Console.ReadLine());
                sociTrobat = inscripcioController.GetSocibyNumero(nSoci);

                if (sociTrobat == "")
                {
                    Console.WriteLine();
                    Console.WriteLine("No hi ha cap soci amb aquest número.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(sociTrobat.ToString());
                    sociExists = true;
                }
            }while (!sociExists);
            
            excurContractades = inscripcioController.GetInscripcioBySoci(nSoci);
            if (excurContractades == null)
            {
                Console.WriteLine("Aquest soci no té excursions contractades");
            }
            else
            {
                foreach (string s in excurContractades)
                {                   
                    Console.WriteLine(s);                    
                }
                do
                {
                    Console.WriteLine();
                    Console.Write("Seleccioni el número d'inscripció a eliminar: ");
                    nIns = int.Parse(Console.ReadLine());
                    eliminat = inscripcioController.DeleteInscripcio(nIns);
                    if (eliminat == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Inscripció correctament eliminada. ");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No existeix aquest número d'inscripció");
                    }
                }while(!eliminat);
            }
        }
        public void llistaInscripBySoci()
        {
            Console.WriteLine();
            Console.WriteLine("Eliminar Inscripció");
            Console.WriteLine();
            Console.WriteLine("Filtrar per n de Soci:");
            Console.WriteLine("Filtrar per data:");

        }
    }
}
