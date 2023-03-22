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
        public string buscarPareByNif(string nifC)
        {
            // llamamos al método getNombreClienteByNif de la clase datos
            // para buscar el nombre del cliente

            string pare = datos.getNomPareByNif(nifC);
            return pare;
        }
        public int buscarnSociPareByNif(string nif)
        {
            int nSociPare= datos.buscarnSociPareByNif(nif);
            return nSociPare;
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
        public void addSociInfantil(Hashtable sociHash)
        {
            datos.addSociInfantil(sociHash);
        }
        /*public Federacio triaFede(int triaFede)
        {
            Federacio fedeTrobada = datos.triaFede(triaFede);
                return fedeTrobada;
        } */

        public void addSociFederat(Hashtable fedeHash, int codi)
        {
            datos.addSociFederat(fedeHash, codi);
        }
        public string trobaSociString(int nSoci)
        {
            string sociTrobat=datos.getNomSociByNum(nSoci);
            return sociTrobat;
        }
        public void deleteSoci(string sociTrobat)
        {
            datos.deleteSoci(sociTrobat);            
        }
        public List<string> llistaSocis(int opcio)
        {
            List<String> llistaSocis = new List<String>();
            llistaSocis = datos.llistaSocis(opcio);
            return llistaSocis;
        }
        public decimal getQuotaMensual(string sociTrobat)
        {
            Decimal quotaMensual;
            quotaMensual = datos.getQuotaMensual(sociTrobat);
            return quotaMensual;
        }
        public decimal getQuotaExcursions(string sociTrobat, int month)
        {
            Decimal quotaExcursions;
            quotaExcursions = datos.getQuotaExcursions(sociTrobat, month); 
            return quotaExcursions;
        }
    }
}
