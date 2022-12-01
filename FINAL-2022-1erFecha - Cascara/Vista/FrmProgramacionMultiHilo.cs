using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{

    // DESARROLLAR
    public partial class FrmProgramacionMultiHilo : Form
    {
        public Delegate delegado;
        CancellationTokenSource cts;
        List<Empleado> listaEmpleados;
        BackgroundWorker backgroundWorker;
        public FrmProgramacionMultiHilo()
        {
            InitializeComponent();

            cts = new CancellationTokenSource();
         
            listaEmpleados = new List<Empleado>();
            dtg_ListadoPuestosEncontrados.Enabled= true;
            dtg_ListadoPuestosEncontrados.Visible= true;
            backgroundWorker= new BackgroundWorker();
        }

        private void ComenzarCarga()
        {
            float sueldosDolarizados = 0;
            float sueldosPesificados = 0;
            float montoTotalAguinaldos = 0;

            while (true)
            {

                Empleado unEmpleado = GeneradorDeDatos.GetEmpleadoAleatorio;
                if (unEmpleado.GetType().ToString().Equals("BibliotecaDeClases.EmpleadoFreelance"))
                {
                    if(sueldosDolarizados + unEmpleado.CalcularCompensacion > 10000)
                    {
                        CancelarProceso();
                        break;
                    }
                    sueldosDolarizados += unEmpleado.CalcularCompensacion;
                }
                else
                {
                    var empleado = unEmpleado as EmpleadoRelacionDependencia;
                    if (sueldosPesificados + unEmpleado.CalcularCompensacion > 10000000)
                    {
                        CancelarProceso();
                        break;
                    }
                    sueldosPesificados += unEmpleado.CalcularCompensacion;
                    if (montoTotalAguinaldos + empleado.SueldoConAguinaldoActualizado > 20000000)
                    {
                        CancelarProceso();
                        break;
                    }
                    montoTotalAguinaldos += empleado.SueldoConAguinaldoActualizado;
                }
                listaEmpleados.Add(unEmpleado);
                if (this.InvokeRequired)
                {
                    this.dtg_ListadoPuestosEncontrados.BeginInvoke((MethodInvoker)delegate ()
                    {
                        dtg_ListadoPuestosEncontrados.DataSource = null;
                        dtg_ListadoPuestosEncontrados.DataSource = listaEmpleados;

                        lb_SueldoDolarizado.Text = "Sueldos Dolarizados a Liquidar mensualmente: " + sueldosDolarizados;
                        lb_MontoAguinaldo.Text = "Monto a liquidar en Aguinaldos: " + montoTotalAguinaldos;
                        lb_SueldoPesificado.Text = "Sueldos Pesificados a Liquidar mensualmente:  " + sueldosPesificados;
                    });
                }
                Thread.Sleep(2000);
            }
        }

        private void CancelarProceso()
        {
            cts.Cancel();
            MessageBox.Show($"Hasta aqui dan las finanzas: Se les pagará a {listaEmpleados.Count} empleados");
            btn_comenzarCarga.Enabled = false;
        }


        private void btn_comenzarCarga_Click(object sender, EventArgs e)
        {
            btn_comenzarCarga.Enabled = false;
            Task.Run(() => ComenzarCarga());
        }

        private void FrmProgramacionMultiHilo_Load(object sender, EventArgs e)
        {

        }
    }
}
