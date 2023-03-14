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
    internal class SociController
    {
        CentreExcursionista datos;

        public SociController(CentreExcursionista pdatos)
        {
            datos = pdatos;
        }
        public string buscarSociByNif(string nifC)
        {
            // llamamos al método getNombreClienteByNif de la clase datos
            // para buscar el nombre del cliente

            string nif = datos.getNomSociByNif(nifC);
            return nif;
        }
        public int nouNSoci()
        {
            int nouNSoci = datos.getNouNSoci();
            return nouNSoci;
        }
        public Assegurança triaAsseg(TipoSeguro tipus)
        {
            Assegurança assegTrobada= datos.triaAsseg(tipus);
            return  assegTrobada;             
        }
        public void addSociStan(Hashtable sociHash)
        {
            datos.addSociStandar(sociHash);
        }
        public void addSociFede(Hashtable sociHash) 
        {
            datos.addFederat(sociHash);
        }
        public Federacio triaFede(int triaFede)
        {
            Federacio fedeTrobada = datos.triaFede(triaFede);
                return fedeTrobada;
        }
    }
}
