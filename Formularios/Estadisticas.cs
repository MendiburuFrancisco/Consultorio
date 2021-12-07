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

        private void mostrarMedicoConMasAtenciones()
        {
            Dictionary<Medico, int> medicoConSusAtenciones = controlador.DevolverMedicoConMasAtenciones();
            
            foreach (KeyValuePair<Medico, int> par in medicoConSusAtenciones)
            {
                medicoConMasAtenciones = par.Key;
                lblMedicoCantAtenciones.Text = par.Value.ToString();
            }

           
            lbltxtMedicoConMasAtenciones.Text = medicoConMasAtenciones.apellidoYnombre;
           
        }
        private void mostrarMedicoConMenosAtenciones()
        {
            Dictionary<Medico, int> medicoConSusAtenciones = controlador.DevolverMedicoConMenosAtenciones();

            foreach (KeyValuePair<Medico, int> par in medicoConSusAtenciones)
            {
                medicoConMenosAtenciones = par.Key;
                lblCantMedicoMenosAtenciones.Text = par.Value.ToString();
            }


            lblTxtMedicoMenosAtenciones.Text = medicoConMenosAtenciones.apellidoYnombre;

        }

        private void mostrarEspecialidadDeModa()
        {
            Dictionary<string, int> especialidadConCantidad = controlador.DevolverEspecialidadConMasAtenciones();
            foreach (KeyValuePair<string, int> par in especialidadConCantidad)
            {
                especialidadDeModa = par.Key;
                lblCantEspecialidadMasAtendida.Text = par.Value.ToString();
            }

            lblTxtEspecialidadMasAtendida.Text= especialidadDeModa;

        }

    }
}
