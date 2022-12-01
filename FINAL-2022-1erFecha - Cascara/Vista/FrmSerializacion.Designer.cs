namespace Vista
{
    partial class FrmSerializacion
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
            this.btn_deserializar = new System.Windows.Forms.Button();
            this.lb_mensaje = new System.Windows.Forms.Label();
            this.lb_seccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_deserializar
            // 
            this.btn_deserializar.Location = new System.Drawing.Point(155, 80);
            this.btn_deserializar.Name = "btn_deserializar";
            this.btn_deserializar.Size = new System.Drawing.Size(229, 41);
            this.btn_deserializar.TabIndex = 1;
            this.btn_deserializar.Text = "Serializar Empleado";
            this.btn_deserializar.UseVisualStyleBackColor = true;
            this.btn_deserializar.Click += new System.EventHandler(this.btn_deserializar_Click);
            // 
            // lb_mensaje
            // 
            this.lb_mensaje.AutoSize = true;
            this.lb_mensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_mensaje.Location = new System.Drawing.Point(12, 140);
            this.lb_mensaje.Name = "lb_mensaje";
            this.lb_mensaje.Size = new System.Drawing.Size(72, 17);
            this.lb_mensaje.TabIndex = 2;
            this.lb_mensaje.Text = "lb_mensaje";
            this.lb_mensaje.Visible = false;
            // 
            // lb_seccion
            // 
            this.lb_seccion.AutoSize = true;
            this.lb_seccion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_seccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_seccion.Location = new System.Drawing.Point(145, 9);
            this.lb_seccion.Name = "lb_seccion";
            this.lb_seccion.Size = new System.Drawing.Size(251, 37);
            this.lb_seccion.TabIndex = 4;
            this.lb_seccion.Text = "Serializar Empleado";
            // 
            // FrmSerializacionDeserializacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 184);
            this.Controls.Add(this.lb_seccion);
            this.Controls.Add(this.lb_mensaje);
            this.Controls.Add(this.btn_deserializar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmSerializacionDeserializacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serializacion, Generics y Delegados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_deserializar;
        private System.Windows.Forms.Label lb_mensaje;
        private System.Windows.Forms.Label lb_seccion;
    }
}