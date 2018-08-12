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
            if (controlInformacion1.darCodigo().Equals("") || controlInformacion1.darNombre().Equals("") || controlInformacion1.darPlaca().Equals(""))
                 throw new Exception("Campos inválidos, por favor verifique los datos escritos");
           modelo.crearNuevoFormulario(Int32.Parse(controlInformacion1.darCedula()), controlInformacion1.darCodigo(), controlInformacion1.darNombre(), controlInformacion1.darPlaca(), controlInformacion1.darHorario());
        }

        public void buscarUsuario(String n)
        {
            String[] info = modelo.buscarFormulario(n).Split(',');
            controlInformacion1.setCedula(info[0]);
            controlInformacion1.setCodigo(info[1]);
            controlInformacion1.setNombre(info[2]);
            controlInformacion1.setPlaca(info[3]);
            controlInformacion1.setHorarioL(info[4], info[4].Substring(info[4].Length - 2));
            controlInformacion1.setHorarioSL(info[5], info[5].Substring(info[5].Length - 2));
            controlInformacion1.setHorarioMa(info[6], info[6].Substring(info[6].Length - 2));
            controlInformacion1.setHorarioSMa(info[7], info[7].Substring(info[7].Length - 2));
            controlInformacion1.setHorarioMi(info[8], info[8].Substring(info[8].Length - 2));
            controlInformacion1.setHorarioSMi(info[9], info[9].Substring(info[9].Length - 2));
            controlInformacion1.setHorarioJ(info[10], info[10].Substring(info[10].Length - 2));
            controlInformacion1.setHorarioSJ(info[11], info[11].Substring(info[11].Length - 2));
            controlInformacion1.setHorarioV(info[12], info[12].Substring(info[12].Length - 2));
            controlInformacion1.setHorarioSV(info[13], info[13].Substring(info[13].Length - 2));


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
