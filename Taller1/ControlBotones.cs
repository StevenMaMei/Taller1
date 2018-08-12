using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1
{
    public partial class ControlBotones : UserControl
    {
        private Form1 principal;
        public ControlBotones()
        {
            InitializeComponent();
            
        }

        public Form1 Principal { get => principal; set => principal = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Principal.crearFormulario();

            }catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principal.guardarEstado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                principal.buscarUsuario(textBox1.Text);

            }catch(Exception a)
            {

                MessageBox.Show("Usuario no encontrado" + a.StackTrace);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            principal.usuariosRegistrados();
        }

        private void ControlBotones_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            principal.actualizarInformacion();
        }
    }
}
