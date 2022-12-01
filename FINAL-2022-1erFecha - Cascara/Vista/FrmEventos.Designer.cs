namespace Vista
{
    partial class FrmEventos
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
            this.btn_AgregarCursos = new System.Windows.Forms.Button();
            this.lbox_listado = new System.Windows.Forms.ListBox();
            this.lb_seccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AgregarCursos
            // 
            this.btn_AgregarCursos.Location = new System.Drawing.Point(143, 247);
            this.btn_AgregarCursos.Name = "btn_AgregarCursos";
            this.btn_AgregarCursos.Size = new System.Drawing.Size(199, 48);
            this.btn_AgregarCursos.TabIndex = 0;
            this.btn_AgregarCursos.Text = "Publicar Puesto Trabajo";
            this.btn_AgregarCursos.UseVisualStyleBackColor = true;
            this.btn_AgregarCursos.Click += new System.EventHandler(this.btn_AgregarCarreras_Click);
            // 
            // lbox_listado
            // 
            this.lbox_listado.FormattingEnabled = true;
            this.lbox_listado.ItemHeight = 15;
            this.lbox_listado.Location = new System.Drawing.Point(48, 86);
            this.lbox_listado.Name = "lbox_listado";
            this.lbox_listado.Size = new System.Drawing.Size(403, 139);
            this.lbox_listado.TabIndex = 1;
            // 
            // lb_seccion
            // 
            this.lb_seccion.AutoSize = true;
            this.lb_seccion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_seccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_seccion.Location = new System.Drawing.Point(76, 9);
            this.lb_seccion.Name = "lb_seccion";
            this.lb_seccion.Size = new System.Drawing.Size(344, 37);
            this.lb_seccion.TabIndex = 5;
            this.lb_seccion.Text = "Generar posiciones abiertas";
            // 
            // FrmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 316);
            this.Controls.Add(this.lb_seccion);
            this.Controls.Add(this.lbox_listado);
            this.Controls.Add(this.btn_AgregarCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarCursos;
        private System.Windows.Forms.ListBox lbox_listado;
        private System.Windows.Forms.Label lb_seccion;
    }
}