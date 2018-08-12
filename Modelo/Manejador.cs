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

        public String actualizarFormulario(int cedula, string codigo, string nombre, string placa, string horario)
        {
            String retorno = "";
            Formulario f1 = baseDatos.Find(x => x.Codigo.Equals(codigo));
            if(f1 == null)
            {
                retorno = "Usuario con el código "+codigo+ " no encontrado";
            }
            else
            {
                f1.Cedula = cedula;
                f1.Codigo = codigo;
                f1.Nombre = nombre;
                f1.Placa = placa;
                f1.Horario = horario;
                guardarFormularios();
                retorno = "Usuario con el código " + codigo + " modificado";
            }
            return retorno;
        }

        public void guardarFormularios()
        {
            String formularios = "";
            for(int i = 0; i < baseDatos.Count; i++)
            {
                formularios += baseDatos[i].ToString() + "\n";
            }
                System.IO.File.WriteAllText(@".\guardar.txt",formularios);
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
                    String horario = form[4]+ ","+ form[5]+ "," + form[6]+ "," + form[7]+ "," + form[8]+ "," + form[9]+ "," + form[10]+ "," + form[11]+ "," + form[12]+ "," + form[13];
                    Formulario agregar = new Formulario(Int32.Parse(form[0]), form[1], form[2], form[3], horario);
                    baseDatos.Add(agregar);
                }
            }catch(Exception e)
            {

            }
            
        }

        

    }
}
