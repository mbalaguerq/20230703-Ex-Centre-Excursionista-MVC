﻿using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
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
            string nom, nif, tipAss;
            TipoSeguro tipus;

            Console.WriteLine();
            Console.WriteLine("Nou Soci:");
            Console.Write("Introdueix Nif:");
            nif = Console.ReadLine();
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
                    Console.WriteLine("Seleccioni el tipus d'assegurança: ");
                    Console.WriteLine("1- Bàsica ");
                    Console.Write("2-Completa ");
                    tipAss = Console.ReadLine();
                    if (tipAss.Equals("1"))
                    {
                        tipus = TipoSeguro.basic;
                        SociController.triaAsseg(tipus);

                        Assegurança asseg = SociController.triaAsseg(tipus);
                        sociHash.Add("Assegurança", asseg);
                        Console.WriteLine(asseg.ToString());
                    }
                    if (tipAss.Equals("2"))
                    {
                        tipus = TipoSeguro.complert;
                        SociController.triaAsseg(tipus);

                        Assegurança asseg = SociController.triaAsseg(tipus);
                        sociHash.Add("Assegurança", asseg);
                        Console.WriteLine(asseg.ToString());
                    }
                } while (!"12".Contains(tipAss));
                Console.WriteLine();

                SociController.addSociStan(sociHash);
            }
        }
        public void afegirSociFederat()
        {
            Hashtable sociHash = new Hashtable();
            int nsoci;
            string nom, nif;
            int triaFede;

            Console.WriteLine();
            Console.WriteLine("Nou Soci Federat :");
            Console.Write("Introdueix Nif:");
            nif = Console.ReadLine();
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
                        SociController.triaFede(triaFede);

                        Federacio fedeTrobada = SociController.triaFede(triaFede);
                        sociHash.Add("Federacio", fedeTrobada);
                    }
                    if (triaFede == 2)
                    {
                        triaFede = 002;
                        SociController.triaFede(triaFede);

                        Federacio fedeTrobada = SociController.triaFede(triaFede);
                        sociHash.Add("Federacio", fedeTrobada);
                    }
                } while ((triaFede != 1 && triaFede != 2));
                Console.WriteLine();
                SociController.addSociFede(sociHash);
            }
        }
        public void afegirSociInfantil()
        {
            Hashtable sociHash = new Hashtable();
            int nsoci;

            string nom, nif;


            Console.WriteLine();
            Console.WriteLine("Nou Soci Infantil :");
            Console.Write("Introdueix Nif del Pare:");
            nif = Console.ReadLine();
            Console.WriteLine();

            Soci pare = SociController.buscarPareByNif(nif);

            if (pare != null)
            {
                Console.WriteLine(pare.ToString());
                Console.WriteLine();
                Console.Write("Introdueix el nom del Soci Infantil:");
                nom = Console.ReadLine();
                nsoci = SociController.nouNSoci();
                Console.WriteLine("Numero de soci: " + nsoci);
                sociHash.Add("Nom", nom);
                sociHash.Add("Soci", nsoci);
                sociHash.Add("SociPare", pare.Nsoci);

                SociController.addSociInfantil(sociHash);

            }
            else
            {
                Console.Write("Soci no trobat:");
            }
            Console.WriteLine();           
        }
        public void eliminarSoci()
        {
            int nSoci;
            Soci sociTrobat;
            bool encontrado=false;
            int opcio;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Eliminar Soci:");
                Console.Write("Introdueix el número de Soci: ");
                nSoci = int.Parse(Console.ReadLine());
                sociTrobat = SociController.trobaSoci(nSoci);
                if (sociTrobat != null)
                {
                    Console.WriteLine(sociTrobat.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Confirmi la baixa: ");
                    Console.Write("1- Si\t 2-No");
                    opcio= int.Parse(Console.ReadLine());
                    if (opcio != 1)
                    {
                        SociController.deleteSoci(sociTrobat);

                        Console.WriteLine("El soci s'ha eliminat satisfactòriament.");
                    }
                    encontrado = true;
                }
                else
                {
                    Console.WriteLine("No hi ha cap soci amb aquest número. ");                    

                }
            } while (!encontrado);  //"0".Contains(opcion);

        }

        public void mostrarSocis()
        {
            int opcio;

            Console.WriteLine();
            Console.WriteLine("Mostrar Socis:");
            Console.WriteLine("Tria la opció:");
            Console.WriteLine("1- Llistar tots els socis: ");
            Console.WriteLine("2-Llistar els socis Standar:");
            Console.WriteLine("3-Llistar els socis Federats: ");
            Console.Write("4-Llistar socis Infantils: ");
            opcio = int.Parse(Console.ReadLine());
            List<string> llistaSocis = SociController.llistaSocis(opcio); 
        }

    }
}