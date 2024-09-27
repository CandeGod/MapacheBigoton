namespace MapacheBigoton
{
    partial class FrmClientes
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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCliente = new TextBox();
            txtTelefono = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 192, 128);
            pictureBox1.Location = new Point(114, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 27);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 128, 0);
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 27);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Location = new Point(1, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 366);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.mapacheBigoton;
            pictureBox4.Location = new Point(1, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 124);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Servicios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 93);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 6;
            label1.Text = "Calendario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 181);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 9;
            label3.Text = "Barbero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 154);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Clientes";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonFace;
            pictureBox5.Location = new Point(114, 27);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(512, 56);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(121, 44);
            label5.Name = "label5";
            label5.Size = new Size(95, 30);
            label5.TabIndex = 11;
            label5.Text = "Clientes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 93);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 12;
            label6.Text = "Nombre del Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 97);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 13;
            label7.Text = "Telefono:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(240, 89);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(130, 23);
            txtCliente.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(472, 93);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(343, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(220, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(317, 227);
            dataGridView1.TabIndex = 17;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 393);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtTelefono);
            Controls.Add(txtCliente);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCliente;
        private TextBox txtTelefono;
        private Button button1;
        private DataGridView dataGridView1;
    }
}