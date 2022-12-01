namespace Vista
{
    partial class FrmProgramacionMultiHilo
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
            this.dtg_ListadoPuestosEncontrados = new System.Windows.Forms.DataGridView();
            this.btn_comenzarCarga = new System.Windows.Forms.Button();
            this.lb_seccion = new System.Windows.Forms.Label();
            this.lb_SueldoDolarizado = new System.Windows.Forms.Label();
            this.lb_SueldoPesificado = new System.Windows.Forms.Label();
            this.lb_MontoAguinaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListadoPuestosEncontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_ListadoPuestosEncontrados
            // 
            this.dtg_ListadoPuestosEncontrados.AllowUserToAddRows = false;
            this.dtg_ListadoPuestosEncontrados.AllowUserToDeleteRows = false;
            this.dtg_ListadoPuestosEncontrados.AllowUserToResizeColumns = false;
            this.dtg_ListadoPuestosEncontrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ListadoPuestosEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ListadoPuestosEncontrados.Location = new System.Drawing.Point(12, 84);
            this.dtg_ListadoPuestosEncontrados.Name = "dtg_ListadoPuestosEncontrados";
            this.dtg_ListadoPuestosEncontrados.RowHeadersVisible = false;
            this.dtg_ListadoPuestosEncontrados.RowTemplate.Height = 25;
            this.dtg_ListadoPuestosEncontrados.Size = new System.Drawing.Size(653, 146);
            this.dtg_ListadoPuestosEncontrados.TabIndex = 2;
            // 
            // btn_comenzarCarga
            // 
            this.btn_comenzarCarga.Location = new System.Drawing.Point(190, 254);
            this.btn_comenzarCarga.Name = "btn_comenzarCarga";
            this.btn_comenzarCarga.Size = new System.Drawing.Size(274, 63);
            this.btn_comenzarCarga.TabIndex = 3;
            this.btn_comenzarCarga.Text = "Comenzar Liquidacion Sueldos";
            this.btn_comenzarCarga.UseVisualStyleBackColor = true;
            this.btn_comenzarCarga.Click += new System.EventHandler(this.btn_comenzarCarga_Click);
            // 
            // lb_seccion
            // 
            this.lb_seccion.AutoSize = true;
            this.lb_seccion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_seccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_seccion.Location = new System.Drawing.Point(138, 26);
            this.lb_seccion.Name = "lb_seccion";
            this.lb_seccion.Size = new System.Drawing.Size(394, 37);
            this.lb_seccion.TabIndex = 5;
            this.lb_seccion.Text = "Modulo Liquidacion Empleados";
            // 
            // lb_SueldoDolarizado
            // 
            this.lb_SueldoDolarizado.AutoSize = true;
            this.lb_SueldoDolarizado.Location = new System.Drawing.Point(20, 350);
            this.lb_SueldoDolarizado.Name = "lb_SueldoDolarizado";
            this.lb_SueldoDolarizado.Size = new System.Drawing.Size(124, 15);
            this.lb_SueldoDolarizado.TabIndex = 6;
            this.lb_SueldoDolarizado.Text = "A liquidar en dolares:  ";
            // 
            // lb_SueldoPesificado
            // 
            this.lb_SueldoPesificado.AutoSize = true;
            this.lb_SueldoPesificado.Location = new System.Drawing.Point(20, 395);
            this.lb_SueldoPesificado.Name = "lb_SueldoPesificado";
            this.lb_SueldoPesificado.Size = new System.Drawing.Size(107, 15);
            this.lb_SueldoPesificado.TabIndex = 7;
            this.lb_SueldoPesificado.Text = "A liquidar en pesos";
            // 
            // lb_MontoAguinaldo
            // 
            this.lb_MontoAguinaldo.AutoSize = true;
            this.lb_MontoAguinaldo.Location = new System.Drawing.Point(20, 440);
            this.lb_MontoAguinaldo.Name = "lb_MontoAguinaldo";
            this.lb_MontoAguinaldo.Size = new System.Drawing.Size(175, 15);
            this.lb_MontoAguinaldo.TabIndex = 8;
            this.lb_MontoAguinaldo.Text = "Monto de aguinaldos a liquidar:";
            // 
            // FrmProgramacionMultiHilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 464);
            this.Controls.Add(this.lb_MontoAguinaldo);
            this.Controls.Add(this.lb_SueldoPesificado);
            this.Controls.Add(this.lb_SueldoDolarizado);
            this.Controls.Add(this.lb_seccion);
            this.Controls.Add(this.btn_comenzarCarga);
            this.Controls.Add(this.dtg_ListadoPuestosEncontrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProgramacionMultiHilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programación multihilos ( Task )";
            this.Load += new System.EventHandler(this.FrmProgramacionMultiHilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListadoPuestosEncontrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_ListadoPuestosEncontrados;
        private System.Windows.Forms.Button btn_comenzarCarga;
        private System.Windows.Forms.Label lb_seccion;
        private System.Windows.Forms.Label lb_SueldoDolarizado;
        private System.Windows.Forms.Label lb_SueldoPesificado;
        private System.Windows.Forms.Label lb_MontoAguinaldo;
    }
}