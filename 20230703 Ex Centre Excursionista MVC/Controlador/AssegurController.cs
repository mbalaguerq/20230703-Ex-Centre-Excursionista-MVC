using _20230703_Ex_Centre_Excursionista_MVC.Model;
using _20230703_Ex_Centre_Excursionista_MVC.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Controlador
{
    internal class AssegurController
    {
        CentreExcursionista datos;
        public AssegurController(CentreExcursionista pdatos)
        {
            datos = pdatos;
        }
        public string getSociByNumero(int nSoci)
        {
            Soci sociObjeto;
            string socioString;
            sociObjeto = datos.getSociByNum(nSoci);
            socioString=sociObjeto.ToString();

            return socioString;            
        }
        public void actualAsseg(int nSoci)
        {
            datos.actualAsseg(nSoci);
        }
    }
}
