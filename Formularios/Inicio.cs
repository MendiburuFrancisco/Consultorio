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
    public partial class Inicio : Form
    {
        // Atributos
        private Form formHijoActual;
        private Consultas ventanaConsulta;
        private Estadisticas ventanaEstadistica;
        private Medicos ventanaMedico;
        private Pacientes ventanaPacientes;
        public Controlador controlador = new Controlador();

        // Constructor 
        public Inicio()
        {
            InitializeComponent();
            ventanaConsulta = new Consultas(controlador);
            ventanaMedico = new Medicos(controlador);
            ventanaEstadistica = new Estadisticas(controlador);
            ventanaPacientes = new Pacientes(controlador);


            desactivarBotones();

            this.btnConsultas.ForeColor = Color.White;
            this.btnConsultas.Image = global::Formularios.Properties.Resources.briefcase;
            abrirFormHijo(ventanaConsulta);
        }

        // Metodos 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void abrirFormHijo(Form formHijo)
        {
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(formHijo);
            panelPadre.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

        }

        private void btnLogo(object sender, EventArgs e)
        {
            misDatos ventanaDatos = new misDatos();
            abrirFormHijo(ventanaDatos);
        }

        private void btnInicio_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void desactivarBotones()
        {
            Color tipografiaDesactivada = Color.FromArgb(229, 229, 229);

            this.btnConsultas.ForeColor = tipografiaDesactivada;
            this.btnConsultas.Image = global::Formularios.Properties.Resources.briefcase_off;

            this.btnEstadistica.ForeColor = tipografiaDesactivada;
            this.btnEstadistica.Image = global::Formularios.Properties.Resources.bar_chart_2_off;

            this.btnMedicos.ForeColor = tipografiaDesactivada;
            this.btnMedicos.Image = global::Formularios.Properties.Resources.clipboard_off;

            this.btnPacientes.ForeColor = tipografiaDesactivada;
            this.btnPacientes.Image = global::Formularios.Properties.Resources.users_off;
        }



        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            desactivarBotones();
            this.btnEstadistica.ForeColor = Color.White;
            this.btnEstadistica.Image = global::Formularios.Properties.Resources.bar_chart_2;

            ventanaEstadistica.actualizar();
            abrirFormHijo(ventanaEstadistica);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            desactivarBotones();
            this.btnConsultas.ForeColor = Color.White;
            this.btnConsultas.Image = global::Formularios.Properties.Resources.briefcase;

            abrirFormHijo(ventanaConsulta);
          
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            desactivarBotones();
            this.btnMedicos.ForeColor = Color.White;
            this.btnMedicos.Image = global::Formularios.Properties.Resources.clipboard;


            abrirFormHijo(ventanaMedico);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            desactivarBotones();
            this.btnPacientes.ForeColor = Color.White;
            this.btnPacientes.Image = global::Formularios.Properties.Resources.users;

            ventanaPacientes.actualizarTabla();
            abrirFormHijo(ventanaPacientes);
            
        }

   
 

    }
}
