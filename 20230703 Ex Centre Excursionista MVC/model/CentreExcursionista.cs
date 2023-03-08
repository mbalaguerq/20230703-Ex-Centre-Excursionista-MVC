using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using _20230703_Ex_Centre_Excursionista_MVC.model;
using _20230703_Ex_Centre_Excursionista_MVC.vista;
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
        public void addInscripcio(Hashtable inscripcioHash)
        {
            Inscripcio i = new Inscripcio();
            i.NIns = (int)inscripcioHash["Ninscripcio"];
            i.Excursio = (Excursio)inscripcioHash["Excursio"];
            i.Soci1 = (Soci)inscripcioHash["Soci"];
            inscripcions.Add(i);
        }
        public void addSeguro(Hashtable tipoSeguroHash) 
        {
            Assegurança seguro = new Assegurança();
            seguro.Precio = (decimal)tipoSeguroHash["Preu"];
            seguro.Ts = (TipoSeguro)tipoSeguroHash["Tipus"];
            asseguran.Add(seguro);
        }
        public void carregaParametres()
        {
            Excursio excursio = new Excursio();
            excursio.Ndies = 3;
            excursio.Preu = 200;
            excursio.Codi = 49017805;
            excursio.Data = DateTime.Parse("01/05/2023");
            excursio.Descripcio = "Anada i tornada a Montserrat a peu";
            excursions.Add(excursio);

            Excursio excursio2 = new Excursio();
            excursio2.Ndies = 1;
            excursio2.Preu = 90;
            excursio2.Codi = 49010800;
            excursio2.Data = DateTime.Parse("05/06/2023");
            excursio2.Descripcio = "Anada i tornada a la Cerdanya";
            excursions.Add(excursio2);

            Excursio excursio3 = new Excursio();
            excursio3.Ndies = 4;
            excursio3.Preu = 760;
            excursio3.Codi = 58020600;
            excursio3.Data = DateTime.Parse("20/05/2023");
            excursio3.Descripcio = "Pica d'Estats";
            excursions.Add(excursio3);

            Federacio federacio = new Federacio();
            federacio.Nom = "Federació Catalana d'excursionistes";
            federacio.Codi = 001;
            federacions.Add(federacio);

            Federacio federacio2 = new Federacio();
            federacio2.Nom = "Federació d'excursionistes de Casagemes";
            federacio2.Codi = 002;
            federacions.Add(federacio2);

            Federat fede = new Federat();
            fede.Nom = "Miquel Molins Cardell";
            fede.Nsoci = 156;
            fede.Nif = "11111111A";
            socis.Add(fede);

            Federat fede2 = new Federat();
            fede2.Nom = "Manel Cordils i Cabdell";
            fede2.Nsoci = 215;
            fede2.Nif = "22222222B";
            socis.Add(fede2);

            SociStandar sociStan = new SociStandar();
            sociStan.Nom = "Marcel Bordils i Clatell";
            sociStan.Nsoci = 344;
            sociStan.Nif = "33333333C";
            sociStan.Tipusasseg = TipoSeguro.basic;
            socis.Add(sociStan);

            SociStandar sociStan2 = new SociStandar();
            sociStan2.Nom = "Mateu Ardils i Flaquer";
            sociStan2.Nsoci = 375;
            sociStan2.Nif = "44444444D";
            sociStan2.Tipusasseg = TipoSeguro.complert;
            socis.Add(sociStan2);

            Infantil sociInf = new Infantil();
            sociInf.Nom = "Mateuet Ardils i Canter";
            sociInf.Nsoci = 376;
            sociInf.NSociPare =375;
            socis.Add(sociInf);

            Infantil sociInf2 = new Infantil();
            sociInf2.Nom = "Marta Bordils Balsells";
            sociInf2.Nsoci = 345;
            sociInf2.NSociPare = 344;
            socis.Add(sociInf2);

            Inscripcio i = new Inscripcio();
            i.NIns = 0010;
            i.Excursio = excursio3;
            i.Soci1 = sociStan;
            inscripcions.Add(i);

            Inscripcio i2 = new Inscripcio();
            i2.NIns = 0011;
            i2.Excursio = excursio3;
            i2.Soci1 = sociStan2;
            inscripcions.Add(i2);

            Inscripcio i3 = new Inscripcio();
            i3.NIns = 0012;
            i3.Excursio = excursio;
            i3.Soci1 = sociInf;
            inscripcions.Add(i3);

            Inscripcio i4 = new Inscripcio();
            i4.NIns = 0013;
            i4.Excursio = excursio2;
            i4.Soci1 = sociInf2;
            inscripcions.Add(i4);

            Assegurança seguro = new Assegurança();
            seguro.Precio = 10;
            seguro.Ts = TipoSeguro.basic;
            asseguran.Add(seguro);

            Assegurança seguro2 = new Assegurança();
            seguro2.Precio = 20;
            seguro2.Ts = TipoSeguro.complert;
            asseguran.Add(seguro2);
        }        


    }
}
