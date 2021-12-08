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
    public partial class Medicos : Form
    {
        Controlador controlador;
        public Medicos(Controlador controlador)
        {

            InitializeComponent();
            this.controlador = controlador;
            dgvMedicos.AutoGenerateColumns = false;
            cargarTabla();


        }

        /// <summary>
        /// Cargo las tablas correspondientes
        /// </summary>
        private void cargarTabla()
        {
            dgvMedicos.DataSource = controlador.listaMedicosDisponibles();
        }

        /// <summary>
        /// Luego de seleccionar una fila, delega informacipon al controlador para devolver datos y los muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            string apellidoYnombre = dgvMedicos.CurrentRow.Cells["apeYnom"].Value.ToString();
            Medico medico = controlador.devolverMedicoDisponiblePorApellidoYNombre(apellidoYnombre);
            List<Consulta> consultasEnEspera = controlador.devolverListaDeEsperaDeMedico(medico);
            List<Paciente> pacientesEnEspera = consultasEnEspera.Select(consulta => consulta.paciente).ToList();
            dgvPacientes.DataSource = pacientesEnEspera;


        }
    }
}
