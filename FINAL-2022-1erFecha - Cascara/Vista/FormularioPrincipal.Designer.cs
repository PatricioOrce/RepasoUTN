namespace Vista
{
    partial class FormularioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SerializacionDeserializacion = new System.Windows.Forms.Button();
            this.btn_BaseDeDatos = new System.Windows.Forms.Button();
            this.btn_multiHilo = new System.Windows.Forms.Button();
            this.btn_eventos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SerializacionDeserializacion
            // 
            this.btn_SerializacionDeserializacion.Location = new System.Drawing.Point(55, 259);
            this.btn_SerializacionDeserializacion.Name = "btn_SerializacionDeserializacion";
            this.btn_SerializacionDeserializacion.Size = new System.Drawing.Size(179, 78);
            this.btn_SerializacionDeserializacion.TabIndex = 0;
            this.btn_SerializacionDeserializacion.Text = "Serialización,\r\nGenerics\r\ny\r\nDelegados\r\n";
            this.btn_SerializacionDeserializacion.UseVisualStyleBackColor = true;
            this.btn_SerializacionDeserializacion.Click += new System.EventHandler(this.btn_SerializacionDeserializacion_Click);
            // 
            // btn_BaseDeDatos
            // 
            this.btn_BaseDeDatos.Location = new System.Drawing.Point(55, 65);
            this.btn_BaseDeDatos.Name = "btn_BaseDeDatos";
            this.btn_BaseDeDatos.Size = new System.Drawing.Size(179, 78);
            this.btn_BaseDeDatos.TabIndex = 1;
            this.btn_BaseDeDatos.Text = "Base de Datos \r\ne\r\nInterfaces";
            this.btn_BaseDeDatos.UseVisualStyleBackColor = true;
            this.btn_BaseDeDatos.Click += new System.EventHandler(this.btn_BaseDeDatos_Click);
            // 
            // btn_multiHilo
            // 
            this.btn_multiHilo.Location = new System.Drawing.Point(55, 162);
            this.btn_multiHilo.Name = "btn_multiHilo";
            this.btn_multiHilo.Size = new System.Drawing.Size(179, 78);
            this.btn_multiHilo.TabIndex = 2;
            this.btn_multiHilo.Text = "Programacion multi hilo (task)";
            this.btn_multiHilo.UseVisualStyleBackColor = true;
            this.btn_multiHilo.Click += new System.EventHandler(this.btn_multiHilo_Click);
            // 
            // btn_eventos
            // 
            this.btn_eventos.Location = new System.Drawing.Point(55, 354);
            this.btn_eventos.Name = "btn_eventos";
            this.btn_eventos.Size = new System.Drawing.Size(179, 78);
            this.btn_eventos.TabIndex = 3;
            this.btn_eventos.Text = "Eventos";
            this.btn_eventos.UseVisualStyleBackColor = true;
            this.btn_eventos.Click += new System.EventHandler(this.btn_eventos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "RSP 2022";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eventos);
            this.Controls.Add(this.btn_multiHilo);
            this.Controls.Add(this.btn_BaseDeDatos);
            this.Controls.Add(this.btn_SerializacionDeserializacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orce.Patricio";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SerializacionDeserializacion;
        private System.Windows.Forms.Button btn_BaseDeDatos;
        private System.Windows.Forms.Button btn_multiHilo;
        private System.Windows.Forms.Button btn_eventos;
        private System.Windows.Forms.Label label1;
    }
}
