using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_2
{
    public class Arbolbin
    {
        public Nodo raiz;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void Inorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.izquierda);
                Console.WriteLine("{0}", raiz.x.ToString());
                Inorden(raiz.derecha);
            }
        }

        public void Preorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine("{0}", raiz.x.ToString());
                Preorden(raiz.izquierda);
                Preorden(raiz.derecha);
            }
        }

        public void Postorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Postorden(raiz.izquierda);
                Postorden(raiz.derecha);
                Console.WriteLine("{0}", raiz.x.ToString());
            }
        }

        public void InsertarNodo(HClinica x)
        {
            Nodo puntero;
            Nodo padre;
            Nodo nodo = new Nodo
            {
                x = x
            };
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (x.id < puntero.x.id)
                    {
                        puntero = puntero.izquierda;
                        if (puntero == null)
                        {
                            padre.izquierda = nodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecha;
                        if (puntero == null)
                        {
                            padre.derecha = nodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nodo;
            }
        }

        public void BuscarPorLlave(int key)
        {
            int contador = 0;
            Nodo puntero = raiz;
            while (puntero != null)
            {
                contador += 1;
                if (puntero.x.id == key)
                {
                    Console.WriteLine("Historia encontrada:\n  {0} ", puntero.x.ToString());
                    Console.WriteLine("Total de iteraciones:" + contador);
                    return;
                }
                else
                {
                    if (key > puntero.x.id)
                    {
                        puntero = puntero.derecha;
                    }
                    else
                    {
                        puntero = puntero.izquierda;
                    }
                }
            }
            Console.WriteLine("No se encontró ninguna historia clinica");
            Console.WriteLine("Total de iteraciones:" + contador);
        }

        public void BuscarPorValor(Nodo puntero, HClinica x, int contador)
        {
            if (puntero != null)
            {
                contador += 1;
                if (puntero.x.clinica == x.clinica)
                {
                    Console.WriteLine("Historial {0} encontrado en posición {1}", puntero.x.ToString(), puntero.x.id);
                    Console.WriteLine("Total de iteraciones:" + contador);
                    return;
                }
                BuscarPorValor(puntero.izquierda, x, contador);
                BuscarPorValor(puntero.derecha, x, contador);
            }
            else
            {
                Console.WriteLine("Total de iteraciones:" + contador);
            }
        }
    }
}
