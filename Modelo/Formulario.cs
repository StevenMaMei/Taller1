using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Formulario
    {
        private int cedula;
        private string codigo;
        private string nombre;
        private string placa;
        private string horario;

        public Formulario(int ced, string cod, string nom, string pla, string hor)
        {
            Cedula = ced;
            Codigo = cod;
            Nombre = nom;
            Placa = pla;
            Horario = hor;
        }

        public int Cedula { get => cedula; set => cedula = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Horario { get => horario; set => horario = value; }

        public override string ToString()
        {
            return cedula + "," + codigo + "," + nombre + "," + placa + "," + horario + ",";
        }
    }
}
