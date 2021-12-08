using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Persona
    {
    
        /// <summary>
        /// Inicializo medico con nombre, apellido, le establezco una especialidad random  y lo establezco como disponible
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Medico(string nombre, string apellido)
        {
            setApellidoYNombre(nombre, apellido);
            this.especialidad = Especialidades.devolverEspecialidadRandom().ToString();
            this.esta_atendiendo = false;
            this.esta_disponible = true;
        }

        /// <summary>
        /// Inicializo medico con nombre, apellido y disponibilidad, tambien le establezco una especialidad random  
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Medico(string nombre, string apellido,bool disponibilidad)
        {
            setApellidoYNombre(nombre, apellido);
            this.especialidad = Especialidades.devolverEspecialidadRandom().ToString();
            this.esta_atendiendo = false;
            this.esta_disponible = disponibilidad;
        }

        private string _especialidad;
        private bool _esta_atendiendo;
        private bool _esta_disponible;

        public string especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public bool esta_atendiendo
        {
            get { return _esta_atendiendo; }
            set { _esta_atendiendo = value; }
        }

        public bool esta_disponible
        {
            get { return _esta_disponible; }
            set { _esta_disponible = value; }
        }

    
        protected override void setApellidoYNombre(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

    
        /// <summary>
        /// Cambia el estado del medico, si esta atendiendo a esta_atendido = true sino false
        /// </summary>
        public void cambiarDisponibilidad()
        {
            esta_atendiendo = !esta_atendiendo;
        }



    }
}

