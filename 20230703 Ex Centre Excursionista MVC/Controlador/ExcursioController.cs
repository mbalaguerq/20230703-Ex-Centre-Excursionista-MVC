using _20230703_Ex_Centre_Excursionista_MVC.Model;
using _20230703_Ex_Centre_Excursionista_MVC.Vista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Controlador
{
    internal class ExcursioController
    {
        CentreExcursionista datos;

        public ExcursioController(CentreExcursionista pdatos)
        {
            datos = pdatos;
        }
        public void addExcursio(Hashtable InsHash) 
        {
            datos.addExcursio(InsHash);
        }
        public List<string> buscaExcursio(Hashtable fecha)
        {
            List<String> list = new List<String>();            
            list=  datos.buscarExcursio(fecha);
           
            return list;
        }
    }
}
