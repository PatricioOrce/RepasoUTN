namespace Vista
{
    partial class FrmBaseDeDatos
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
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lb_dni = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.lb_seccion = new System.Windows.Forms.Label();
            this.tb_puestoACubrir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(217, 126);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(192, 23);
            this.tb_nombre.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(93, 228);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(316, 42);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lb_dni
            // 
            this.lb_dni.AutoSize = true;
            this.lb_dni.Location = new System.Drawing.Point(76, 83);
            this.lb_dni.Name = "lb_dni";
            this.lb_dni.Size = new System.Drawing.Size(25, 15);
            this.lb_dni.TabIndex = 5;
            this.lb_dni.Text = "Dni";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(76, 129);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(105, 15);
            this.lb_nombre.TabIndex = 6;
            this.lb_nombre.Text = "Nombre completo";
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(217, 80);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(192, 23);
            this.tb_dni.TabIndex = 0;
            // 
            // lb_seccion
            // 
            this.lb_seccion.AutoSize = true;
            this.lb_seccion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_seccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_seccion.Location = new System.Drawing.Point(144, 9);
            this.lb_seccion.Name = "lb_seccion";
            this.lb_seccion.Size = new System.Drawing.Size(214, 37);
            this.lb_seccion.TabIndex = 9;
            this.lb_seccion.Text = "Carga Empleado";
            // 
            // tb_puestoACubrir
            // 
            this.tb_puestoACubrir.Location = new System.Drawing.Point(217, 172);
            this.tb_puestoACubrir.Name = "tb_puestoACubrir";
            this.tb_puestoACubrir.Size = new System.Drawing.Size(192, 23);
            this.tb_puestoACubrir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puesto a cubrir";
            // 
            // FrmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 289);
            this.Controls.Add(this.tb_puestoACubrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_seccion);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.lb_dni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos e Interfaces";
            this.Load += new System.EventHandler(this.FrmBaseDeDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lb_dni;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.Label lb_seccion;
        private System.Windows.Forms.TextBox tb_puestoACubrir;
        private System.Windows.Forms.Label label1;
    }
}