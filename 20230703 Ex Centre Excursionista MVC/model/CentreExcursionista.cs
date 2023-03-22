using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
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
        const decimal QUOTA = 10;
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
            Excursio excursio = new Excursio();
            excursio.Ndies = (int)excursioHash["Dies"];
            excursio.Preu = (decimal)excursioHash["Preu"];
            excursio.Codi = (int)excursioHash["Codi"];
            excursio.Data = (DateTime)excursioHash["Data"];
            excursio.Descripcio = (string)excursioHash["Descripcio"];
            excursions.Add(excursio);
        }
        public void addFederacio(Hashtable fedeHash)
        {
            Federacio federacio = new Federacio();
            federacio.Nom = (string)fedeHash["Nom"];
            federacio.Codi = (int)fedeHash["Codi"];
            federacions.Add(federacio);
        }
        public void addFederat(Hashtable fedeHash)
        {
            Federat fede = new Federat();
            fede.Nom = (string)fedeHash["Nom"];
            fede.Nsoci = (int)fedeHash["Soci"];
            fede.Nif = (string)fedeHash["Nif"];
            fede.Fede = (Federacio)fedeHash["Federacio"];
            socis.Add(fede);
        }
        public void addSociStandar(Hashtable standarHash)
        {
            SociStandar sociStan = new SociStandar();
            sociStan.Nom = (string)standarHash["Nom"];
            sociStan.Nsoci = (int)standarHash["Soci"];
            sociStan.Nif = (string)standarHash["Nif"];
            sociStan.Assegurança = (Assegurança)standarHash["Assegurança"];
            socis.Add(sociStan);
        }
        public void addSociInfantil(Hashtable standarHash)
        {
            Infantil sociInf = new Infantil();
            sociInf.Nom = (string)standarHash["Nom"];
            sociInf.Nsoci = (int)standarHash["Soci"];
            sociInf.NSociPare = (int)standarHash["SociPare"];
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
            excursio.Codi = 001;
            excursio.Data = DateTime.Parse("01/05/2023");
            excursio.Descripcio = "Anada i tornada a Montserrat a peu";
            excursions.Add(excursio);

            Excursio excursio2 = new Excursio();
            excursio2.Ndies = 1;
            excursio2.Preu = 90;
            excursio2.Codi = 002;
            excursio2.Data = DateTime.Parse("05/06/2023");
            excursio2.Descripcio = "Anada i tornada a la Cerdanya";
            excursions.Add(excursio2);

            Excursio excursio3 = new Excursio();
            excursio3.Ndies = 4;
            excursio3.Preu = 760;
            excursio3.Codi = 003;
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
            fede.Fede = federacio2;
            fede.Nif = "11111111A";
            socis.Add(fede);

            Federat fede2 = new Federat();
            fede2.Nom = "Manel Cordils i Cabdell";
            fede2.Nsoci = 215;
            fede2.Fede = federacio;
            fede2.Nif = "22222222B";
            socis.Add(fede2);

            Assegurança seguro = new Assegurança();
            seguro.Precio = 10;
            seguro.Ts = TipoSeguro.basic;
            asseguran.Add(seguro);

            Assegurança seguro2 = new Assegurança();
            seguro2.Precio = 20;
            seguro2.Ts = TipoSeguro.complert;
            asseguran.Add(seguro2);

            SociStandar sociStan = new SociStandar();
            sociStan.Nom = "Marcel Bordils i Clatell";
            sociStan.Nsoci = 344;
            sociStan.Nif = "33333333C";
            sociStan.Assegurança = seguro;
            socis.Add(sociStan);

            SociStandar sociStan2 = new SociStandar();
            sociStan2.Nom = "Mateu Ardils i Flaquer";
            sociStan2.Nsoci = 375;
            sociStan2.Nif = "44444444D";
            sociStan2.Assegurança = seguro2;
            socis.Add(sociStan2);

            Infantil sociInf = new Infantil();
            sociInf.Nom = "Mateuet Ardils i Canter";
            sociInf.Nsoci = 376;
            sociInf.NSociPare = 375;
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
        }
        public List<string> llistaExcursions()
        {
            DateTime date = DateTime.Now;
            List<string> llistaExcursions = new List<string>();
            foreach (Excursio veh in excursions)
            {
                if (date < veh.Data)
                {

                    llistaExcursions.Add(veh.Descripcio + "\t" + veh.Codi + "\t" + veh.Data + "\t" +
                        veh.Ndies + "\t" + veh.Preu + "\t");
                }
            }
            return llistaExcursions;
        }
        public List<string> buscarExcursio(Hashtable dates)
        {
            List<string> trobades = new List<string>();
            foreach (Excursio exc in excursions)
            {
                if (exc.Data >= (DateTime)dates["DataI"] && exc.Data <= (DateTime)dates["DataF"])
                {
                    trobades.Add(exc.ToString());
                }
            }
            return trobades;
        }
        public string getNomSociByNif(string nif)
        {
            foreach (Soci s in socis)
            {
                if (s.GetType().Name != "Infantil")
                {
                    if (s is SociStandar && (s as SociStandar).Nif.Equals(nif))
                    //Compte amb aquesta linea. 
                    {
                        return (s as SociStandar).Nif;
                    }
                    if (s is Federat && (s as Federat).Nif.Equals(nif))
                    {
                        return (s as Federat).Nif;
                    }
                }
            }
            return "";
        }
        public string getNomPareByNif(string nif)
        {
            foreach (Soci s in socis)
            {
                if (s.GetType().Name != "Infantil")
                {
                    if (s is SociStandar && (s as SociStandar).Nif.Equals(nif))
                    //Compte amb aquesta linea. 
                    {
                        return (s as SociStandar).ToString();
                    }
                    if (s is Federat && (s as Federat).Nif.Equals(nif))
                    {
                        return (s as Federat).ToString();
                    }
                }
            }
            return "";
        }

        private static int _contador = 500;
        private static int _inscripcio = 1000;
        private static int _excursio = 004;

        public int getNouNSoci()
        {
            _contador++;
            return _contador;
        }       
        public int GetNinscripcio()
        {
            _inscripcio++;
            return _inscripcio;
        }        
        public int GetNouCodiExc()
        {
            _excursio++;
            return _excursio; 
        }
        public string getNomSociByNum(int nSociBuscat)
        {
            string sociTrobat;
            //No fa falta fer un New ja que estem buscant un objecte qeu ja existeix. 
            //Encara que soci es una classe abstracta, el puc capturar

            foreach (Soci soci in socis)
            {
                if (soci.Nsoci == nSociBuscat)
                {
                    sociTrobat = soci.ToString();
                    return sociTrobat;
                }
            }
            return "";
        }
        public Soci getSociByNum(int nSociBuscat)
        {
            Soci sociTrobat;
            //No fa falta fer un New ja que estem buscant un objecte qeu ja existeix. 
            //Encara que soci es una classe abstracta, el puc capturar

            foreach (Soci soci in socis)
            {
                if (soci.Nsoci == nSociBuscat)
                {
                    sociTrobat = soci;
                    return sociTrobat;
                }
            }
            return null;
        }
        public int buscarnSociPareByNif(string nif)
        {
            int nSociPare=0;

            foreach (Soci soci in socis)
            {
                if(soci is Federat && (soci as Federat).Nif.Equals(nif))

                {
                    (soci as Federat).Nsoci = nSociPare;
                    return nSociPare;
                }
                if (soci is SociStandar && (soci as SociStandar).Nif.Equals(nif))

                {
                    (soci as SociStandar).Nsoci = nSociPare;
                    return nSociPare;
                }                
            }
            return -1;
        }
        public void actualAsseg(int nSoci)
        {
            Soci modifiSoci = getSociByNum(nSoci);
            {
                if (modifiSoci is SociStandar && (modifiSoci as SociStandar).Assegurança.Equals(TipoSeguro.basic))
                {
                    foreach (Assegurança seguro in asseguran)
                    {
                        if (seguro.Ts.ToString().Equals("complert"))
                        {
                            (modifiSoci as SociStandar).Assegurança = seguro;
                        }
                    }
                }
                if (modifiSoci is SociStandar && (modifiSoci as SociStandar).Assegurança.Equals(TipoSeguro.complert))
                {
                    foreach (Assegurança seguro in asseguran)
                    {
                        if (seguro.Ts == TipoSeguro.basic)//Al tenir el enum a la mateix clase podem fer un ==
                        {
                            (modifiSoci as SociStandar).Assegurança = seguro;
                        }
                    }
                }
            }

        }
        public Assegurança triaAsseg(TipoSeguro tipus)
        {
            foreach (Assegurança seguro in asseguran)
            {
                if (seguro.Ts == tipus)
                { return seguro; }
            }
            return null;
        }        
        public void addSociFederat(Hashtable fedeHash, int triaFede)
        {
            Federacio fedeaux = new Federacio();

            foreach (Federacio fede in federacions)
            {
                if (fede.Codi == triaFede)
                {
                    fedeaux.Codi = fede.Codi;
                    fedeaux.Nom=fede.Nom;
                }
            }
            fedeHash.Add("Federació",fedeaux);
            
            addFederat(fedeHash);
        }
        public void deleteSoci(string sociTrobat)
        {
            foreach (Soci soci in socis)
            {
                if (soci.ToString() == sociTrobat)
                {
                    socis.Remove(soci);
                    return;
                }
            }
        }
        public List<string> llistaSocis(int opcio)
        {
            List<string> llistaSocis = new List<string>();

            switch (opcio)
            {
                case 1:
                    foreach (Soci soci in socis)
                    {
                        llistaSocis.Add(soci.ToString());
                    }
                    return llistaSocis;

                case 2:
                    foreach (Soci soci in socis)
                    {
                        if (soci is SociStandar)
                        {
                            llistaSocis.Add(soci.ToString());
                        }
                    }
                    return llistaSocis;
                case 3:
                    foreach (Soci soci in socis)
                    {
                        if (soci is Federat)
                        {
                            llistaSocis.Add(soci.ToString());
                        }
                    }
                    return llistaSocis;

                case 4:
                    foreach (Soci soci in socis)
                    {
                        if (soci is Infantil)
                        {
                            llistaSocis.Add(soci.ToString());
                        }
                    }
                    return llistaSocis;

            }





            return llistaSocis;
        }
        public decimal getQuotaMensual(string sociTrobat)
        {
            decimal quotaMensual;

            foreach (Soci soci in socis)
            {
                if (soci.ToString() == sociTrobat)
                {
                    if (soci is SociStandar)
                    {
                        return QUOTA;
                    }
                    if (soci is Federat)
                    {
                        quotaMensual = (QUOTA * 0.95m);//la m indica que el valor es decimal
                        return quotaMensual;
                    }
                    if (soci is Infantil)
                    {
                        quotaMensual = (QUOTA * 0.50m);//la m indica que el valor es decimal
                        return quotaMensual;
                    }
                }
            }
            return -1;
        }
        public decimal getQuotaExcursions(string sociTrobat, int month)
        {
            decimal quotaExcursions = 0;
            decimal quotaFinal = 0;

            foreach (Inscripcio ins in inscripcions)
            {
                if (ins.Soci1.ToString() == sociTrobat && ins.Excursio.Data.Month == month)
                {
                    quotaExcursions += ins.Excursio.Preu;

                    if (ins.Soci1 is Infantil)
                    {
                        quotaExcursions = quotaFinal;
                    }
                    if (ins.Soci1 is SociStandar)
                    {
                        quotaFinal = quotaExcursions + (ins.Soci1 as SociStandar).Assegurança.Precio;
                    }
                    if (ins.Soci1 is Federat)
                    {
                        quotaFinal = quotaExcursions * 0.10m;
                    }
                }
            }
            return quotaFinal;
        }
        public Hashtable buscaInscripcio(Hashtable infoHash)
        {
            foreach (Excursio excursio in excursions)
            {
                if (excursio.Codi == (int)infoHash["codiExc"])
                {
                    infoHash.Add("Excursio", excursio);
                }
            }
            foreach (Soci soci in socis)
            {
                if (soci.Nsoci == (int)infoHash["nSoci"])
                {
                    infoHash.Add("SociNom", soci.Nom);
                }
            }
            addInscripcio(infoHash);

            return infoHash;
        }
        public List<string> GetInscripcioBySoci(int nSoci)
        {
            List<string> inscrip = new List<string>();
            foreach (Inscripcio ins in inscripcions)
            {
                if (ins.Soci1.Nsoci == nSoci)
                {
                    inscrip.Add(ins.ToString());
                }
                return inscrip;
            }
            return null;
        }
        public bool DeleteInscripcio(int nIns)
        {
            bool ret = false;

            foreach (Inscripcio ins in inscripcions)
            {
                if (ins.NIns == nIns)
                {
                    inscripcions.Remove(ins);
                    ret = true;
                    return ret;
                }
            }
            return ret;
        }
        public List<string> GetInscripBySoci(int nSoci)

        {
            List<string> inscrip = new List<string>();
           
            foreach (Inscripcio ins in inscripcions)
            {
                if (ins.Soci1.Nsoci == nSoci)
                {
                    inscrip.Add("Num. Soci: " +  ins.Soci1.Nsoci.ToString());
                    inscrip.Add("Nom: " + ins.Soci1.Nom.ToString());
                    inscrip.Add("Data: " + ins.Excursio.Data.ToString());
                    inscrip.Add("Excursió: " + ins.Excursio.Descripcio.ToString());
                    if (ins.Soci1 is Federat)
                    {                      
                        inscrip.Add("Preu: " + (ins.Excursio.Preu * 0,9).ToString() + " Euros");
                    }
                    else
                    {
                        inscrip.Add("Preu: " + ins.Excursio.Preu.ToString() + " Euros");
                    }
                }
                return inscrip;
            }
            return null;
        }
        public List<string> GetInscripByData(Hashtable dates) 
        {
            List<string> inscrip = new List<string>();

            foreach(Inscripcio ins in inscripcions)            
            {
                if (ins.Excursio.Data >= (DateTime)dates["DataI"] && ins.Excursio.Data <= (DateTime)dates["DataF"])
             
                {
                    inscrip.Add("Num. Soci: " + ins.Soci1.Nsoci.ToString());
                    inscrip.Add("Nom: " + ins.Soci1.Nom.ToString());
                    inscrip.Add("Data: " + ins.Excursio.Data.ToString());
                    inscrip.Add("Excursió: " + ins.Excursio.Descripcio.ToString());
                    if (ins.Soci1 is Federat)
                    {
                        inscrip.Add("Preu: " + (ins.Excursio.Preu * 0, 9).ToString() + " Euros");
                    }
                    else
                    {
                        inscrip.Add("Preu: " + ins.Excursio.Preu.ToString() + " Euros");
                    }
                }
            }
            return inscrip;
        }
    }
}