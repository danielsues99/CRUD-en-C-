namespace Vista
{
    partial class Registrar
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNregistrar = new System.Windows.Forms.Button();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textapellido = new System.Windows.Forms.TextBox();
            this.textdocumento = new System.Windows.Forms.TextBox();
            this.textnacimiento = new System.Windows.Forms.TextBox();
            this.BTNmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha_nacimiento";
            // 
            // BTNregistrar
            // 
            this.BTNregistrar.Location = new System.Drawing.Point(38, 205);
            this.BTNregistrar.Name = "BTNregistrar";
            this.BTNregistrar.Size = new System.Drawing.Size(75, 23);
            this.BTNregistrar.TabIndex = 4;
            this.BTNregistrar.Text = "Registrar";
            this.BTNregistrar.UseVisualStyleBackColor = true;
            this.BTNregistrar.Click += new System.EventHandler(this.BTNregistrar_Click);
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(154, 38);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(100, 20);
            this.textnombre.TabIndex = 5;
            // 
            // textapellido
            // 
            this.textapellido.Location = new System.Drawing.Point(154, 84);
            this.textapellido.Name = "textapellido";
            this.textapellido.Size = new System.Drawing.Size(100, 20);
            this.textapellido.TabIndex = 6;
            // 
            // textdocumento
            // 
            this.textdocumento.Location = new System.Drawing.Point(154, 127);
            this.textdocumento.Name = "textdocumento";
            this.textdocumento.Size = new System.Drawing.Size(100, 20);
            this.textdocumento.TabIndex = 7;
            // 
            // textnacimiento
            // 
            this.textnacimiento.Location = new System.Drawing.Point(154, 172);
            this.textnacimiento.Name = "textnacimiento";
            this.textnacimiento.Size = new System.Drawing.Size(100, 20);
            this.textnacimiento.TabIndex = 8;
            // 
            // BTNmenu
            // 
            this.BTNmenu.Location = new System.Drawing.Point(38, 235);
            this.BTNmenu.Name = "BTNmenu";
            this.BTNmenu.Size = new System.Drawing.Size(75, 23);
            this.BTNmenu.TabIndex = 9;
            this.BTNmenu.Text = "Menu";
            this.BTNmenu.UseVisualStyleBackColor = true;
            this.BTNmenu.Click += new System.EventHandler(this.BTNmenu_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTNmenu);
            this.Controls.Add(this.textnacimiento);
            this.Controls.Add(this.textdocumento);
            this.Controls.Add(this.textapellido);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.BTNregistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registrar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNregistrar;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textapellido;
        private System.Windows.Forms.TextBox textdocumento;
        private System.Windows.Forms.TextBox textnacimiento;
        private System.Windows.Forms.Button BTNmenu;
    }
}

