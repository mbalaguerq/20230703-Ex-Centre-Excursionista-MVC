using _20230703_Ex_Centre_Excursionista_MVC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230703_Ex_Centre_Excursionista_MVC.Vista
{
    internal class AssegurView
    {
        AssegurController assegurController;
        public AssegurView() { }
        public AssegurView(AssegurController passegurController)
        {
            assegurController = passegurController;
        }
        public void modifiasseg()
        {
            string sociString;
            int nSoci;
            string resposta;

            Console.WriteLine();
            Console.WriteLine("Modificació d'assegurança: ");
            Console.WriteLine();
            Console.WriteLine("Introdueix el número de soci: ");
            nSoci=int.Parse(Console.ReadLine());
            sociString = assegurController.getSociByNumero(nSoci);
            Console.WriteLine(sociString);
            resposta= confirmCanvi();
            if(resposta.Equals("si"))
                {
                assegurController.actualAsseg(nSoci);
            }


        }
        public string confirmCanvi()
        {
            string resposta ;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Desitja canviar el tipus d'Assegurança?:");
                Console.Write("1  SI.\t 2 NO");
                resposta = Console.ReadLine();
                resposta.ToLower();
            } while (!resposta.Equals("si") && !resposta.Equals("no"));
            return resposta;
        }
    }
}
