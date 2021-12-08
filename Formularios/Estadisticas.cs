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
    public partial class Estadisticas : Form
    {

        private Controlador controlador;
        private Medico medicoConMasAtenciones;
        private Medico medicoConMenosAtenciones;
        private string especialidadDeModa;


        public Estadisticas(Controlador controlador)
        {
            this.controlador = controlador;
   
            InitializeComponent();
            dgvMedicosPorPaciente.AutoGenerateColumns = false;
            actualizar();

        }

        public void actualizar()
        {
            dgvMedicosPorPaciente.Rows.Clear();
            cargarTabla();
           
            mostrarMedicoConMasAtenciones();
            mostrarEspecialidadDeModa();
            mostrarMedicoConMenosAtenciones();

        }

        public void cargarTabla()
        {
            Dictionary<Medico, int> medicos = controlador.devolverMedicosOrdenadosPorConsulta();
            

            foreach (KeyValuePair<Medico, int> par in medicos.OrderByDescending(medico => medico.Value))
            {
                dgvMedicosPorPaciente.Rows.Add
                    (
                    par.Key.apellido,
                    par.Key.nombre,
                    par.Key.especialidad,
                    par.Value
                    );

            }

            
        } 

        /// <summary>
        /// Delega la responsabilidad al controlador para buscar al medico con mas atenciones
        /// y lo muestra
        /// </summary>
        private void mostrarMedicoConMasAtenciones()
        {
            Dictionary<Medico, int> medicoConSusAtenciones = controlador.DevolverMedicoConMasAtenciones();

            medicoConMasAtenciones = medicoConSusAtenciones.First().Key;
            lblMedicoCantAtenciones.Text = medicoConSusAtenciones.First().Value.ToString();
 
            lbltxtMedicoConMasAtenciones.Text = medicoConMasAtenciones.apellidoYnombre;
           
        }
        /// <summary>
        /// Delega la responsabilidad al controlador para buscar al medico con menos atenciones
        /// y lo muestra
        /// </summary>
        private void mostrarMedicoConMenosAtenciones()
        {
            Dictionary<Medico, int> medicoConSusAtenciones = controlador.DevolverMedicoConMenosAtenciones();

            medicoConMenosAtenciones = medicoConSusAtenciones.First().Key;
            lblCantMedicoMenosAtenciones.Text = medicoConSusAtenciones.First().Value.ToString();
            lblTxtMedicoMenosAtenciones.Text = medicoConMenosAtenciones.apellidoYnombre;

        }

        /// <summary>
        /// Delega la responsabilidad al controlador para buscar la especialidad con mas atenciones
        /// y lo muestra
        /// </summary>
        private void mostrarEspecialidadDeModa()
        {
            Dictionary<string, int> especialidadConCantidad = controlador.DevolverEspecialidadConMasAtenciones();
            especialidadDeModa = especialidadConCantidad.First().Key;
            lblCantEspecialidadMasAtendida.Text = especialidadConCantidad.First().ToString();
            lblTxtEspecialidadMasAtendida.Text= especialidadDeModa;
        }

    }
}
