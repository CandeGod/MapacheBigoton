namespace MapacheBigoton
{
    partial class frmEditarSucursal
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
            txtUbicacion = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            txtDireccion = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(224, 62);
            txtUbicacion.Margin = new Padding(2);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(250, 23);
            txtUbicacion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            label1.Location = new Point(61, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 4;
            label1.Text = "Ubicación:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(548, 85);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 42);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(224, 111);
            txtDireccion.Margin = new Padding(2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(250, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            label2.Location = new Point(61, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 6;
            label2.Text = "Dirección:";
            // 
            // frmEditarSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 209);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(txtUbicacion);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Name = "frmEditarSucursal";
            Text = "frmEditarSucursal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUbicacion;
        private Label label1;
        private Button btnGuardar;
        private TextBox txtDireccion;
        private Label label2;
    }
}