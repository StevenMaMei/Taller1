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
    public partial class ControlInformacion : UserControl
    {
        public ControlInformacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ControlInformacion_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
        public String darCedula()
        {
            return txtCedula.Text;
        }
        public String darCodigo()
        {
            return txtCodigo.Text;
        }
        public String darNombre()
        {
            return txtNombre.Text;
        }
        public String darPlaca()
        {
            return txtPlaca.Text;
        }
        public String darHorario()
        {
            return txtHorario.Text;
        }

        public void setCedula(String a)
        {
            txtCedula.Text = a;
        }
        public void setCodigo(String a)
        {
            txtCodigo.Text = a;
        }
        public void setNombre(String a)
        {
            txtNombre.Text = a;
        }
        public void setPlaca(String a)
        {
            txtPlaca.Text = a;
        }
        public void setHorario(String a)
        {
            txtHorario.Text = a;
        }
    }
}
