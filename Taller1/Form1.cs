using System;
using System.Windows.Forms;
using Modelo;
namespace Taller1
{

    public partial class Form1 : Form
    {
        private Manejador modelo;

        public Form1()
        {
            InitializeComponent();
            Modelo = new Manejador();
        }

        public Manejador Modelo { get => modelo; set => modelo = value; }

        private void controlBotones1_Load(object sender, EventArgs e)
        {
            ControlBotones c=(ControlBotones)sender;
            c.Principal = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void crearFormulario()
        {
  
           modelo.crearNuevoFormulario(Int32.Parse(controlInformacion1.darCedula()), controlInformacion1.darCodigo(), controlInformacion1.darNombre(), controlInformacion1.darPlaca(), controlInformacion1.darHorario());
        }

        public void buscarUsuario(String n)
        {
            String[] info = modelo.buscarFormulario(n).Split(',');
            controlInformacion1.setCedula(info[0]);
            controlInformacion1.setCodigo(info[1]);
            controlInformacion1.setNombre(info[2]);
            controlInformacion1.setPlaca(info[3]);
            controlInformacion1.setHorario(info[4], info[4].Substring(info[4].Length - 2));
        }
        public void usuariosRegistrados()
        {
            MessageBox.Show("Hay " + modelo.cuantosRegistrados() + " usuarios registrados");
        }
        public void guardarEstado()
        {
            modelo.guardarFormularios();
        }

        private void controlInformacion1_Load(object sender, EventArgs e)
        {

        }
    }
}
