using BibliotecaDeClases;
using System;
using System.Windows.Forms;

namespace Vista
{

    // DESARROLLAR
    public partial class FrmEventos : Form
    {
        Empresa empresa;
        public FrmEventos()
        {
            InitializeComponent();
            empresa = new Empresa(GeneradorDeDatos.Rnd.Next(5, 16));
            empresa.BusquedasRealizadas += MostrarMensajeAgradecimiento;

        }

        private void btn_AgregarCarreras_Click(object sender, EventArgs e)
        {
            lbox_listado.DataSource = null;
            lbox_listado.DataSource = empresa.AbrirBusqueda();
        }

        private void MostrarMensajeAgradecimiento(bool cupoCompleto)
        {
            if (cupoCompleto)
            {
                MessageBox.Show("Todas las postulaciones han sido realizadas con exito. Agradecemos su participacion.\n Los esperamos la proxima");
                this.lbox_listado.Enabled = !cupoCompleto;
                DesactivarComponentesFormularios(cupoCompleto);
            }
        }

        private void DesactivarComponentesFormularios(bool estado)
        {
            this.btn_AgregarCursos.Enabled = !estado;
        }
    }
}
