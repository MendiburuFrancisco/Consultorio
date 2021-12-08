using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        
        /// <summary>
        /// Inicia la consulta con un paciente y medico determinado a hora actual
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="medico"></param>
        public Consulta(Paciente paciente, Medico medico)
        {
            medico.cambiarDisponibilidad();
            this.paciente = paciente;
            this.medico = medico;
            this.estado = "Iniciado";
            this.fecha_hora = DateTime.Now;
        }
        /// <summary>
        ///  Inicia la consulta con un paciente a una hora aleatoria a partir de la actual y lo pone en espera
        /// </summary>
        /// <param name="paciente"></param>
        public Consulta(Paciente paciente)
        {
            var minutosRandom = new Random().Next(1, 20);
            var segundosRandom = new Random().Next(1, 60);
            this.paciente = paciente; 
            this.estado = "En espera";
            this.fecha_hora = DateTime.Now.AddMinutes(minutosRandom).AddSeconds(segundosRandom);
        }

        /// <summary>
        /// Crea y finaliza una consulta en un horario anterior al actual
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="medico"></param>
        /// <param name="estadoConsulta"></param>
        public Consulta(Paciente paciente,Medico medico, bool estadoConsulta)
        {
            this.paciente = paciente;
            this.medico = medico;
            var minutosRandom = new Random().Next(-40, 0);
            var segundosRandom = new Random().Next(-60, 0);
            this.fecha_hora = DateTime.Now.AddMinutes(minutosRandom).AddSeconds(segundosRandom);
            if (!estadoConsulta)
            {
                this.estado = "Finalizado";
            }
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

        /// <summary>
        /// De Iniciado pasa a Finalizado
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// De En Espera pasa a Iniciado
        /// </summary>
        internal void inicializarConsulta()
        {
            
            if (estado == "En espera")
            {
                
                estado = "Iniciado";
            }

           

        }
    }
}
