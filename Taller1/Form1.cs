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
  
           modelo.crearNuevoFormulario(Int32.Parse(controlInformacion2.darCedula()), controlInformacion2.darCodigo(), controlInformacion2.darNombre(), controlInformacion2.darPlaca(), controlInformacion2.darHorario());
        }

        public void buscarUsuario(String n)
        {
            String[] info = modelo.buscarFormulario(n).Split(',');
            controlInformacion2.setCedula(info[0]);
            controlInformacion2.setCodigo(info[1]);
            controlInformacion2.setNombre(info[2]);
            controlInformacion2.setPlaca(info[3]);
            controlInformacion2.setHorario(info[4]);
        }
        public void usuariosRegistrados()
        {
            MessageBox.Show("Hay " + modelo.cuantosRegistrados() + " usuarios registrados");
        }
        public void guardarEstado()
        {
            modelo.guardarFormularios();
        }

    }
}
