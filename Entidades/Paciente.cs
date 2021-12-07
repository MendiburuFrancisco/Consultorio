using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {

     
        public Paciente(string dni,string nombre, string apellido, int edad, string obraSocial)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.obraSocial = obraSocial; 
 
        }

        public Paciente(string dni,string nombre, string apellido, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.obraSocial = ObrasSociales.devolverObraSocialRandom().ToString();
        }

        public Paciente()
        {
            this.nombre = "Francisco";
            this.apellido = "Mendiburu";
            this.edad = 21;
            obraSocial = null;


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
            set 
            {
                if (value == ObrasSociales.ObraSocial.NoTiene.ToString()
                    || value == ObrasSociales.ObraSocial.CoberturaBasica.ToString()
                    || value == ObrasSociales.ObraSocial.CoberturaCompleta.ToString()
                    )
                {
                    _obraSocial = value; 
                }
                else
                {
                    _obraSocial = ObrasSociales.ObraSocial.NoTiene.ToString();
                }
               
            
            }
        }

        public string dni
        {
            get { return _dni; }
            set
            {
                _dni = value;
            }
        }


    }
}
