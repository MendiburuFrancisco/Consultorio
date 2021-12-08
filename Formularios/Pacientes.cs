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
            dgvMedicosDisponibles.AutoGenerateColumns = false;
            dgvEspecialidesDisponibles.AutoGenerateColumns = false;
            this.controlador = controlador;
            cargarTabla();
            esconderInformacionNoSeleccionada();
        }

        /// <summary>
        /// Cargo las tablas correspondientes
        /// </summary>
        private void cargarTabla()
        {
            dgvPacientes.DataSource = controlador.listaPacientesEnEspera();
            dgvEspecialidesDisponibles.DataSource = controlador.listaEspecialidadesDisponibles().Select(x => new { especialidad = x }).ToList();
            dgvMedicosDisponibles.DataSource = controlador.listaMedicosDisponibles();

        }

        /// <summary>
        /// Limpio y actualizo las tablas correspondientes 
        /// </summary>
        public void actualizarTabla()
        {

           
            cargarTabla();
        }

        /// <summary>
        /// Al momento de hacer click en el boton o al ingresar al pantalla esconde informacion para evitar errores
        /// </summary>
        private void esconderInformacionNoSeleccionada()
        {

            lblSelecciono.Visible = true;

            lblTituloDniPaciente.Visible = false;
            lblDniPaciente.Visible = false;

            lblTituloPaciente.Visible = false;
            lblPaciente.Visible = false;

            lblTituloMedico.Visible = false;
            lblMedico.Visible = false;


            lblTituloObraSocial.Visible = false;
            lblObraSocial.Visible = false;

            lblTituloFechaYHora.Visible = false;
            lblFechaYHora.Visible = false;

            btnAsignarMedico.Visible = false;


        }


        /// <summary>
        /// Luego de seleccionar una fila, carga los datos de la misma sobre labels y la muestra 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarInformacionSeleccionada()
        {


            lblSelecciono.Visible = false;

            lblTituloDniPaciente.Visible = true;
            lblDniPaciente.Visible = true;

            lblTituloPaciente.Visible = true;
            lblPaciente.Visible = true;

            lblTituloMedico.Visible = true;
            lblMedico.Visible = true;
          
  
            lblTituloObraSocial.Visible = true;  
            lblObraSocial.Visible = true;

            lblTituloFechaYHora.Visible = true;
            lblFechaYHora.Visible = true;

            btnAsignarMedico.Visible = true;
 
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPacientes.SelectedRows != null)
            {

                Consulta consultaActual = controlador.devolverConsultaSegunPaciente(
                   (string)dgvPacientes.CurrentRow.Cells["dni"].Value
                    );

                lblMedico.Text = "Seleccione un medico"; //((string)dgvPacientes.CurrentRow.Cells["apellidoYnombre"].Value);
                lblPaciente.Text = consultaActual.paciente.apellidoYnombre; //((string)dgvPacientes.CurrentRow.Cells["apellidoYnombre"].Value);
                lblDniPaciente.Text = consultaActual.paciente.dni; ///((string)dgvPacientes.CurrentRow.Cells["dni"].Value);
                lblObraSocial.Text = consultaActual.paciente.obraSocial; //((DateTime)dgvPacientes.CurrentRow.Cells["fecha_hora"].Value).ToString();
                lblFechaYHora.Text = consultaActual.fecha_hora.ToString();
                mostrarInformacionSeleccionada();

            }
        }

        /// <summary>
        /// Luego de seleccionar una fila de una especialidad, carga el medico de la especialidad
        /// en los labels correspondientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEspecialidesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEspecialidesDisponibles.SelectedRows != null)
            {
                string especialidad = dgvEspecialidesDisponibles.CurrentRow.Cells["especialidad"].Value.ToString();
                Medico medico = controlador.devolverMedicoDisponiblePorEspecialidad(especialidad);

                if (medico != null)
                {
                    lblMedicoSeleccionado.Text = medico.apellidoYnombre;
                    lblMedico.Text = medico.apellidoYnombre;
                }


            }

        }

        /// <summary>
        /// Luego de seleccionar una fila de medicos disponibles, carga informacion del medico
        /// en los labels correspondientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMedicosDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMedicosDisponibles.SelectedRows != null)
            {
                string apellidoYnombre = dgvMedicosDisponibles.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                Medico medico = controlador.devolverMedicoDisponiblePorApellidoYNombre(apellidoYnombre);

                if (medico != null)
                {
                    lblMedicoSeleccionado.Text = medico.apellidoYnombre;
                    lblMedico.Text = medico.apellidoYnombre;
                }


            }
        }

        private void btnAsignarMedico_Click(object sender, EventArgs e)
        {
            AsignarMedico();
        }

        /// <summary>
        /// Luego de seleccionar una fila de medicos disponibles, carga informacion del medico
        /// en los labels correspondientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AsignarMedico()
        {
             if(dgvEspecialidesDisponibles.SelectedRows != null ||
                dgvMedicosDisponibles.SelectedRows != null)
            {

             controlador.asignarMedicoAConsulta(
                    lblPaciente.Text,
                    DateTime.Parse(lblFechaYHora.Text),
                    lblMedico.Text
                    );
                cargarTabla();
                esconderInformacionNoSeleccionada();
            }
        }

    }
}
