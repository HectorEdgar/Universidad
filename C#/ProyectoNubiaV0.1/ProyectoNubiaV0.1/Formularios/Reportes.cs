using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoNubiaV0._1.Controladores;
namespace ProyectoNubiaV0._1.Formularios
{
    public partial class Reportes : Form
    {
        private ControlReportes control;
        public Reportes()
        {
            InitializeComponent();
            control = new ControlReportes();
        }

        private void Reportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing))
            {
                Application.Exit();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MenuPrincipal"].Visible = true;
            this.Dispose();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            control.GenerarReporteExcelGrupos((int)nupFaltasMaximas.Value,(int)nupNumFaltaAprobar.Value);
        }
    }
}
