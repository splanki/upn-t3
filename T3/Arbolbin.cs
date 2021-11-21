using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
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

        public void InsertarNodo(Postulante x)
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
    }
}
