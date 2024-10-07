namespace MapacheBigoton.Controls
{
    partial class SucursalControl
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
            bSeleccionarSuc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNomSuc = new TextBox();
            txtEdoSuc = new TextBox();
            txtMunSuc = new TextBox();
            txtCalleSuc = new TextBox();
            txtIdSuc = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // bSeleccionarSuc
            // 
            bSeleccionarSuc.Location = new Point(117, 166);
            bSeleccionarSuc.Name = "bSeleccionarSuc";
            bSeleccionarSuc.Size = new Size(75, 23);
            bSeleccionarSuc.TabIndex = 0;
            bSeleccionarSuc.Text = "Seleccionar";
            bSeleccionarSuc.UseVisualStyleBackColor = true;
            bSeleccionarSuc.Click += bSeleccionarSuc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 58);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre Sucursal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 87);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 116);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Municipio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 145);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Calle:";
            // 
            // txtNomSuc
            // 
            txtNomSuc.Enabled = false;
            txtNomSuc.Location = new Point(104, 50);
            txtNomSuc.Name = "txtNomSuc";
            txtNomSuc.Size = new Size(222, 23);
            txtNomSuc.TabIndex = 5;
            // 
            // txtEdoSuc
            // 
            txtEdoSuc.Enabled = false;
            txtEdoSuc.Location = new Point(104, 79);
            txtEdoSuc.Name = "txtEdoSuc";
            txtEdoSuc.Size = new Size(222, 23);
            txtEdoSuc.TabIndex = 6;
            // 
            // txtMunSuc
            // 
            txtMunSuc.Enabled = false;
            txtMunSuc.Location = new Point(104, 108);
            txtMunSuc.Name = "txtMunSuc";
            txtMunSuc.Size = new Size(222, 23);
            txtMunSuc.TabIndex = 7;
            // 
            // txtCalleSuc
            // 
            txtCalleSuc.Enabled = false;
            txtCalleSuc.Location = new Point(104, 137);
            txtCalleSuc.Name = "txtCalleSuc";
            txtCalleSuc.Size = new Size(222, 23);
            txtCalleSuc.TabIndex = 8;
            // 
            // txtIdSuc
            // 
            txtIdSuc.Enabled = false;
            txtIdSuc.Location = new Point(104, 21);
            txtIdSuc.Name = "txtIdSuc";
            txtIdSuc.Size = new Size(50, 23);
            txtIdSuc.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 29);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 9;
            label5.Text = "Id Sucursal:";
            // 
            // SucursalControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtIdSuc);
            Controls.Add(label5);
            Controls.Add(txtCalleSuc);
            Controls.Add(txtMunSuc);
            Controls.Add(txtEdoSuc);
            Controls.Add(txtNomSuc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bSeleccionarSuc);
            Name = "SucursalControl";
            Size = new Size(335, 199);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSeleccionarSuc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNomSuc;
        private TextBox txtEdoSuc;
        private TextBox txtMunSuc;
        private TextBox txtCalleSuc;
        private TextBox txtIdSuc;
        private Label label5;
    }
}
