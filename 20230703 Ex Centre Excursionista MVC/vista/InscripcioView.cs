using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
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
                sociView.afegirSociStandar();
            }
            else
            {
                Console.WriteLine(sociTrobat.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Excursions disponibles :");
            excurDisponibles = inscripcioController.excurDisponibles();
            Console.WriteLine(excurDisponibles.ToString());
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
            Console.WriteLine("Soci: ");
            Console.WriteLine();
            Console.WriteLine(mostrar  );
        }
    }
}
