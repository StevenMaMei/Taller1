namespace Taller1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlBotones1 = new Taller1.ControlBotones();
            this.controlInformacion1 = new Taller1.ControlInformacion();
            this.SuspendLayout();
            // 
            // controlBotones1
            // 
            this.controlBotones1.Location = new System.Drawing.Point(336, 3);
            this.controlBotones1.Name = "controlBotones1";
            this.controlBotones1.Principal = null;
            this.controlBotones1.Size = new System.Drawing.Size(287, 325);
            this.controlBotones1.TabIndex = 0;
            this.controlBotones1.Load += new System.EventHandler(this.controlBotones1_Load);
            // 
            // controlInformacion1
            // 
            this.controlInformacion1.Location = new System.Drawing.Point(2, 3);
            this.controlInformacion1.Name = "controlInformacion1";
            this.controlInformacion1.Size = new System.Drawing.Size(378, 338);
            this.controlInformacion1.TabIndex = 1;
            this.controlInformacion1.Load += new System.EventHandler(this.controlInformacion1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 340);
            this.Controls.Add(this.controlInformacion1);
            this.Controls.Add(this.controlBotones1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlBotones controlBotones1;

        private ControlInformacion controlInformacion1;

        public ControlInformacion ControlInformacion1 { get => controlInformacion1; set => controlInformacion1 = value; }
    }
}

