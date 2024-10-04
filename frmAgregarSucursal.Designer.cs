namespace MapacheBigoton
{
    partial class frmAgregarSucursal
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
            btnAgregarSucursal = new Button();
            pictureBox1 = new PictureBox();
            txtDireccion = new TextBox();
            txtUbicacion = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarSucursal
            // 
            btnAgregarSucursal.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarSucursal.Location = new Point(327, 264);
            btnAgregarSucursal.Name = "btnAgregarSucursal";
            btnAgregarSucursal.Size = new Size(107, 47);
            btnAgregarSucursal.TabIndex = 17;
            btnAgregarSucursal.Text = "Agregar Sucursal";
            btnAgregarSucursal.UseVisualStyleBackColor = true;
            btnAgregarSucursal.Click += btnAgregarSucursal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mapacheBigoton;
            pictureBox1.Location = new Point(62, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(249, 160);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(210, 23);
            txtDireccion.TabIndex = 15;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(249, 99);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(210, 23);
            txtUbicacion.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(62, 167);
            label4.Name = "label4";
            label4.Size = new Size(183, 16);
            label4.TabIndex = 12;
            label4.Text = "Dirección de la barberia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 106);
            label2.Name = "label2";
            label2.Size = new Size(186, 16);
            label2.TabIndex = 10;
            label2.Text = "Ubicación de la barberia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 23);
            label1.Name = "label1";
            label1.Size = new Size(336, 23);
            label1.TabIndex = 9;
            label1.Text = "Agregar sucursal a la barberia";
            // 
            // frmAgregarSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 45, 50);
            ClientSize = new Size(553, 450);
            Controls.Add(btnAgregarSucursal);
            Controls.Add(pictureBox1);
            Controls.Add(txtDireccion);
            Controls.Add(txtUbicacion);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAgregarSucursal";
            Text = "frmAgregarSucursal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarSucursal;
        private PictureBox pictureBox1;
        private TextBox txtDireccion;
        private TextBox txtUbicacion;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}