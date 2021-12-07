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

        private void cargarTabla()
        {
            dgvMedicos.DataSource = controlador.listaMedicos();
        }
    
    }
}
