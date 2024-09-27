namespace MapacheBigoton.Controls
{
    partial class UserControlServicio
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
            lblServicio = new Label();
            lblPrecio = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richDescripcionServicio = new RichTextBox();
            SuspendLayout();
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServicio.Location = new Point(23, 35);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(113, 14);
            lblServicio.TabIndex = 0;
            lblServicio.Text = "Nombre Servicio:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(207, 152);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(54, 14);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(122, 14);
            label1.TabIndex = 3;
            label1.Text = "Nombre Servicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 152);
            label2.Name = "label2";
            label2.Size = new Size(54, 14);
            label2.TabIndex = 4;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 61);
            label3.Name = "label3";
            label3.Size = new Size(147, 14);
            label3.TabIndex = 5;
            label3.Text = "Descripción Servicio:";
            // 
            // richDescripcionServicio
            // 
            richDescripcionServicio.BorderStyle = BorderStyle.FixedSingle;
            richDescripcionServicio.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richDescripcionServicio.Location = new Point(23, 92);
            richDescripcionServicio.Name = "richDescripcionServicio";
            richDescripcionServicio.ReadOnly = true;
            richDescripcionServicio.ScrollBars = RichTextBoxScrollBars.Vertical;
            richDescripcionServicio.Size = new Size(238, 50);
            richDescripcionServicio.TabIndex = 6;
            richDescripcionServicio.TabStop = false;
            richDescripcionServicio.Text = "";
            // 
            // UserControlServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(richDescripcionServicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPrecio);
            Controls.Add(lblServicio);
            Name = "UserControlServicio";
            Size = new Size(280, 174);
            Paint += UserControlServicio_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServicio;
        private Label lblPrecio;
        private Label label1;
        private Label label2;
        private Label label3;
        public RichTextBox richDescripcionServicio;
    }
}
