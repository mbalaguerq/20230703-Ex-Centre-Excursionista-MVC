using _20230703_Ex_Centre_Excursionista_MVC.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Model
{
    enum TipoSeguro
    {
        basic, complert

    }
    internal class CentreExcursionista
    {
        //Aquesta classe farà de clase "datos", ja que és aquí on están tots els arraylist.

        private string nom;

        List<Federacio> federacions;
        List<Excursio> excursions;
        List<Inscripcio> inscripcions;
        List<Soci> socis;
        List<Assegurança> asseguran;
        public CentreExcursionista()
        {
            federacions = new List<Federacio>();
            excursions = new List<Excursio>();
            inscripcions = new List<Inscripcio>();
            socis = new List<Soci>();
            asseguran = new List<Assegurança>();
        }
        public string Nom { get => nom; set => nom = value; }

        public void addExcursio(Hashtable excursioHash)
        {
            Excursio excursio= new Excursio();
            excursio.Ndies = (int)excursioHash["Dies"];
            excursio.Preu = (decimal)excursioHash["Preu"];
            excursio.Codi = (int)excursioHash["Codi"];
            excursio.Data = (DateTime)excursioHash["Data"];
            excursio.Descripcio = (string)excursioHash["Descripcio"];
            excursions.Add(excursio);                       
        }
        public void addFederacio(Hashtable fedeHash)
        {
            Federacio federacio= new Federacio();
            federacio.Nom = (string)fedeHash["Nom"];
            federacio.Codi = (int)fedeHash["Codi"];
            federacions.Add(federacio);
        }
        public void addFederat(Hashtable fedeHash)
        {
            Federat fede= new Federat();
            fede.Nom = (string)fedeHash["Nom"];
            fede.Nsoci = (int)fedeHash["Soci"];
            fede.Nif = (string)fedeHash["Nif"];
            socis.Add(fede);            
        }
        public void addSociStandar(Hashtable standarHash)
        {
            SociStandar sociStan = new SociStandar();
            sociStan.Nom = (string)standarHash["Nom"];
            sociStan.Nsoci = (int)standarHash["Soci"];
            sociStan.Nif = (string)standarHash["Nif"];
            sociStan.Tipusasseg = (TipoSeguro)standarHash["TipusSeg"];
            socis.Add(sociStan);
        }
        public void addSociInfantil(Hashtable standarHash)
        {
            Infantil sociInf = new Infantil();
            sociInf.Nom = (string)standarHash["Nom"];
            sociInf.Nsoci = (int)standarHash["Soci"];
            sociInf.NSociPare = (int)standarHash["Nif"];
            socis.Add(sociInf);
        }
        private void addInscripcio(Hashtable inscripcioHash)
        {
            Inscripcio i = new Inscripcio();
            i.NIns = (int)inscripcioHash["Ninscripcio"];
            i.Excursio = (Excursio)inscripcioHash["Excursio"];
            i.Soci1 = (Soci)inscripcioHash["Soci"];
            inscripcions.Add(i);
        }
        private void addSeguro(Hashtable tipoSeguroHash) 
        {
            Assegurança seguro = new Assegurança();
            seguro.Precio = (decimal)tipoSeguroHash["Preu"];
            seguro.Ts = (TipoSeguro)tipoSeguroHash["Tipus"];
            asseguran.Add(seguro);
        }


    }
}
