namespace MapacheBigoton
{
    partial class FrmServicios
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
            panelTop = new Panel();
            panelIzquierda = new Panel();
            lblMapaches = new Label();
            panel1 = new Panel();
            btnAgregarServicio = new Button();
            label2 = new Label();
            label1 = new Label();
            panelServicios = new Panel();
            flpServicios = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panelCalendario = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panelMenu = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            panelTop.SuspendLayout();
            panelIzquierda.SuspendLayout();
            panel1.SuspendLayout();
            panelServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCalendario.SuspendLayout();
            panel2.SuspendLayout();
            panelMenu.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(252, 204, 124);
            panelTop.Controls.Add(panelIzquierda);
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5, 6, 5, 6);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1986, 93);
            panelTop.TabIndex = 1;
            // 
            // panelIzquierda
            // 
            panelIzquierda.BackColor = Color.FromArgb(228, 136, 21);
            panelIzquierda.Controls.Add(lblMapaches);
            panelIzquierda.Location = new Point(0, 0);
            panelIzquierda.Margin = new Padding(5, 6, 5, 6);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(361, 93);
            panelIzquierda.TabIndex = 0;
            // 
            // lblMapaches
            // 
            lblMapaches.AutoSize = true;
            lblMapaches.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMapaches.ForeColor = Color.White;
            lblMapaches.Location = new Point(30, 11);
            lblMapaches.Margin = new Padding(5, 0, 5, 0);
            lblMapaches.Name = "lblMapaches";
            lblMapaches.Size = new Size(225, 48);
            lblMapaches.TabIndex = 0;
            lblMapaches.Text = "BARBERIA";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnAgregarServicio);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(361, 93);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1623, 183);
            panel1.TabIndex = 2;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarServicio.Location = new Point(1287, 41);
            btnAgregarServicio.Margin = new Padding(5, 6, 5, 6);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(157, 93);
            btnAgregarServicio.TabIndex = 2;
            btnAgregarServicio.Text = "Agregar Servicio";
            btnAgregarServicio.UseVisualStyleBackColor = true;
            btnAgregarServicio.Click += btnAgregarServicio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 162, 184);
            label2.Location = new Point(49, 121);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(467, 25);
            label2.TabIndex = 1;
            label2.Text = "Tus servicios de barbería para el público";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(220, 53, 69);
            label1.Location = new Point(39, 32);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(544, 53);
            label1.TabIndex = 0;
            label1.Text = "Servicios de barberia";
            // 
            // panelServicios
            // 
            panelServicios.BackColor = Color.White;
            panelServicios.Controls.Add(flpServicios);
            panelServicios.Location = new Point(383, 293);
            panelServicios.Margin = new Padding(5, 6, 5, 6);
            panelServicios.Name = "panelServicios";
            panelServicios.Size = new Size(1571, 1176);
            panelServicios.TabIndex = 3;
            // 
            // flpServicios
            // 
            flpServicios.AutoScroll = true;
            flpServicios.Location = new Point(154, 63);
            flpServicios.Margin = new Padding(5, 6, 5, 6);
            flpServicios.Name = "flpServicios";
            flpServicios.Size = new Size(1271, 1042);
            flpServicios.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.mapacheBigoton;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelCalendario
            // 
            panelCalendario.Controls.Add(label3);
            panelCalendario.Location = new Point(0, 297);
            panelCalendario.Margin = new Padding(0);
            panelCalendario.Name = "panelCalendario";
            panelCalendario.Size = new Size(361, 93);
            panelCalendario.TabIndex = 1;
            panelCalendario.MouseClick += panelCalendario_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(77, 26);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 29);
            label3.TabIndex = 0;
            label3.Text = "Calendario";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 390);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 93);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(77, 26);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 29);
            label4.TabIndex = 0;
            label4.Text = "Servicios";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 45, 50);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(panelCalendario);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(0, 93);
            panelMenu.Margin = new Padding(5, 6, 5, 6);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(361, 1381);
            panelMenu.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 577);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 93);
            panel4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(77, 26);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 29);
            label6.TabIndex = 0;
            label6.Text = "Barberos";
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 483);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 93);
            panel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(77, 26);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 29);
            label5.TabIndex = 0;
            label5.Text = "Clientes";
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(1924, 1053);
            Controls.Add(panelServicios);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmServicios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicios";
            panelTop.ResumeLayout(false);
            panelIzquierda.ResumeLayout(false);
            panelIzquierda.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCalendario.ResumeLayout(false);
            panelCalendario.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelMenu.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private Panel panelIzquierda;
        private Label lblMapaches;
        private Panel panel1;
        private Panel panelServicios;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelCalendario;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Panel panelMenu;
        private Panel panel4;
        private Label label6;
        private Panel panel3;
        private Label label5;
        private FlowLayoutPanel flpServicios;
        private Button btnAgregarServicio;
    }
}