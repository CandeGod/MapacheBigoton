namespace MapacheBigoton.Controls
{
    partial class UserControlCitaAgendada
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblFecha = new Label();
            lblCliente = new Label();
            lblBarbero = new Label();
            lblServicio = new Label();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(35, 17);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(35, 55);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(62, 20);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente: ";
            // 
            // lblBarbero
            // 
            lblBarbero.AutoSize = true;
            lblBarbero.Location = new Point(35, 97);
            lblBarbero.Name = "lblBarbero";
            lblBarbero.Size = new Size(65, 20);
            lblBarbero.TabIndex = 2;
            lblBarbero.Text = "Barbero:";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(35, 135);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(64, 20);
            lblServicio.TabIndex = 3;
            lblServicio.Text = "Servicio:";
            // 
            // UserControlCitaAgendada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblServicio);
            Controls.Add(lblBarbero);
            Controls.Add(lblCliente);
            Controls.Add(lblFecha);
            Name = "UserControlCitaAgendada";
            Size = new Size(400, 174);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblCliente;
        private Label lblBarbero;
        private Label lblServicio;
    }
}
