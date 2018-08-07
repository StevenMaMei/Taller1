using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Manejador
    {
        static void Main(string[] args)
        {
        }
        private List<Formulario> baseDatos;

        public Manejador()
        {
            baseDatos = new List<Formulario>();
            cargarElementos();
        }

        //<exception cref="Exception"></exception>
        public void crearNuevoFormulario(int cedula,string codigo,string nombre,string placa,string horario)
        {

            Formulario nuevo = baseDatos.Find(x => x.Codigo.Equals(codigo));
            if(nuevo == null)
            {
                nuevo = new Formulario(cedula, codigo, nombre, placa, horario);
                baseDatos.Add(nuevo);
            }
            else
            {
                throw new Exception("Usuario existente");
            }
        }

        public void guardarFormularios()
        {
            for(int i = 0; i < baseDatos.Count; i++)
            {
                System.IO.File.WriteAllText(@".\guardar.txt",baseDatos[i].ToString()+"\n");
            }
        }

        public string buscarFormulario(string cod)
        {
            return baseDatos.Find(x => x.Codigo.Equals(cod)).ToString();
        }

        public int cuantosRegistrados()
        {
            return baseDatos.Count;
        }

        private void cargarElementos()
        {
            try {
                string[] lines = System.IO.File.ReadAllLines(@".\guardar.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    String[] form = lines[i].Split(',');
                    Formulario agregar = new Formulario(Int32.Parse(form[0]), form[1], form[2], form[3], form[4]);
                    baseDatos.Add(agregar);
                }
            }catch(Exception e)
            {

            }
            
        }

        

    }
}
