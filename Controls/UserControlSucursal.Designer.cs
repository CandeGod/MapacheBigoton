namespace MapacheBigoton.Controls
{
    partial class UserControlSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSucursal));
            lblUbicacion = new Label();
            pictureBox1 = new PictureBox();
            lblDireccion = new Label();
            pbEditar = new PictureBox();
            pbEliminar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).BeginInit();
            SuspendLayout();
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbicacion.ForeColor = Color.White;
            lblUbicacion.Location = new Point(38, 31);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(125, 25);
            lblUbicacion.TabIndex = 0;
            lblUbicacion.Text = "Ubicacion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.White;
            lblDireccion.Location = new Point(94, 93);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(120, 25);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Direccion";
            // 
            // pbEditar
            // 
            pbEditar.Image = Properties.Resources.boton_editar;
            pbEditar.Location = new Point(612, 14);
            pbEditar.Name = "pbEditar";
            pbEditar.Size = new Size(30, 30);
            pbEditar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEditar.TabIndex = 3;
            pbEditar.TabStop = false;
            pbEditar.Click += pbEditar_Click;
            pbEditar.MouseEnter += pbEditar_MouseEnter;
            pbEditar.MouseLeave += pbEditar_MouseLeave;
            // 
            // pbEliminar
            // 
            pbEliminar.Image = Properties.Resources.eliminar;
            pbEliminar.Location = new Point(648, 14);
            pbEliminar.Name = "pbEliminar";
            pbEliminar.Size = new Size(30, 30);
            pbEliminar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEliminar.TabIndex = 4;
            pbEliminar.TabStop = false;
            pbEliminar.Click += pbEliminar_Click;
            pbEliminar.MouseEnter += pbEliminar_MouseEnter;
            pbEliminar.MouseLeave += pbEliminar_MouseLeave;
            // 
            // UserControlSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(pbEliminar);
            Controls.Add(pbEditar);
            Controls.Add(lblDireccion);
            Controls.Add(pictureBox1);
            Controls.Add(lblUbicacion);
            Name = "UserControlSucursal";
            Size = new Size(700, 150);
            Paint += UserControlSucursal_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUbicacion;
        private PictureBox pictureBox1;
        private Label lblDireccion;
        private PictureBox pbEditar;
        private PictureBox pbEliminar;
    }
}
