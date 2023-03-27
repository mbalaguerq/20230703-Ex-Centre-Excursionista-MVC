using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using _20230703_Ex_Centre_Excursionista_MVC.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Vista
{
    internal class SociView
    {
        SociController SociController;
        public SociView() { }
        public SociView(SociController psociController)
        {
            SociController = psociController;
        }
        public void afegirSociStandar()
        {
            Hashtable sociHash = new Hashtable();
            int nsoci;
            string nom, nif, tipAss, resposta;
            TipoSeguro tipus;

            Console.WriteLine();
            Console.WriteLine("NOU SOCI: ");
            Console.WriteLine();
            Console.Write("Introdueix Nif:");
            nif = Console.ReadLine();
            nif = nif.ToUpper();
            Console.WriteLine();

            sociHash.Add("Nif", nif);

            string exist = SociController.buscarSociByNif(nif);

            if (exist.Equals(nif))
            {
                Console.WriteLine("El Soci ja existeix");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Introdueix el nom:");
                nom = Console.ReadLine();
                nsoci = SociController.nouNSoci();
                Console.WriteLine("Numero de soci: " + nsoci);
                sociHash.Add("Nom", nom);
                sociHash.Add("Soci", nsoci);

                do
                {
                    Console.WriteLine("Seleccioni el tipus d'assegurança: ");
                    Console.WriteLine("1- Bàsica ");
                    Console.Write("2-Completa ");
                    tipAss = Console.ReadLine();
                    if (tipAss.Equals("1"))
                    {
                        tipus = TipoSeguro.basic;
                        SociController.triaAsseg(tipus);

                        //PARLAT AMB JOSEP. A LA VISTA NO HI POT HAVER OBJECTES. ES DEIXA AIXÍ JA QUE 
                        //LA LÒGICA D'AQUEST MÈTODE ES DIFICIL I SI NO, HAURIA DE CANVIAR TOTA LA OPCIÓ SENCERA.
                        Assegurança asseg = SociController.triaAsseg(tipus);
                        sociHash.Add("Assegurança", asseg);
                        Console.WriteLine(asseg.ToString());
                    }
                    if (tipAss.Equals("2"))
                    {
                        tipus = TipoSeguro.complert;
                        SociController.triaAsseg(tipus);

                        //PARLAT AMB JOSEP. A LA VISTA NO HI POT HAVER OBJECTES. ES DEIXA AIXÍ JA QUE 
                        //LA LÒGICA D'AQUEST MÈTODE ES DIFICIL I SI NO, HAURIA DE CANVIAR TOTA LA OPCIÓ SENCERA.
                        Assegurança asseg = SociController.triaAsseg(tipus);
                        sociHash.Add("Assegurança", asseg);
                        Console.WriteLine(asseg.ToString());
                    }
                } while (!"12".Contains(tipAss));
                Console.WriteLine();
                Console.WriteLine("REVISI LES DADES:");
                Console.WriteLine();
                Console.WriteLine("NIF: " + nif);
                Console.WriteLine("NOM: " + nom);
                Console.WriteLine("N.SOCI " + nsoci);
                Console.WriteLine(sociHash["Assegurança"].ToString());
                Console.WriteLine();
                Console.WriteLine("Confirmar Alta: S/N");
                resposta = Console.ReadLine();
                resposta.ToLower();
                if (resposta.Equals("s"))
                {
                    SociController.addSociStan(sociHash);
                    Console.WriteLine("El soci s'ha afegit correctament.");
                }
                else
                {
                    Console.WriteLine("Operació cancelada.");
                }
                Console.WriteLine();
            }
        }
        public void afegirSociFederat()
        {
            Hashtable sociHash = new Hashtable();
            int nsoci;
            string nom, nif;
            int triaFede;

            Console.WriteLine();
            Console.WriteLine("NOU SOCI FEDERAT: ");
            Console.Write("Introdueix Nif: ");
            nif = Console.ReadLine();
            nif = nif.ToUpper();
            Console.WriteLine();

            sociHash.Add("Nif", nif);

            string exist = SociController.buscarSociByNif(nif);

            if (exist.Equals(nif))
            {
                Console.WriteLine("El Soci ja existeix");
            }
            else
            {
                Console.Write("Introdueix el nom:");
                nom = Console.ReadLine();
                nsoci = SociController.nouNSoci();
                Console.WriteLine("Numero de soci: " + nsoci);
                sociHash.Add("Nom", nom);
                sociHash.Add("Soci", nsoci);

                do
                {
                    Console.WriteLine("Seleccioni la seva federació: ");
                    Console.WriteLine("1- Federació Catalana d'excursionistes ");
                    Console.Write("2-Federació d'excursionistes de Casagemes ");
                    triaFede = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (triaFede == 1)
                    {
                        triaFede = 001;

                        SociController.addSociFederat(sociHash, triaFede);
                    }
                    if (triaFede == 2)
                    {
                        triaFede = 002;
                        SociController.addSociFederat(sociHash, triaFede);
                    }
                } while ((triaFede != 1 && triaFede != 2));
                Console.WriteLine();
                Console.WriteLine("Alta realitzada correctament");
                Console.WriteLine();

            }
        }
        public void afegirSociInfantil()
        {
            Hashtable sociHash = new Hashtable();
            int nsoci, nSociPare;
            string nom, nif, resposta;

            Console.WriteLine();
            Console.WriteLine("NOU SOCI INFANTIL :");
            Console.Write("Introdueix Nif del Pare:");
            nif = Console.ReadLine();
            nif = nif.ToUpper();
            Console.WriteLine();

            string pare = SociController.buscarPareByNif(nif);
            nSociPare = SociController.buscarnSociPareByNif(nif);

            if (pare != "")
            {
                Console.WriteLine(pare.ToString());
                Console.WriteLine();
                Console.Write("Introdueix el nom del Soci Infantil:");
                nom = Console.ReadLine();
                nsoci = SociController.nouNSoci();
                Console.WriteLine("Numero de soci: " + nsoci);
                sociHash.Add("Nom", nom);
                sociHash.Add("Soci", nsoci);
                sociHash.Add("SociPare", nSociPare);

                Console.WriteLine();
                Console.WriteLine("COMPROVI LES DADES: ");
                Console.WriteLine("Nou nº de Soci Infantil: " + nsoci);
                Console.WriteLine("Nom: " + nom);
                Console.Write("Confirmar: S/N ");
                resposta = Console.ReadLine();
                resposta.ToLower();
                if (resposta.Equals("s"))
                {
                    SociController.addSociInfantil(sociHash);
                    Console.WriteLine();
                    Console.WriteLine("Soci infantil  afegit correctament.");
                }
                else
                {
                    Console.WriteLine("Operació Cancelada.");
                }
                Console.WriteLine();
            }
            else
            {
                Console.Write("Soci no trobat:");
            }
            Console.WriteLine();
        }
        public void eliminarSoci()
        {
            int nSoci = 0;
            string sociTrobat;
            bool encontrado = false;
            bool borrarSoci = true;
            int opcio;

            /*bool tryBien = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("ELIMINAR SOCI:");
                do {
                    try
                    {
                        Console.Write("Introdueix el número de Soci: ");
                        nSoci = int.Parse(Console.ReadLine());
                        tryBien = true;
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                } while (!tryBien);*///Com posar un do while a un try and catch

            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("ELIMINAR SOCI:");
                    Console.Write("Introdueix el número de Soci: ");
                    nSoci = int.Parse(Console.ReadLine());
                    sociTrobat = SociController.trobaSociString(nSoci);//BUSCA EL SOCI PER MOSTRAR-LO
                    borrarSoci = SociController.GetExcursioBySoci(nSoci);//BUSCA SI EL SOCI HA FET EXCUERSIONS
                    if (sociTrobat != "")
                    {
                        Console.WriteLine();
                        Console.WriteLine(sociTrobat.ToString());
                        if (!borrarSoci)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Confirmi la baixa: ");
                            Console.Write("1- Si\t 2-No: ");
                            opcio = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (opcio == 1)
                            {
                                SociController.deleteSoci(sociTrobat);
                                Console.WriteLine("El soci s'ha eliminat satisfactòriament.");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Operació cancelada");
                                Console.WriteLine();
                            }
                            encontrado = true;
                        }
                        else
                        {
                            Console.WriteLine("El Soci no es pot eliminar, ja que ha ");
                            Console.WriteLine("estat inscrit en una excursió amb anterioritat.");
                            Console.WriteLine();
                        }
                        encontrado = true;
                    }
                    else
                    {
                        Console.WriteLine("No hi ha cap soci amb aquest número. ");
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Dades introduides erronies.");
                    Console.WriteLine(error.Message);

                }
            } while (!encontrado);  //"0".Contains(opcion);

        }
        public void mostrarSocis()
        {
            int opcio = 0;
            bool triaBe = false;

            Console.WriteLine();
            Console.WriteLine("MOSTRAR SOCIS:");
            Console.WriteLine("---------------");
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Tria la opció:");
                    Console.WriteLine("1- Llistar tots els socis: ");
                    Console.WriteLine("2-Llistar els socis Standar:");
                    Console.WriteLine("3-Llistar els socis Federats: ");
                    Console.Write("4-Llistar socis Infantils: ");
                    opcio = int.Parse(Console.ReadLine());
                    triaBe = true;
                }
                catch (Exception error)
                {
                    Console.WriteLine();
                    Console.WriteLine("Introdueix un número de l'1 al 4 ");
                    Console.WriteLine(error.Message);
                    Console.WriteLine();
                }
            } while (!triaBe && opcio != 1234);

            Console.WriteLine();
            List<string> llistaSocis = SociController.llistaSocis(opcio);

            switch (opcio)
            {
                case 1:
                    Console.WriteLine("Socis registrats: ");
                    foreach (string socis in llistaSocis)
                    {
                        Console.WriteLine(socis.ToString());
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Socis Standar registrats: ");
                    foreach (string socisS in llistaSocis)
                    {
                        Console.WriteLine(socisS.ToString());
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Socis federats registrats: ");
                    foreach (string socisF in llistaSocis)
                    {
                        Console.WriteLine(socisF.ToString());
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Socis infantils registrats: ");
                    foreach (string socisI in llistaSocis)
                    {
                        Console.WriteLine(socisI.ToString());
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
            }
        }
        public void facturaMensualSoci()
        {
            int nSoci = 0;
            int month = 0;
            string sociTrobat;
            decimal quotaMensual, quotaExcursions;
            bool triaBe = false;
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("FACTURA MENSUAL SOCI: ");
                    Console.WriteLine();
                    Console.WriteLine("Introdueix el mes: ");
                    Console.WriteLine("1- Gener       7-Juliol");
                    Console.WriteLine("2-Febrer       8-Agost");
                    Console.WriteLine("3-Març         9-Setembre");
                    Console.WriteLine("4-Abril       10-Octubre");
                    Console.WriteLine("5-Maig        11-Novembre");
                    Console.Write("6-Juny        12-Desembre:  ");
                    month = int.Parse(Console.ReadLine());
                    Console.Write("Introdueix el número de soci: ");
                    nSoci = int.Parse(Console.ReadLine());
                    triaBe = true;
                }
                catch (Exception error)
                {
                    Console.WriteLine();
                    Console.WriteLine("Introdueixi números del 0 al 9 ");
                    Console.WriteLine(error.Message);
                    Console.WriteLine();

                }
            } while (!triaBe && month != 0123456789 && nSoci != 0123456789);
                                                       
            sociTrobat = SociController.trobaSociString(nSoci);
            if (sociTrobat != "")
            {
                Console.WriteLine();
                Console.WriteLine(sociTrobat.ToString());
                Console.WriteLine();
                quotaMensual = SociController.getQuotaMensual(sociTrobat);
                Console.WriteLine("Quota de soci Mensual: ");
                Console.WriteLine(quotaMensual + "Euros");
                quotaExcursions = SociController.getQuotaExcursions(sociTrobat, month);
                Console.WriteLine();
                Console.WriteLine("Preu total de les excursions realitzades: ");
                Console.WriteLine(quotaExcursions + " Euros");
                Console.WriteLine();
                Console.WriteLine("Total Factura: ");
                Console.WriteLine(quotaMensual + quotaExcursions + " Euros");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No hi ha cap soci amb aquest número. ");
            }
        }
    }
}