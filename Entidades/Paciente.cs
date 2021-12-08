using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    { 
        /// <summary>
        /// Inicializo con los datos basicos de un paciente y la obra social establezco una aleatoria
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        public Paciente(string dni,string nombre, string apellido, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.obraSocial = ObrasSociales.devolverObraSocialRandom().ToString();
        }
  

        private string _dni;
        private int _edad;
        private string _obraSocial;  

        public int edad
        {
            get { return _edad; }
            set { _edad = value; }
        }


        public string obraSocial
        {
            get { return _obraSocial; }
            set {  _obraSocial = value;}
        }

        public string dni
        {
            get { return _dni; }
            set {  _dni = value; }
        }

      

       
    }
}
