using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Vista
{
    internal class ExcursioView
    {
        ExcursioController excursioController;
        public ExcursioView() { }

        public ExcursioView(ExcursioController pexcursioController)
        {
            excursioController = pexcursioController;
        }        
        public void afegirExcursio()
        {
            Hashtable InsHash= new Hashtable();
            string descripcio;
            DateTime data;
            DateTime avui= DateTime.Now;
            int codi;
            decimal preu;
            int ndies;
            bool bona = false;
            string resposta;

            Console.WriteLine();
            Console.WriteLine("NOVA EXCURSIÓ: ");
            Console.WriteLine();
            Console.Write("Descripció: ");
            descripcio= Console.ReadLine();
            codi = excursioController.GetNouCodiExc();
            do
            {                
                Console.WriteLine("Data d'inici (dd/mm/aaaa): ");
                data = DateTime.Parse(Console.ReadLine());
                if (data < avui)
                {
                    Console.WriteLine("Data Incorrecta!");
                    Console.WriteLine("Introdueixi una data correcta: ");
                }
                else
                {
                    bona = true;
                }

            } while (!bona);           
            Console.Write("Preu: ");
            preu= Decimal.Parse(Console.ReadLine());
            Console.Write("Número de dies: ");
            ndies=int.Parse(Console.ReadLine());

            InsHash.Add("Dies", ndies);
            InsHash.Add("Preu", preu);
            InsHash.Add("Codi", codi);
            InsHash.Add("Data",data);
            InsHash.Add("Descripcio", descripcio);

            Console.WriteLine();
            Console.WriteLine("Nova Excursió: ");
            Console.WriteLine(descripcio); 
            Console.WriteLine("Codi: " + codi);
            Console.WriteLine("Data: " + data.ToShortDateString());//Escriu la data sense la hora
            Console.WriteLine("N. dies: " + ndies);
            Console.WriteLine("Preu: " + preu + "Euros");
            Console.Write("Confirmar: S/N ");
            resposta = Console.ReadLine();
            resposta.ToLower();
            if(resposta.Equals("s"))
            {
                excursioController.addExcursio(InsHash);
                Console.WriteLine();
                Console.WriteLine("Excursió afegida correctament.");
            }   
            else
            {
                Console.WriteLine("Operació Cancelada.");
            }
            Console.WriteLine();
        }
        public void mostrarExcursio()
        {
            Hashtable HashData= new Hashtable();
            DateTime avui = DateTime.Now;
            DateTime dataI, dataF;
            bool bona = false;

            do
            {
                Console.WriteLine("EXCURSIONS DISPONIBLES: ");
                Console.WriteLine();
                Console.WriteLine("Data d'inici: ");
                dataI = DateTime.Parse(Console.ReadLine());
                if(dataI < avui)
                {
                    Console.WriteLine("Data Incorrecta!");
                    Console.WriteLine("Introdueixi una data correcta: ");
                }
                else
                {
                    bona = true;
                }

            } while (!bona);

            bona= false;
            do {
                Console.WriteLine("Data Final: ");                
                dataF = DateTime.Parse(Console.ReadLine());
                if (dataF < dataI)
                {
                    Console.WriteLine("Data Incorrecta!");
                    Console.WriteLine("Introdueixi una data correcta: ");
                }
                else
                {
                    bona = true;
                }

            } while (!bona);
            Console.WriteLine();

            HashData.Add("DataI", dataI);
            HashData.Add("DataF", dataF);

            List<String> list = new List<String>();

            list= excursioController.buscaExcursio(HashData);

            foreach(string dato in list)
            {
                Console.WriteLine(dato);
            }         
        }
    }
}
