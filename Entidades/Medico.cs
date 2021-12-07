using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Persona
    {
    
        public Medico(string nombre, string apellido)
        {
            setApellidoYNombre(nombre, apellido);
            this.especialidad = Especialidades.devolverEspecialidadRandom().ToString();
            this.esta_atendiendo = false;
        }

        private string _especialidad;
        private bool _esta_atendiendo;


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

        protected override void setApellidoYNombre(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

    

        public void cambiarDisponibilidad()
        {
            esta_atendiendo = !esta_atendiendo;
        }



    }
}

