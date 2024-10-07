namespace MapacheBigoton
{
    partial class FrmCitas
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnAgendarCita = new Button();
            dateTimePicker1 = new DateTimePicker();
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(246, 165);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1011, 478);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnAgendarCita);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(243, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 100);
            panel1.TabIndex = 19;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.BackColor = Color.Black;
            btnAgendarCita.ForeColor = SystemColors.ButtonFace;
            btnAgendarCita.Location = new Point(843, 23);
            btnAgendarCita.Margin = new Padding(3, 2, 3, 2);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(149, 48);
            btnAgendarCita.TabIndex = 3;
            btnAgendarCita.Text = "Agendar cita";
            btnAgendarCita.UseVisualStyleBackColor = false;
            btnAgendarCita.Click += btnAgendarCita_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(535, 37);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 162, 184);
            label2.Location = new Point(31, 65);
            label2.Name = "label2";
            label2.Size = new Size(155, 18);
            label2.TabIndex = 1;
            label2.Text = "Citas reservadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(220, 53, 69);
            label1.Location = new Point(25, 17);
            label1.Name = "label1";
            label1.Size = new Size(226, 42);
            label1.TabIndex = 0;
            label1.Text = "Calendario";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(252, 204, 124);
            panelTop.Controls.Add(panelIzquierda);
            panelTop.Location = new Point(12, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1245, 50);
            panelTop.TabIndex = 18;
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 45, 50);
            panelMenu.Controls.Add(panel5);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(panelCalendario);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(12, 60);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 585);
            panelMenu.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Location = new Point(0, 359);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 50);
            panel5.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(49, 14);
            label7.Name = "label7";
            label7.Size = new Size(95, 23);
            label7.TabIndex = 0;
            label7.Text = "Barberos";
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 309);
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
            label6.Location = new Point(49, 14);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 0;
            label6.Text = "Barberos";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 259);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 50);
            panel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(49, 14);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 0;
            label5.Text = "Clientes";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 209);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 50);
            panel2.TabIndex = 2;
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
            // 
            // panelCalendario
            // 
            panelCalendario.Controls.Add(label3);
            panelCalendario.Location = new Point(0, 159);
            panelCalendario.Margin = new Padding(0);
            panelCalendario.Name = "panelCalendario";
            panelCalendario.Size = new Size(230, 50);
            panelCalendario.TabIndex = 1;
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
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 657);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCitas";
            Text = "FrmCitas";
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

        private FlowLayoutPanel flowLayoutPanel1;
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
        private Button btnAgendarCita;
        private DateTimePicker dateTimePicker1;
    }
}