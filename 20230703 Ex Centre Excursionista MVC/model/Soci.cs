﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.model
{
    internal abstract class Soci
    {
        private int nsoci;
        private string nom;

        private Inscripcio inscrip;

        public int Nsoci { get => nsoci; set => nsoci = value; }
        public string Nom { get => nom; set => nom = value; }
        internal Inscripcio Inscrip { get => inscrip; set => inscrip = value; }
    }
}
