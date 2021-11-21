using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_2
{
    public class HClinica
    {
        public int id;
        public string clinica, paciente;

        public HClinica(int id, string clinica, string paciente)
        {
            this.id = id;
            this.clinica = clinica;
            this.paciente = paciente;
        }

        public override string ToString()
        {
            return $"\nID: {id}\nClinica: {clinica}\nPaciente: {paciente}\n";
        }
    }
}
