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
    internal class InscripcioController
    {
        CentreExcursionista datos;

        public InscripcioController(CentreExcursionista pdatos)
        {
            datos = pdatos;
        }
        public string GetSocibyNumero(int nSoci)
        {
            string nSociTrobat;
            nSociTrobat = datos.getNomSociByNum(nSoci);
            return nSociTrobat;
        }
        public List<string> excurDisponibles()
        {
            List<string> list = new List<string>();
            list = datos.llistaExcursions();
            return list;
        }
        public int GetNinscripcio()
        {
            int nIns;
            nIns = datos.GetNinscripcio();
            return nIns;
        }
        public Hashtable addInscripcio(Hashtable inscripHash)
        {
            Hashtable dades = new Hashtable();
            dades = datos.buscaInscripcio(inscripHash);
            return dades;
        }
        public List<string> GetInscripcioBySoci(int nSoci)
        {
            List<string> list = new List<string>();
            list = datos.GetInscripcioBySoci(nSoci);
            return list;
        }
        public bool DeleteInscripcio(int nIns)
        {
           
           bool ret= datos.DeleteInscripcio(nIns);

            return ret;
        }




    }
}
