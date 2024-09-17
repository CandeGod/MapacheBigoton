namespace MapacheBigoton.Controls
{
    partial class UserControlBarber
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
            panel1 = new Panel();
            label1 = new Label();
            lbBarber = new Label();
            lblIdBarbero = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.mapacheBigoton;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(102, 122);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 13);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 1;
            label1.Text = "Datos del Barbero";
            label1.Click += label1_Click;
            // 
            // lbBarber
            // 
            lbBarber.AutoSize = true;
            lbBarber.Location = new Point(169, 56);
            lbBarber.Name = "lbBarber";
            lbBarber.Size = new Size(31, 28);
            lbBarber.TabIndex = 2;
            lbBarber.Text = "N:";
            // 
            // lblIdBarbero
            // 
            lblIdBarbero.AutoSize = true;
            lblIdBarbero.Location = new Point(227, 95);
            lblIdBarbero.Name = "lblIdBarbero";
            lblIdBarbero.Size = new Size(35, 28);
            lblIdBarbero.TabIndex = 3;
            lblIdBarbero.Text = "ID:";
            lblIdBarbero.Click += label3_Click;
            // 
            // UserControlBarber
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            Controls.Add(lblIdBarbero);
            Controls.Add(lbBarber);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UserControlBarber";
            Size = new Size(352, 150);
            Load += UserControlBarber_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lbBarber;
        private Label lblIdBarbero;
    }
}
