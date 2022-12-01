using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{

    public partial class FrmSerializacion : Form
    {

        public FrmSerializacion()
        {
            InitializeComponent();
        }


        //no cambiar
        private void ActualizarComponentesFormulario(string texto)
        {
            lb_mensaje.Text = texto;
            lb_mensaje.Visible = true;
            btn_deserializar.Enabled = false;
        }

        private void btn_deserializar_Click(object sender, EventArgs e)
        {
            string rutaFile = string.Empty;
            Empleado empleado = GeneradorDeDatos.GetEmpleadoAleatorio;

            rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RSP_2022\\";
            Serializador<Empleado>.Escribir(empleado, rutaFile, "PruebaTusabe.json", (e) =>
            {
                this.btn_deserializar.Enabled = false;
                lb_mensaje.Text = e;
            });

        }

    }
}
