using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        
        public Consulta(Paciente paciente, Medico medico)
        {
            medico.cambiarDisponibilidad();
            this.paciente = paciente;
            this.medico = medico;
            this.estado = "Iniciado";
            this.fecha_hora = DateTime.Now;
        }

        public Consulta(Paciente paciente)
        {
            var minutosRandom = new Random().Next(1, 20);
            var segundosRandom = new Random().Next(1, 60);
            this.paciente = paciente; 
            this.estado = "En espera";
            this.fecha_hora = DateTime.Now.AddMinutes(minutosRandom).AddSeconds(segundosRandom);
        }

        public Consulta(Paciente paciente,DateTime tiempoYdia)
        {
            this.paciente = paciente;
            this.estado = "En espera";
            this.fecha_hora = tiempoYdia;
        }




        private Paciente _paciente;
        private Medico _medico;
        private string _estado; // ver si no es bool o que tipo de dato ( enum ? )
        private DateTime _fecha_hora;
        private string _resultado;

        public Paciente paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }
        public Medico medico
        {
            get { return _medico; }
            set
            {
                _medico = value;
                //_medico.esta_atendiendo = true;
            }
        }
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public DateTime fecha_hora
        {
            get { return _fecha_hora; }
            set { _fecha_hora = value; }
        }

        public string resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }

        public bool finalizarConsulta()
        {
            bool finalizoCorrectamente = false;
            if (estado == "Iniciado")
            {
                finalizoCorrectamente = true;
                estado = "Finalizado";
            }

            return finalizoCorrectamente;

        }

        internal void inicializarConsulta()
        {
            
            if (estado == "En espera")
            {
                
                estado = "Iniciado";
            }

           

        }
    }
}
