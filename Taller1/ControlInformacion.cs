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
            String horario = "";
            horario += comboHoraEL.Text + ":"+ comboMinutoEL.Text+",";
            horario += comboHoraSL.Text + ":" + comboMinutoSL.Text + ",";
            horario += comboHoraEMa.Text + ":" + comboMinutoEMa.Text + ",";
            horario += comboHoraSMa.Text + ":" + comboMinutoSMa.Text + ",";
            horario += comboHoraEMi.Text + ":" + comboMinutoEMi.Text + ",";
            horario += comboHoraSMi.Text + ":" + comboMinutoSMi.Text + ",";
            horario += comboHoraEJ.Text + ":" + comboMinutoEJ.Text + ",";
            horario += comboHoraSJ.Text + ":" + comboMinutoSJ.Text + ",";
            horario += comboHoraEV.Text + ":" + comboMinutoEV.Text + ",";
            horario += comboHoraSV.Text + ":" + comboMinutoSV.Text + ",";
            return horario;
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
        public void setHorarioL(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
            comboHoraEL.Text = a.Substring(0,1);
            else
                comboHoraEL.Text = a.Substring(0, 2);
            comboMinutoEL.Text = b;
            // falta salida lunes en adelante
        }
        public void setHorarioSL(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
                comboHoraSL.Text = a.Substring(0, 1);
            else
                comboHoraSL.Text = a.Substring(0, 2);
            comboMinutoSL.Text = b;
            // falta salida lunes en adelante
        }
        public void setHorarioMa(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
                comboHoraEMa.Text = a.Substring(0, 1);
            else
                comboHoraEMa.Text = a.Substring(0, 2);
            comboMinutoEMa.Text = b;
        }
        public void setHorarioSMa(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
                comboHoraSMa.Text = a.Substring(0, 1);
            else
                comboHoraSMa.Text = a.Substring(0, 2);
            comboMinutoSMa.Text = b;
        }
        public void setHorarioMi(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
                comboHoraEMi.Text = a.Substring(0, 1);
            else
                comboHoraEMi.Text = a.Substring(0, 2);
            comboMinutoEMi.Text = b;
        }
        public void setHorarioSMi(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
                comboHoraSMi.Text = a.Substring(0, 1);
            else
                comboHoraSMi.Text = a.Substring(0, 2);
            comboMinutoSMi.Text = b;
        }
        public void setHorarioJ(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
                comboHoraEJ.Text = a.Substring(0, 1);
            else
                comboHoraEJ.Text = a.Substring(0, 2);
            comboMinutoEJ.Text = b;
        }
        public void setHorarioSJ(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
                comboHoraSJ.Text = a.Substring(0, 1);
            else
                comboHoraSJ.Text = a.Substring(0, 2);
            comboMinutoSJ.Text = b;
        }
        public void setHorarioV(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
                comboHoraEV.Text = a.Substring(0, 1);
            else
                comboHoraEV.Text = a.Substring(0, 2);
            comboMinutoEV.Text = b;
        }
        public void setHorarioSV(String a, String b)
        {
            if (a.Substring(1, 1).Equals(":"))
                comboHoraSV.Text = a.Substring(0, 1);
            else
                comboHoraSV.Text = a.Substring(0, 2);
            comboMinutoSV.Text = b;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
