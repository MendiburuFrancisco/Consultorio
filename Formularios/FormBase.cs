using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public abstract partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos de las tablas en el form
        /// </summary>
        protected abstract void cargarTabla();

        /// <summary>
        /// Esconde objetos del formulario que no son necesarios para el objetivo actual del usuario
        /// </summary>
        protected virtual void esconderInformacionNoSeleccionada() { }
        /// <summary>
        /// Muestra objetos del formulario necesarios para el objetivo actual del usuario
        /// </summary>
        protected virtual void mostrarInformacionSeleccionada() { }

    }
}
