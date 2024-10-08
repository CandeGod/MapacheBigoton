﻿namespace MapacheBigoton
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
            panelServicios = new Panel();
            bBuscarClient = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelTop = new Panel();
            panelIzquierda = new Panel();
            lblMapaches = new Label();
            panelMenu = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panelCalendario = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinu).BeginInit();
            panelServicios.SuspendLayout();
            panel1.SuspendLayout();
            panelTop.SuspendLayout();
            panelIzquierda.SuspendLayout();
            panelMenu.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panelCalendario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbBarberos
            // 
            cbBarberos.FormattingEnabled = true;
            cbBarberos.Location = new Point(147, 243);
            cbBarberos.Margin = new Padding(3, 4, 3, 4);
            cbBarberos.Name = "cbBarberos";
            cbBarberos.Size = new Size(267, 28);
            cbBarberos.TabIndex = 1;
            // 
            // cbServicios
            // 
            cbServicios.FormattingEnabled = true;
            cbServicios.Location = new Point(147, 320);
            cbServicios.Margin = new Padding(3, 4, 3, 4);
            cbServicios.Name = "cbServicios";
            cbServicios.Size = new Size(267, 28);
            cbServicios.TabIndex = 2;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(147, 101);
            dtFecha.Margin = new Padding(3, 4, 3, 4);
            dtFecha.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(267, 27);
            dtFecha.TabIndex = 5;
            dtFecha.Value = new DateTime(2024, 9, 16, 0, 0, 0, 0);
            // 
            // bAgendar
            // 
            bAgendar.Location = new Point(195, 371);
            bAgendar.Margin = new Padding(3, 4, 3, 4);
            bAgendar.Name = "bAgendar";
            bAgendar.Size = new Size(86, 31);
            bAgendar.TabIndex = 6;
            bAgendar.Text = "Agendar";
            bAgendar.UseVisualStyleBackColor = true;
            bAgendar.Click += bAgendar_Click;
            // 
            // numHora
            // 
            numHora.Location = new Point(147, 29);
            numHora.Margin = new Padding(3, 4, 3, 4);
            numHora.Maximum = new decimal(new int[] { 17, 0, 0, 0 });
            numHora.Minimum = new decimal(new int[] { 9, 0, 0, 0 });
            numHora.Name = "numHora";
            numHora.Size = new Size(41, 27);
            numHora.TabIndex = 7;
            numHora.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // numMinu
            // 
            numMinu.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            numMinu.Location = new Point(195, 29);
            numMinu.Margin = new Padding(3, 4, 3, 4);
            numMinu.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            numMinu.Name = "numMinu";
            numMinu.Size = new Size(41, 27);
            numMinu.TabIndex = 8;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(147, 172);
            cbClientes.Margin = new Padding(3, 4, 3, 4);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(267, 28);
            cbClientes.TabIndex = 9;
            // 
            // panelServicios
            // 
            panelServicios.BackColor = Color.White;
            panelServicios.Controls.Add(bBuscarClient);
            panelServicios.Controls.Add(label12);
            panelServicios.Controls.Add(label11);
            panelServicios.Controls.Add(label10);
            panelServicios.Controls.Add(label9);
            panelServicios.Controls.Add(label8);
            panelServicios.Controls.Add(bAgendar);
            panelServicios.Controls.Add(cbBarberos);
            panelServicios.Controls.Add(cbServicios);
            panelServicios.Controls.Add(dtFecha);
            panelServicios.Controls.Add(cbClientes);
            panelServicios.Controls.Add(numHora);
            panelServicios.Controls.Add(numMinu);
            panelServicios.Location = new Point(289, 223);
            panelServicios.Margin = new Padding(3, 4, 3, 4);
            panelServicios.Name = "panelServicios";
            panelServicios.Size = new Size(1143, 840);
            panelServicios.TabIndex = 17;
            // 
            // bBuscarClient
            // 
            bBuscarClient.Location = new Point(433, 172);
            bBuscarClient.Margin = new Padding(3, 4, 3, 4);
            bBuscarClient.Name = "bBuscarClient";
            bBuscarClient.Size = new Size(105, 31);
            bBuscarClient.TabIndex = 15;
            bBuscarClient.Text = "Buscar Cliente";
            bBuscarClient.UseVisualStyleBackColor = true;
            bBuscarClient.Click += bBuscarClient_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 323);
            label12.Name = "label12";
            label12.Size = new Size(120, 27);
            label12.TabIndex = 14;
            label12.Text = "Servicio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 243);
            label11.Name = "label11";
            label11.Size = new Size(118, 27);
            label11.TabIndex = 13;
            label11.Text = "Barbero:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 169);
            label10.Name = "label10";
            label10.Size = new Size(107, 27);
            label10.TabIndex = 12;
            label10.Text = "Cliente:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 109);
            label9.Name = "label9";
            label9.Size = new Size(91, 27);
            label9.TabIndex = 11;
            label9.Text = "Fecha:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 37);
            label8.Name = "label8";
            label8.Size = new Size(79, 27);
            label8.TabIndex = 10;
            label8.Text = "Hora:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(273, 80);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 132);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 162, 184);
            label2.Location = new Point(35, 87);
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
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(544, 53);
            label1.TabIndex = 0;
            label1.Text = "Servicios de barberia";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(252, 204, 124);
            panelTop.Controls.Add(panelIzquierda);
            panelTop.Location = new Point(10, 13);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1445, 67);
            panelTop.TabIndex = 15;
            // 
            // panelIzquierda
            // 
            panelIzquierda.BackColor = Color.FromArgb(228, 136, 21);
            panelIzquierda.Controls.Add(lblMapaches);
            panelIzquierda.Location = new Point(0, 0);
            panelIzquierda.Margin = new Padding(3, 4, 3, 4);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(263, 67);
            panelIzquierda.TabIndex = 0;
            // 
            // lblMapaches
            // 
            lblMapaches.AutoSize = true;
            lblMapaches.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMapaches.ForeColor = Color.White;
            lblMapaches.Location = new Point(22, 8);
            lblMapaches.Name = "lblMapaches";
            lblMapaches.Size = new Size(225, 48);
            lblMapaches.TabIndex = 0;
            lblMapaches.Text = "BARBERIA";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 45, 50);
            panelMenu.Controls.Add(panel5);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(panelCalendario);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(10, 80);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(263, 987);
            panelMenu.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Location = new Point(0, 479);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 67);
            panel5.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(56, 19);
            label7.Name = "label7";
            label7.Size = new Size(120, 29);
            label7.TabIndex = 0;
            label7.Text = "Barberos";
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 412);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 67);
            panel4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(56, 19);
            label6.Name = "label6";
            label6.Size = new Size(120, 29);
            label6.TabIndex = 0;
            label6.Text = "Barberos";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 345);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 67);
            panel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(56, 19);
            label5.Name = "label5";
            label5.Size = new Size(107, 29);
            label5.TabIndex = 0;
            label5.Text = "Clientes";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 279);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 67);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(56, 19);
            label4.Name = "label4";
            label4.Size = new Size(120, 29);
            label4.TabIndex = 0;
            label4.Text = "Servicios";
            // 
            // panelCalendario
            // 
            panelCalendario.Controls.Add(label3);
            panelCalendario.Location = new Point(0, 212);
            panelCalendario.Margin = new Padding(0);
            panelCalendario.Name = "panelCalendario";
            panelCalendario.Size = new Size(263, 67);
            panelCalendario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(56, 19);
            label3.Name = "label3";
            label3.Size = new Size(139, 29);
            label3.TabIndex = 0;
            label3.Text = "Calendario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmAgendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 1055);
            Controls.Add(panelServicios);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAgendar";
            Text = "frmAgendar";
            Load += frmAgendar_Load;
            ((System.ComponentModel.ISupportInitialize)numHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinu).EndInit();
            panelServicios.ResumeLayout(false);
            panelServicios.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTop.ResumeLayout(false);
            panelIzquierda.ResumeLayout(false);
            panelIzquierda.PerformLayout();
            panelMenu.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelCalendario.ResumeLayout(false);
            panelCalendario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panelServicios;
        private Label label8;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panelTop;
        private Panel panelIzquierda;
        private Label lblMapaches;
        private Panel panelMenu;
        private Panel panel5;
        private Label label7;
        private Panel panel4;
        private Label label6;
        private Panel panel3;
        private Label label5;
        private Panel panel2;
        private Label label4;
        private Panel panelCalendario;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button bBuscarClient;
    }
}