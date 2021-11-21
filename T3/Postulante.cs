using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class Postulante
    {
        public int id;
        public string nombre, apellido, carrera;

        public Postulante(int id, string nombre,string apellido, string carrera)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.carrera = carrera;
        }

        public override string ToString()
        {
            return $"ID: {id}\nNombre: {nombre}\nApellido: {apellido}\nCarrera: {carrera}\n";
        }
    }
}
