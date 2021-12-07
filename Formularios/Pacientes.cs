using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; 

namespace Formularios
{
    public partial class Pacientes : Form
    {
        private Controlador controlador;

        public Pacientes(Controlador controlador)
        {
            InitializeComponent();
            dgvPacientes.AutoGenerateColumns = false;
            this.controlador = controlador;
            cargarTabla();
        }

        private void cargarTabla()
        {
            dgvPacientes.DataSource = controlador.listaPacientesEnEspera();
        }

        public void actualizarTabla()
        {

            //dgvPacientes.Rows.Clear();
            cargarTabla();
        }

    }
}
