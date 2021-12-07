using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {

     
        private string _nombre, _apellido;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public  string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string apellidoYnombre
        {
            get { return _nombre + " " + _apellido; }
        }

        protected virtual void setApellidoYNombre(string nombre, string apellido) { }

       // protected abstract void ingresarDatos();
    }
}
