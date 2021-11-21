using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Arbolbin a = new Arbolbin();

            a.InsertarNodo(new Postulante(rand.Next(0, 100), "Juan", "Linares", "Telecomunicaciones"));
            a.InsertarNodo(new Postulante(rand.Next(0, 100), "Daniel", "Gutierres", "Ing. de Sistemas"));
            a.InsertarNodo(new Postulante(rand.Next(0, 100), "Paola", "Aguirre", "Psicologia"));
            a.InsertarNodo(new Postulante(rand.Next(0, 100), "Diana", "Montoya", "Psicologia"));
            a.InsertarNodo(new Postulante(rand.Next(0, 100), "Pablo", "Perez", "Telecomunicaciones"));

            Console.WriteLine("Mostramos en Preorden\n");
            a.Preorden(a.GetRaiz());

            Console.WriteLine("Mostramos en Inorden\n");
            a.Inorden(a.GetRaiz());

            Console.WriteLine("Mostramos en Postorden\n");
            a.Postorden(a.GetRaiz());

            Console.ReadKey();
        }
    }
}
