namespace MapacheBigoton
{
    partial class frmAgendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbBarberos = new ComboBox();
            cbServicios = new ComboBox();
            dtFecha = new DateTimePicker();
            bAgendar = new Button();
            numHora = new NumericUpDown();
            numMinu = new NumericUpDown();
            cbClientes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinu).BeginInit();
            SuspendLayout();
            // 
            // cbBarberos
            // 
            cbBarberos.FormattingEnabled = true;
            cbBarberos.Location = new Point(67, 133);
            cbBarberos.Name = "cbBarberos";
            cbBarberos.Size = new Size(234, 23);
            cbBarberos.TabIndex = 1;
            // 
            // cbServicios
            // 
            cbServicios.FormattingEnabled = true;
            cbServicios.Location = new Point(67, 162);
            cbServicios.Name = "cbServicios";
            cbServicios.Size = new Size(234, 23);
            cbServicios.TabIndex = 2;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(67, 75);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(234, 23);
            dtFecha.TabIndex = 5;
            // 
            // bAgendar
            // 
            bAgendar.Location = new Point(67, 191);
            bAgendar.Name = "bAgendar";
            bAgendar.Size = new Size(75, 23);
            bAgendar.TabIndex = 6;
            bAgendar.Text = "Agendar";
            bAgendar.UseVisualStyleBackColor = true;
            bAgendar.Click += bAgendar_Click;
            // 
            // numHora
            // 
            numHora.Location = new Point(67, 46);
            numHora.Maximum = new decimal(new int[] { 17, 0, 0, 0 });
            numHora.Minimum = new decimal(new int[] { 9, 0, 0, 0 });
            numHora.Name = "numHora";
            numHora.Size = new Size(36, 23);
            numHora.TabIndex = 7;
            numHora.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // numMinu
            // 
            numMinu.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            numMinu.Location = new Point(109, 46);
            numMinu.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            numMinu.Name = "numMinu";
            numMinu.Size = new Size(36, 23);
            numMinu.TabIndex = 8;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(67, 104);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(234, 23);
            cbClientes.TabIndex = 9;
            // 
            // frmAgendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 585);
            Controls.Add(cbClientes);
            Controls.Add(numMinu);
            Controls.Add(numHora);
            Controls.Add(bAgendar);
            Controls.Add(dtFecha);
            Controls.Add(cbServicios);
            Controls.Add(cbBarberos);
            Name = "frmAgendar";
            Text = "frmAgendar";
            Load += frmAgendar_Load;
            ((System.ComponentModel.ISupportInitialize)numHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbBarberos;
        private ComboBox cbServicios;
        private DateTimePicker dtFecha;
        private Button bAgendar;
        private NumericUpDown numHora;
        private NumericUpDown numMinu;
        private ComboBox cbClientes;
    }
}