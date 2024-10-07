namespace MapacheBigoton
{
    partial class FrmBarbero
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
            button1 = new Button();
            label1 = new Label();
            txtNombreB = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(900, 145);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 152);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Barbero:";
            // 
            // txtNombreB
            // 
            txtNombreB.Location = new Point(460, 149);
            txtNombreB.Name = "txtNombreB";
            txtNombreB.Size = new Size(391, 34);
            txtNombreB.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ButtonFace;
            flowLayoutPanel1.Location = new Point(204, 193);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(984, 544);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Location = new Point(160, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 58);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 749);
            panel2.TabIndex = 5;
            // 
            // panel5
            // 
            //panel5.BackgroundImage = Properties.Resources.mapacheBigoton;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(9, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(144, 64);
            panel5.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 395);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 12;
            label7.Text = "Barberos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 330);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 11;
            label6.Text = "Clientes";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 266);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 10;
            label5.Text = "Servicios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 192);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 7;
            label2.Text = "Calendario";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 57);
            panel3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(153, 38);
            label4.TabIndex = 9;
            label4.Text = "BARBERIA";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(204, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(984, 64);
            panel4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(9, 12);
            label3.Name = "label3";
            label3.Size = new Size(133, 38);
            label3.TabIndex = 8;
            label3.Text = "Barberos";
            // 
            // FrmBarbero
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1200, 749);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtNombreB);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FrmBarbero";
            Text = "FrmBarbero";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtNombreB;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel5;
    }
}