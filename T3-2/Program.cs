using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Arbolbin a = new Arbolbin();

            a.InsertarNodo(new HClinica(5,"Historia Clinica 5","Paciente 5"));
            a.InsertarNodo(new HClinica(1,"Historia Clinica 1","Paciente 1"));
            a.InsertarNodo(new HClinica(6, "Historia Clinica 6", "Paciente 6"));
            a.InsertarNodo(new HClinica(10, "Historia Clinica 10", "Paciente 10"));
            a.InsertarNodo(new HClinica(11, "Historia Clinica 11", "Paciente 11"));
            a.InsertarNodo(new HClinica(15, "Historia Clinica 15", "Paciente 15"));

            Console.WriteLine("Busqueda para la historia clinica número 15\n");
            a.BuscarPorLlave(15);

           /* Console.Write("Ordenamiento Preorden\n");
            a.Preorden(a.GetRaiz());

            Console.WriteLine("Busqueda para la historia clinica número 15\n");
            a.BuscarPorLlave(15);

            Console.Write("Ordenamiento Inorden\n");
            a.Inorden(a.GetRaiz());

            Console.WriteLine("Busqueda para la historia clinica número 15\n");
            a.BuscarPorLlave(15);*/

            Console.Write("Ordenamiento Postorden\n");
            a.Postorden(a.GetRaiz());

            Console.WriteLine("Busqueda para la historia clinica número 15\n");
            a.BuscarPorLlave(15);
            Console.WriteLine("");

            a.BuscarPorValor(a.GetRaiz(), new HClinica(15, "Historia Clinica 15", "Paciente 15"), 0);


            Console.ReadKey();
        }
    }
}
