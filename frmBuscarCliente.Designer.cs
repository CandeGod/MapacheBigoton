namespace MapacheBigoton
{
    partial class frmBuscarCliente
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbTel = new TextBox();
            bBuscar = new Button();
            txtNom = new TextBox();
            label2 = new Label();
            bSelect = new Button();
            bCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            //pictureBox1.Image = Properties.Resources.mapacheBigoton;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(82, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 133);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 1;
            label1.Text = "Teléfono:";
            // 
            // tbTel
            // 
            tbTel.Location = new Point(82, 168);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(100, 23);
            tbTel.TabIndex = 2;
            // 
            // bBuscar
            // 
            bBuscar.Location = new Point(92, 220);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(75, 23);
            bBuscar.TabIndex = 3;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = true;
            bBuscar.Click += bBuscar_Click;
            // 
            // txtNom
            // 
            txtNom.Enabled = false;
            txtNom.Location = new Point(46, 298);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(169, 23);
            txtNom.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 274);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // bSelect
            // 
            bSelect.Enabled = false;
            bSelect.Location = new Point(92, 341);
            bSelect.Name = "bSelect";
            bSelect.Size = new Size(75, 23);
            bSelect.TabIndex = 6;
            bSelect.Text = "Seleccionar";
            bSelect.UseVisualStyleBackColor = true;
            bSelect.Click += bSelect_Click;
            // 
            // bCerrar
            // 
            bCerrar.Enabled = false;
            bCerrar.Location = new Point(213, 415);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(60, 23);
            bCerrar.TabIndex = 7;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += bCerrar_Click;
            // 
            // frmBuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 450);
            Controls.Add(bCerrar);
            Controls.Add(bSelect);
            Controls.Add(label2);
            Controls.Add(txtNom);
            Controls.Add(bBuscar);
            Controls.Add(tbTel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmBuscarCliente";
            Text = "frmBuscarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbTel;
        private Button bBuscar;
        private TextBox txtNom;
        private Label label2;
        private Button bSelect;
        private Button bCerrar;
    }
}