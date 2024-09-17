namespace MapacheBigoton
{
    partial class FrmAgregarServicio
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombreServicio = new TextBox();
            richDescripcionServicio = new RichTextBox();
            txtPrecioServicio = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 47);
            label1.Name = "label1";
            label1.Size = new Size(430, 23);
            label1.TabIndex = 0;
            label1.Text = "Agregar servicio que ofrece la barberia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 130);
            label2.Name = "label2";
            label2.Size = new Size(156, 16);
            label2.TabIndex = 1;
            label2.Text = "Nombre del servicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 167);
            label3.Name = "label3";
            label3.Size = new Size(183, 16);
            label3.TabIndex = 2;
            label3.Text = "Descripción del servicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 310);
            label4.Name = "label4";
            label4.Size = new Size(144, 16);
            label4.TabIndex = 3;
            label4.Text = "Precio del servicio:";
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.Location = new Point(192, 123);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(210, 23);
            txtNombreServicio.TabIndex = 4;
            // 
            // richDescripcionServicio
            // 
            richDescripcionServicio.Location = new Point(30, 189);
            richDescripcionServicio.Name = "richDescripcionServicio";
            richDescripcionServicio.Size = new Size(372, 96);
            richDescripcionServicio.TabIndex = 5;
            richDescripcionServicio.Text = "";
            // 
            // txtPrecioServicio
            // 
            txtPrecioServicio.Location = new Point(192, 303);
            txtPrecioServicio.Name = "txtPrecioServicio";
            txtPrecioServicio.Size = new Size(210, 23);
            txtPrecioServicio.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mapacheBigoton;
            pictureBox1.Location = new Point(12, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(295, 402);
            button1.Name = "button1";
            button1.Size = new Size(107, 47);
            button1.TabIndex = 8;
            button1.Text = "Agregar Servicio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmAgregarServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 45, 50);
            ClientSize = new Size(484, 461);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(txtPrecioServicio);
            Controls.Add(richDescripcionServicio);
            Controls.Add(txtNombreServicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAgregarServicio";
            Text = "FrmAgregarServicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreServicio;
        private RichTextBox richDescripcionServicio;
        private TextBox txtPrecioServicio;
        private PictureBox pictureBox1;
        private Button button1;
    }
}