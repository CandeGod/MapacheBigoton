namespace MapacheBigoton
{
    partial class frmInicioSucursales
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
            label1 = new Label();
            flpSucursales = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            btnAgregarSucursal = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(263, 61);
            label1.Name = "label1";
            label1.Size = new Size(384, 35);
            label1.TabIndex = 1;
            label1.Text = "Gestión de Sucursales ";
            // 
            // flpSucursales
            // 
            flpSucursales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpSucursales.AutoScroll = true;
            flpSucursales.Location = new Point(50, 145);
            flpSucursales.Margin = new Padding(0);
            flpSucursales.Name = "flpSucursales";
            flpSucursales.Size = new Size(750, 300);
            flpSucursales.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mapacheBigoton;
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnAgregarSucursal
            // 
            btnAgregarSucursal.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarSucursal.Location = new Point(668, 49);
            btnAgregarSucursal.Name = "btnAgregarSucursal";
            btnAgregarSucursal.Size = new Size(132, 48);
            btnAgregarSucursal.TabIndex = 5;
            btnAgregarSucursal.Text = "Agregar Sucursal";
            btnAgregarSucursal.UseVisualStyleBackColor = true;
            btnAgregarSucursal.Click += btnAgregarSucursal_Click;
            // 
            // frmInicioSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 45, 50);
            ClientSize = new Size(834, 461);
            Controls.Add(btnAgregarSucursal);
            Controls.Add(pictureBox1);
            Controls.Add(flpSucursales);
            Controls.Add(label1);
            Name = "frmInicioSucursales";
            Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpSucursales;
        private PictureBox pictureBox1;
        private Button btnAgregarSucursal;
    }
}