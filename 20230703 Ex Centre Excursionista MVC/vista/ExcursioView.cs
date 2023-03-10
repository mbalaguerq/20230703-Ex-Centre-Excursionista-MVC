using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using _20230703_Ex_Centre_Excursionista_MVC.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            int codi;
            decimal preu;
            int ndies;

            Console.WriteLine();
            Console.WriteLine("Nova Inscripció: ");
            Console.WriteLine();
            Console.Write("Descripció: ");
            descripcio= Console.ReadLine();
            Console.Write("Codi: ");
            codi =int.Parse(Console.ReadLine());
            Console.Write("Data (dd/mm/aaaa) :");
            data= DateTime.Parse(Console.ReadLine());
            Console.Write("Preu: ");
            preu= Decimal.Parse(Console.ReadLine());
            Console.Write("Número de dies: ");
            ndies=int.Parse(Console.ReadLine());

            InsHash.Add("Dies", ndies);
            InsHash.Add("Preu", preu);
            InsHash.Add("Codi", codi);
            InsHash.Add("Data",data);
            InsHash.Add("Descripcio", descripcio);

            excursioController.addExcursio(InsHash);
        }
        public void mostrarExcursio()
        {
            Hashtable HashData= new Hashtable();

            DateTime dataI, dataF;

            Console.WriteLine();
            Console.WriteLine("Data d'inici: ");
            dataI = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Data Final: ");
            dataF = DateTime.Parse(Console.ReadLine());

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
