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
    public partial class Consultas : Form
    {
        private Controlador controlador;

        /// <summary>
        /// Inicializo la ventana con el controlador que contiene la informacion de las consultas
        /// </summary>
        /// <param name="controlador"></param>
        public Consultas(Controlador controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            dgvConsultas.AutoGenerateColumns = false;

            cargarTabla();
            esconderInformacionNoSeleccionada();
        }

        /// <summary>
        /// Cargo las tablas correspondientes
        /// </summary>
        private void cargarTabla()
        {
            dgvConsultas.Rows.Clear();


            List<Consulta> consultas = controlador.devolverConsultasActivas();

            foreach (Consulta consulta in consultas)
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



        }

       /// <summary>
       /// Al momento de hacer click en el boton o al ingresar al pantalla esconde informacion para evitar errores
       /// </summary>
        private void esconderInformacionNoSeleccionada()
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

            txtResultado.Visible = false;
            lblSelecciono.Visible = true;
            lblError.Visible = false;



        }
 
        /// <summary>
        /// Al momento de hacer click sobre una tabla muestra elementos que son pertinentes para guardar su informacion en ellos
        /// </summary>
        private void mostrarInformacionSeleccionada()
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

            if (lblEstado.Text == "Iniciado")
            {

                label6.Visible = true;
                txtResultado.Visible = true;

                btnConsulta.Text = "Finalizar consulta";

            }
            else
            {

                label6.Visible = false;

                txtResultado.Visible = false;

                btnConsulta.Text = "Iniciar consulta";
            }

        }

        /// <summary>
        /// Luego de seleccionar una fila, carga los datos de la misma sobre labels y muestra 
        /// informacion segun el objetivo del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultas.SelectedRows != null)
            {
                lblError.Visible = false;

                lblMedico.Text = ((string)dgvConsultas.CurrentRow.Cells["medico"].Value);
                lblPaciente.Text = ((string)dgvConsultas.CurrentRow.Cells["paciente"].Value);
                lblEstado.Text = ((string)dgvConsultas.CurrentRow.Cells["estado"].Value);
                lblFechaYHora.Text = ((DateTime)dgvConsultas.CurrentRow.Cells["fecha_hora"].Value).ToString();
                mostrarInformacionSeleccionada();

            }
        }

        /// <summary>
        /// Actualiza las tablas correspondientes
        /// </summary>
        internal void actualizar()
        {
            cargarTabla();
        }

        /// <summary>
        /// Dependiendo del objetivo del usuario, puede finalizar una consulta o permitir
        /// agregar medicos a la misma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsulta_Click(object sender, EventArgs e)
        {
           
            if (dgvConsultas.SelectedRows != null)
            {
                TerminarConsulta();
                InicializarConsulta();
                
            }
        }

        /// <summary>
        /// Luego de seleccionar una fila con una consulta en curso, delega
        /// la responsabilidad al controlador para finalizarla
        /// </summary>
        private void TerminarConsulta()
        { 
            if (lblEstado.Text == "Iniciado") {
                if(txtResultado.Text.Length > 0)
                {

                    controlador.finalizarConsulta(
                        lblMedico.Text,
                        lblPaciente.Text,
                        (DateTime)dgvConsultas.CurrentRow.Cells["fecha_hora"].Value,
                        txtResultado.Text
                        );

                    cargarTabla();
                    esconderInformacionNoSeleccionada();

                }
                else
                {
                    mostrarError("Asigne un resultado");
                }
            }
            
        }

        /// <summary>
        /// Luego de seleccionar una fila con una consulta en curso, delega
        /// la responsabilidad al controlador para inicializarla
        /// </summary>
        private void InicializarConsulta()
        {

            if (lblEstado.Text == "En espera")
            {
                bool seInicializo = controlador.inicializarConsulta(
                     lblMedico.Text,
                     lblPaciente.Text,
                     (DateTime)dgvConsultas.CurrentRow.Cells["fecha_hora"].Value,
                     txtResultado.Text
                     );

                if (seInicializo)
                {
                    cargarTabla();
                    esconderInformacionNoSeleccionada();
                }
                else
                {
                    mostrarError("Medico ocupado");
                }
          

            }

        }
       
        /// <summary>
        /// Habilito un label que muestra un rojo el error
        /// </summary>
        /// <param name="mensajeDeError"></param>
        private void mostrarError(string mensajeDeError)
        {
            lblError.Visible = true;
            lblError.Text = mensajeDeError;
        }


    }
}
