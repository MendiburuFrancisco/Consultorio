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
    public partial class Consultas : FormBase
    {
        private Controlador controlador;
        public Consultas(Controlador controlador)
        {
            InitializeComponent();
            this. controlador = controlador; 
            dgvConsultas.AutoGenerateColumns = false;
            dgvMedicosDisponibles.AutoGenerateColumns = false;            
            cargarTabla();
            esconderInformacionNoSeleccionada();
        }

        protected override void  cargarTabla()
        {
            dgvConsultas.Rows.Clear();
      

            List<Consulta> consultas =  controlador.devolverConsultas();
            
            foreach(Consulta consulta in consultas)
            {
                string medicoApellidoYNombre = (consulta.medico != null) ?
                    consulta.medico.apellidoYnombre
                    : "";

                dgvConsultas.Rows.Add
                    (
                    consulta.paciente.apellidoYnombre,
                    medicoApellidoYNombre,
                    consulta.estado,
                    consulta.fecha_hora
                    );
            }
            this.dgvConsultas.Sort(this.dgvConsultas.Columns["fecha_hora"], ListSortDirection.Ascending);
            dgvEspecialidesDisponibles.DataSource = controlador.listaEspecialidadesDisponibles().Select(x => new { especialidad = x }).ToList();
            dgvMedicosDisponibles.DataSource = controlador.listaMedicosDisponibles();


        }


        protected override void esconderInformacionNoSeleccionada()
        {
        
            label2.Visible = false; // lblTituloPaciente
            lblPaciente.Visible = false;
            label3.Visible = false; // lblTituloMedico
            lblMedico.Visible = false;
            label4.Visible = false; // lblTituloEstado
            lblEstado.Visible = false;
            label5.Visible = false; // lblTituloFechaYHora
            lblFechaYHora.Visible = false;
            btnConsulta.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            lblMedicoSeleccionado.Visible = false;

            dgvEspecialidesDisponibles.Visible = false;
            dgvMedicosDisponibles.Visible = false;
            txtResultado.Visible = false;
            lblSelecciono.Visible = true;




        }
        protected override void mostrarInformacionSeleccionada()
        {
            

            lblSelecciono.Visible = false;
            label2.Visible = true; // lblTituloPaciente
            lblPaciente.Visible = true;
            label3.Visible = true; // lblTituloMedico
            lblMedico.Visible = true;
            label4.Visible = true; // lblTituloEstado
            lblEstado.Visible = true;
            label5.Visible = true; // lblTituloFechaYHora
            lblFechaYHora.Visible = true;
            btnConsulta.Visible = true;

            if (lblMedico.Text.Length > 1)
            {
                label9.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                dgvEspecialidesDisponibles.Visible = false;
                dgvMedicosDisponibles.Visible = false;
                label6.Visible = true; 
                txtResultado.Visible = true;
                lblMedicoSeleccionado.Visible = false;
                btnConsulta.Text = "Finalizar consulta";

            }
            else
            {

                label8.Visible = true;
                label7.Visible = true;
                label6.Visible = false; 
                label9.Visible = true;
                lblMedicoSeleccionado.Visible = true;
                lblMedicoSeleccionado.Text = "Todavía a nadie";
                dgvEspecialidesDisponibles.Visible = true;
                dgvMedicosDisponibles.Visible = true;
                txtResultado.Visible = false;
                
                btnConsulta.Text = "Asignar medico";
            }
             
        }
 
        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        /// <summary>
        /// Luego de seleccionar una fila, carga los datos de la misma sobre labels y muestra 
        /// informacion segun el objetivo del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( dgvConsultas.SelectedRows != null)
            {
               
                lblMedico.Text = ((string)dgvConsultas.CurrentRow.Cells["medico"].Value);
                lblPaciente.Text = ((string)dgvConsultas.CurrentRow.Cells["paciente"].Value);
                lblEstado.Text = ((string)dgvConsultas.CurrentRow.Cells["estado"].Value);
                lblFechaYHora.Text = ((DateTime)dgvConsultas.CurrentRow.Cells["fecha_hora"].Value).ToString();
                mostrarInformacionSeleccionada();

            }
        }


        /// <summary>
        /// Dependiendo del objetivo del usuario, puede finalizar una consulta o permitir
        /// agregar medicos a la misma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            TerminarConsulta();
            AsignarMedico();
            esconderInformacionNoSeleccionada();
        }

        /// <summary>
        /// Luego de seleccionar una fila con una consulta en curso, delega
        /// la responsabilidad al controlador para finalizarla
        /// </summary>
        private void TerminarConsulta()
        {
            if (dgvConsultas.SelectedRows != null)
            {
                
        
                if (lblEstado.Text == "Iniciado" && lblMedico.Text.Length > 1)
                {
                    controlador.finalizarConsulta(
                        lblMedico.Text,
                        lblPaciente.Text,
                        (DateTime)dgvConsultas.CurrentRow.Cells["fecha_hora"].Value,
                        txtResultado.Text
                        );
 
                    cargarTabla(); 
                }
            }
        }
        /// <summary>
        /// Luego de seleccionar una fila con una consulta en curso, delega
        /// la responsabilidad al controlador para agregar un medico
        /// </summary>
        private void AsignarMedico()
        {
             
         
                if (lblEstado.Text == "En espera" && lblMedico.Text.Length > 1)
                {

                    controlador.asignarMedicoAConsulta(
                        lblPaciente.Text,
                        DateTime.Parse(lblFechaYHora.Text),
                        lblMedico.Text
                        ); 
                cargarTabla();
                   
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

                if(medico != null)
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
                string apellidoYnombre = dgvMedicosDisponibles.CurrentRow.Cells["apellidoYnombre"].Value.ToString();
                Medico medico = controlador.devolverMedicoDisponiblePorApellidoYNombre(apellidoYnombre);

                if (medico != null)
                {
                    lblMedicoSeleccionado.Text = medico.apellidoYnombre;
                    lblMedico.Text = medico.apellidoYnombre;
                }


            }
        }
    }
}
