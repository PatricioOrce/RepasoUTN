using BibliotecaDeClases;
using System;
using System.Windows.Forms;

namespace Vista
{


    public partial class FrmBaseDeDatos : Form
    {
        SqlManejador manejador;
        public FrmBaseDeDatos()
        {
            InitializeComponent();
            manejador = new SqlManejador();
        }


        // DESARROLLAR
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dni = decimal.Parse(tb_dni.Text);
                string nombre = tb_nombre.Text;
                string puesto = tb_puestoACubrir.Text;
                var empleado = new EmpleadoFreelance(dni, nombre, puesto, true);
                manejador.Insertar(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmBaseDeDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
