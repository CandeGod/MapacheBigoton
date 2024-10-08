﻿namespace MapacheBigoton
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
            panelServicios = new Panel();
            panelIzquierda = new Panel();
            lblMapaches = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnAgregarServicio = new Button();
            flpServicios = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panelCalendario = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panelMenu = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            pClientes = new Panel();
            lClientes = new Label();
            panelTop.SuspendLayout();
            panelServicios.SuspendLayout();
            panelIzquierda.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCalendario.SuspendLayout();
            panel2.SuspendLayout();
            panelMenu.SuspendLayout();
            panel4.SuspendLayout();
            pClientes.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = Color.FromArgb(252, 204, 124);
            panelTop.Controls.Add(panelIzquierda);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(850, 50);
            panelTop.TabIndex = 1;
            // 
            // panelServicios
            // 
            panelServicios.BackColor = Color.White;
            panelServicios.Controls.Add(flpServicios);
            panelServicios.Location = new Point(311, 180);
            panelServicios.Margin = new Padding(2);
            panelServicios.Name = "panelServicios";
            panelServicios.Size = new Size(400, 250);
            panelServicios.TabIndex = 3;
            // 
            // panelIzquierda
            // 
            panelIzquierda.BackColor = Color.FromArgb(228, 136, 21);
            panelIzquierda.Controls.Add(lblMapaches);
            panelIzquierda.Location = new Point(0, 0);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(230, 50);
            panelIzquierda.TabIndex = 0;
            // 
            // lblMapaches
            // 
            lblMapaches.AutoSize = true;
            lblMapaches.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMapaches.ForeColor = Color.White;
            lblMapaches.Location = new Point(19, 6);
            lblMapaches.Name = "lblMapaches";
            lblMapaches.Size = new Size(182, 38);
            lblMapaches.TabIndex = 0;
            lblMapaches.Text = "BARBERIA";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAgregarServicio);
            panel1.Location = new Point(230, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 98);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 162, 184);
            label2.Location = new Point(31, 65);
            label2.Name = "label2";
            label2.Size = new Size(359, 18);
            label2.TabIndex = 1;
            label2.Text = "Tus servicios de barbería para el público";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(220, 53, 69);
            label1.Location = new Point(25, 17);
            label1.Name = "label1";
            label1.Size = new Size(430, 42);
            label1.TabIndex = 0;
            label1.Text = "Servicios de barberia";
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarServicio.Location = new Point(460, 17);
            btnAgregarServicio.Margin = new Padding(2);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(100, 50);
            btnAgregarServicio.TabIndex = 2;
            btnAgregarServicio.Text = "Agregar Servicio";
            btnAgregarServicio.UseVisualStyleBackColor = true;
            btnAgregarServicio.Click += btnAgregarServicio_Click;
            // 
            // flpServicios
            // 
            flpServicios.AutoScroll = true;
            flpServicios.Location = new Point(0, 0);
            flpServicios.Margin = new Padding(2);
            flpServicios.Name = "flpServicios";
            flpServicios.Size = new Size(400, 250);
            flpServicios.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.mapacheBigoton;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelCalendario
            // 
            panelCalendario.Controls.Add(label3);
            panelCalendario.Location = new Point(0, 159);
            panelCalendario.Margin = new Padding(0);
            panelCalendario.Name = "panelCalendario";
            panelCalendario.Size = new Size(230, 50);
            panelCalendario.TabIndex = 1;
            panelCalendario.MouseClick += panelCalendario_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(49, 14);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 0;
            label3.Text = "Calendario";
            label3.MouseClick += label3_MouseClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 209);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 50);
            panel2.TabIndex = 2;
            panel2.Click += label4_Click;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(49, 14);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 0;
            label4.Text = "Servicios";
            label4.Click += label4_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 45, 50);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(pClientes);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(panelCalendario);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(0, 50);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 740);
            panelMenu.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Location = new Point(1, 259);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 50);
            panel4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(49, 16);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 0;
            label6.Text = "Barberos";
            // 
            // pClientes
            // 
            pClientes.Controls.Add(lClientes);
            pClientes.Location = new Point(1, 116);
            pClientes.Margin = new Padding(0);
            pClientes.Name = "pClientes";
            pClientes.Size = new Size(229, 43);
            pClientes.TabIndex = 3;
            // 
            // lClientes
            // 
            lClientes.AutoSize = true;
            lClientes.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lClientes.ForeColor = SystemColors.Window;
            lClientes.Location = new Point(48, 10);
            lClientes.Margin = new Padding(2, 0, 2, 0);
            lClientes.Name = "lClientes";
            lClientes.Size = new Size(86, 23);
            lClientes.TabIndex = 0;
            lClientes.Text = "Clientes";
            lClientes.Click += lClientes_Click;
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(834, 461);
            Controls.Add(panelServicios);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Name = "FrmServicios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicios";
            panelTop.ResumeLayout(false);
            panelServicios.ResumeLayout(false);
            panelIzquierda.ResumeLayout(false);
            panelIzquierda.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCalendario.ResumeLayout(false);
            panelCalendario.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelMenu.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pClientes.ResumeLayout(false);
            pClientes.PerformLayout();
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
        private Panel pClientes;
        private Label lClientes;
        private FlowLayoutPanel flpServicios;
        private Button btnAgregarServicio;
    }
}