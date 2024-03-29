﻿using _20230703_Ex_Centre_Excursionista_MVC.Model;
using _20230703_Ex_Centre_Excursionista_MVC.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Controlador
{
    internal class ProgControlador
    {
        CentreExcursionista datos;
        View vista;
        public ProgControlador(CentreExcursionista datos, View vista)//aquest constructor no s'esta executantv mai
        {
            this.datos = datos;
            this.vista = vista;
        }
        public ProgControlador()
        {
            datos = new CentreExcursionista();
            vista = new View();
            //Executo la càrrega de dades al fer el New de centre exc.
            datos.carregaParametres();
        }
        public void gestionMenu()
        {
            bool salir = false;
            string opcion;
            do
            {
                opcion = vista.vistaMenu();
                switch (opcion)
                {
                    case "2.1":
                        afegirExcursio();
                        break;
                    case "2.2":
                        mostrarExcursio();
                        break;
                    case "2.3":
                        leerCSV();
                        break;
                    case "2.4":
                        grabarCSV();
                        break;
                    case "2.5":
                        carregaCSV();
                        break;
                    case "3.1":
                        afegirSociEstandar();
                        break;
                    case "3.2":
                        modifAsseg();
                        break;
                    case "3.3":
                        afegirSociFederat();
                        break;
                    case "3.4":
                        afegirSociInfantil();
                        break;
                    case "3.5":
                        eliminarSoci();
                        break;
                    case "3.6":
                        mostrarSocis();
                        break;
                    case "3.7":
                        facturaMensualSoci();
                        break;
                    case "4.1":
                        afegirInscripcio();
                        break;
                    case "4.2":
                        eliminarInscripcio();
                        break;
                    case "5.1":
                        llistaInscripBySoci();
                        break;
                    case "5.2":
                        LlistaInscripByData();
                        break;
                    case "0":
                        salir = true;
                        break;
                }
            } while (!salir);
        }
        private void afegirExcursio()
        {
            ExcursioController excursioController = new ExcursioController(datos);
            ExcursioView excursioView = new ExcursioView(excursioController);
            excursioView.afegirExcursio();
        }
        private void mostrarExcursio()
        {
            List<string> llistaExcursions = datos.llistaExcursions();
            ExcursioController excursioController = new ExcursioController(datos);
            ExcursioView excursioView = new ExcursioView(excursioController);
            excursioView.mostrarExcursio();
        }
        private void afegirSociEstandar()
        {
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            sociView.afegirSociStandar();
        }
        private void modifAsseg()
        {
            AssegurController assegurController = new AssegurController(datos);
            AssegurView assegurView = new AssegurView(assegurController);
            assegurView.modifiasseg();
        }
        private void afegirSociFederat()
        {
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            sociView.afegirSociFederat();
        }
        private void afegirSociInfantil()
        {
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            sociView.afegirSociInfantil();
        }
        private void eliminarSoci()
        {
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            sociView.eliminarSoci();
        }
        private void mostrarSocis()
        {
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            sociView.mostrarSocis();
        }
        private void facturaMensualSoci()
        {
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            sociView.facturaMensualSoci();
        }
        private void afegirInscripcio()
        {
            InscripcioController inscripcioController = new InscripcioController(datos);
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            InscripcioView inscripcioView = new InscripcioView(inscripcioController, sociController, sociView);            
            
            inscripcioView.afegirInscripcio();
        }
        private void eliminarInscripcio()
        {
            InscripcioController inscripcioController = new InscripcioController(datos);
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            InscripcioView inscripcioView = new InscripcioView(inscripcioController, sociController, sociView);

            inscripcioView.eliminarInscripcio();
        }
        private void llistaInscripBySoci()
        {
            InscripcioController inscripcioController = new InscripcioController(datos);
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            InscripcioView inscripcioView = new InscripcioView(inscripcioController, sociController, sociView);

            inscripcioView.llistaInscripBySoci();
        }
        private void LlistaInscripByData()
        {
            InscripcioController inscripcioController = new InscripcioController(datos);
            SociController sociController = new SociController(datos);
            SociView sociView = new SociView(sociController);
            InscripcioView inscripcioView = new InscripcioView(inscripcioController, sociController, sociView);

            inscripcioView.LlistaInscripByData();
        }
        private void leerCSV()
        {
            ExcursioController excursioController = new ExcursioController(datos);
            ExcursioView excursioView = new ExcursioView(excursioController);
            excursioView.leerCSV();
        }
        private void grabarCSV()
        {
            ExcursioController excursioController = new ExcursioController(datos);
            ExcursioView excursioView = new ExcursioView(excursioController);
            excursioView.grabarCSV();
        }
        private void carregaCSV()
        {
            ExcursioController excursioController = new ExcursioController(datos);
            ExcursioView excursioView = new ExcursioView(excursioController);
            excursioView.carregaCSV();
        }
    }
}
