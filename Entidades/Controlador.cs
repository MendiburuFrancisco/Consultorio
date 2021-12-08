using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Controlador
    {

        public Controlador()
        {
            pacientes = new List<Paciente>();
            medicos = new List<Medico>();
            consultas = new List<Consulta>();
            generarDatos();

        }
        private  List<Paciente> pacientes;
        private List<Medico> medicos;
        private List<Consulta> consultas;
 

        /// <summary>
        /// Devuelve consultas activas (En espera e Iniciadas )
        /// </summary>
        /// <returns>Lista de consultas en espera e inciadas</returns>
        public List<Consulta> devolverConsultasActivas()
        {
            List<Consulta> consultaEnEsperaEIniciada = new List<Consulta>();
            foreach(Consulta consulta in consultas)
            {
                if(consulta.medico != null && consulta.estado != "Finalizado" )
                {
                    consultaEnEsperaEIniciada.Add(consulta);
                }

            }
            return consultaEnEsperaEIniciada;
        }

        /// <summary>
        /// Busco la consulta segun el paciente y la hora, y el medico. Marco como "En espera" la consulta 
        /// </summary>
        /// <param name="apellidoYnombrePaciente"></param>
        /// <param name="fecha_hora"></param>
        /// <param name="apellidoYnombreMedico"></param>
        public void asignarMedicoAConsulta(string apellidoYnombrePaciente, DateTime fecha_hora, string apellidoYnombreMedico)
        {
            Consulta con = devolverConsultaSegunPacienteYHora(apellidoYnombrePaciente, fecha_hora);
            Medico medico = devolverMedicoDisponiblePorApellidoYNombre(apellidoYnombreMedico);
           
            foreach(Consulta consulta in consultas)
            {
                if(consulta == con && consulta.medico == null && medico != null)
                {
                    
                    consulta.medico = medico;
                    consulta.estado = (consulta.medico.esta_atendiendo) ? "En espera" : "Iniciado";
                    if(consulta.estado == "Iniciado")
                    {
                        consulta.medico.cambiarDisponibilidad();
                    }
                }
            }
        }
        
        /// <summary>
        /// Creo una consulta para un paciente y medico determinado que este disponible para atender
        /// </summary>
        public void asignarConsulta(string apellidoYnombrePaciente, string apellidoYnombreMedico)
        {
            Medico medicoAsignado = devolverMedicoDisponiblePorApellidoYNombre(apellidoYnombreMedico);
            DateTime tiempoEnQueFueSolicitado = DateTime.Now;
            
           //  Consulta nuevaConsulta = new Consulta();
        }
        
        /// <summary>
        /// Marca como terminada la consulta que está en curso
        /// </summary>
        /// <param name="medicoApellidoYNombre"></param>
        /// <param name="pacienteApellidoYNombre"></param>
        /// <param name="fechaYhora"></param>
        /// <param name="resultado"></param>
        public void finalizarConsulta(string medicoApellidoYNombre, string pacienteApellidoYNombre,DateTime fechaYhora,string resultado)
        {
            foreach(Consulta consulta in consultas)
            {
                if(consulta.medico != null)
                {  
                if(consulta.medico.apellidoYnombre == medicoApellidoYNombre
                    &&
                    consulta.paciente.apellidoYnombre == pacienteApellidoYNombre
                    && 
                    consulta.fecha_hora == fechaYhora
                    )
                {
                    consulta.resultado = resultado;
                    consulta.finalizarConsulta();
                    consulta.medico.cambiarDisponibilidad();
                }
                }
            }

        }

        /// <summary>
        /// Marca como iniciada la consulta que está en curso
        /// </summary>
        /// <param name="medicoApellidoYNombre"></param>
        /// <param name="pacienteApellidoYNombre"></param>
        /// <param name="fechaYhora"></param>
        /// <param name="resultado"></param
        public bool inicializarConsulta(string medicoApellidoYNombre, string pacienteApellidoYNombre, DateTime fechaYhora, string resultado)
        {
            bool seInicializoCorrectamente = false;
            foreach (Consulta consulta in consultas)
            {
              
                if (consulta.medico != null)
                {
                    if (consulta.medico.apellidoYnombre == medicoApellidoYNombre
                        &&
                        consulta.paciente.apellidoYnombre == pacienteApellidoYNombre
                        &&
                        consulta.fecha_hora == fechaYhora
                        && 
                        !consulta.medico.esta_atendiendo
                        )
                    {
                        seInicializoCorrectamente = true;
                        consulta.resultado = resultado;
                        consulta.inicializarConsulta();
                        consulta.medico.cambiarDisponibilidad();
                    }
                }
            }

            return seInicializoCorrectamente;

        }

        /// <summary>
        /// Busca consultas que esten en "En espera" y que no tengan asignados medicos
        /// </summary>
        /// <returns>devuelve los pacientes en espera segun el orden de llegada</returns>
        public List<Paciente> listaPacientesEnEspera()
        { 
            List<Paciente> pacientesEnEspera = new List<Paciente>();
            foreach (Consulta consulta in devolverConsultasEnEsperaOrdenadosPorHoraSinMedico())
            {
                pacientesEnEspera.Add(consulta.paciente);
            } 
            return pacientesEnEspera;                
        }

        /// <summary>
        /// Creo instancias de Personas,Medicos y Consultas. Algunos de manera aleatoria y otros no
        /// </summary>
        public void generarDatos()
        {
            ListaExtendida<Paciente> Pacientes = new ListaExtendida<Paciente>();
            ListaExtendida<Medico> Medicos = new ListaExtendida<Medico>();
            ListaExtendida<Consulta> Consultas = new ListaExtendida<Consulta>();

            ListaExtendida<string> nombres = new ListaExtendida<string>()
            {
                "Amaya",
                "Igor",
                "Valentina",
                "Jose",
                "Carlos",
                "Maria",
                "Ramon",
                "Basilio",
                "Diego",
                "Gabriela",
                "Florin",
                "Luca",
                "Yolanda",
                "Noa"

            };
            ListaExtendida<string> apellidos = new ListaExtendida<string>()
            {
                "Prats",
                "Palma",
                "Villalba",
                "Gonzalez",
                "Diaz",
                "Martinez",
                "Pérez",
                "Lopez",
                "Gomez",
                "Torres",
                "Sosa",
                "Chaves",
                "Romero",
                "García",
            };

            Paciente p1 = new Paciente("45053268", "Francisco", "Mendiburu", 21);
            Paciente p2 = new Paciente("60161512", "Ivo", "D'Ursi", 20);
            Paciente p3 = new Paciente("16545470", "Juan", "Domingo", 41);
            Paciente p4 = new Paciente("78749875", "Tomas", "Brasca", 31);

            Pacientes = Pacientes + p1 + p2 + p3 + p4;

            pacientes = Pacientes; 
           
            //pacientes.Add(p1);
            //pacientes.Add(p2);
            //pacientes.Add(p3);
            //pacientes.Add(p4);

            Medico m1 = new Medico("Hilaire", "Messeroux");
            Medico m2 = new Medico("Mamadou", "Quintero");
            Medico m3 = new Medico("Alicia", "Cardenas");
            Medico m4 = new Medico("Noa", "Melgar");

            Medicos = Medicos + m1 + m2 + m3 + m4;

            medicos = Medicos;

            //medicos.Add(m1);
            //medicos.Add(m2);
            //medicos.Add(m3);
            //medicos.Add(m4);

            Consulta c1 = new Consulta(p1, m1);
            Consulta c2 = new Consulta(p2); 
            Consulta c3 = new Consulta(p3); 
            Consulta c4 = new Consulta(p4);

            Consultas = Consultas + c1 + c2 + c3 + c4;

            consultas = Consultas;

            //consultas.Add(c1);
            //consultas.Add(c2);
            //consultas.Add(c3);
            //consultas.Add(c4);

            int cantidadDeInstancias = 6; // Con esto varian la cantidad de instancias que se generan 


            for (int instancia = 0; instancia < cantidadDeInstancias; instancia++)
            {
                string nombre = ListaExtendida<string>.devolverElementoAleatorio(nombres);
                string apellido = ListaExtendida<string>.devolverElementoAleatorio(apellidos);
                int edad = new Random().Next(15, 90);
                string dni = new Random().Next(11149875, 78749875).ToString();

                Paciente pn = new Paciente(dni, nombre, apellido, edad); 
                pacientes.Add(pn);

                nombre = ListaExtendida<string>.devolverElementoAleatorio(nombres);
                apellido = ListaExtendida<string>.devolverElementoAleatorio(apellidos);
                int banderaMedico= new Random().Next(0, 2);


                Medico m = (banderaMedico ==1)? new Medico(nombre, apellido): new Medico(nombre,apellido,false); 
                medicos.Add(m);

                if(banderaMedico ==1) {

                int bandera = new Random().Next(1, 4);
                Consulta nuevaConsulta = null;

                switch (bandera)
                {
                    case 1: nuevaConsulta = new Consulta(pn, m); break;
                    case 2: nuevaConsulta = new Consulta(pn);  break;
                    case 3: nuevaConsulta = new Consulta(pn, m, false); break;
                }
            

                consultas.Add(nuevaConsulta);
                }
            }

        }


        /// <summary>
        /// Busco sobre mi lista de medicos a aquellos que estan disponibles para atender
        /// </summary>
        /// <returns>medicos con disponilibidad para atender</returns>
        public List<Medico> listaMedicosDisponibles()
        {
            List<Medico> medicosDisponibles = new List<Medico>();

            foreach(Medico medico in medicos)
            {
                if (medico.esta_disponible)
                {
                    medicosDisponibles.Add(medico);
                }
            }

            return medicosDisponibles;
        }


        /// <summary>
        /// Devuelvo la lista de especialidades que se encuentran disponibles
        /// </summary>
        /// <returns>List<string> de especialidades sin repetir</returns>
        public List<string> listaEspecialidadesDisponibles()
        {
            List<string> especialidadesDisponibles = new List<string>();

            foreach(Medico medico in medicos)
            {
                if(medico.esta_atendiendo == false)
                {
                    if (especialidadesDisponibles.Count > 0)
                    {
                        bool seRepite = false;
                        foreach (string especialidad in especialidadesDisponibles)
                        {
                            if(especialidad == medico.especialidad)
                            {
                                seRepite = true;
                            }
                        }

                        if (!seRepite)
                        {
                            especialidadesDisponibles.Add(medico.especialidad);
                        }
                    }
                    else
                    {
                        especialidadesDisponibles.Add(medico.especialidad);

                    }
                   
                }
            }

            return especialidadesDisponibles;
        }
     

        /// <summary>
        ///Cuento la cantidad de consultas finalizadas por cada MEDICO
        /// </summary>
        /// <returns>Una coleccion de pares, de MEDICOS con su cantidad</returns>
        public Dictionary<Medico, int> ContabilizarMedicosPorConsulta()
        {

            Dictionary<Medico, int> contador = new Dictionary<Medico, int>();
            
            // recordar cambiar la lista consulta por aquellos que esten terminados unicamente 
            foreach (Consulta consulta in consultas)
            {
                if(consulta.medico != null && consulta.estado == "Finalizado")
                {

                
                if (contador.ContainsKey(consulta.medico))
                {
                    contador[consulta.medico] += 1;
                }
                else
                {
                    contador.Add(consulta.medico, 1);
                }
                }
            }

           
            // agrego medicos que no tengan consultas realizados 
           

            foreach (Medico medico in medicos)
            {
                bool bandera = false;
                foreach (KeyValuePair<Medico,int> par in contador)
                { 
                        bandera = (medico == par.Key)? true: bandera;
                     
                }

                if(bandera == false)
                {
                    contador.Add(medico, 0);
                }
                
            }

            return contador;


        }

        /// <summary>
        /// Cuento la cantidad de consultas finalizadas por cada ESPECIALIDAD
        /// </summary>
        /// <returns>Una coleccion de pares, de ESPECIALIDADES con su cantidad</returns>
        public Dictionary<string, int> ContabilizarEspecialidadesPorConsulta()
        {

            Dictionary<string, int> contador = new Dictionary<string, int>();

            // recordar cambiar la lista consulta por aquellos que esten terminados unicamente 
            foreach (Consulta consulta in consultas)
            {
                if (consulta.medico != null && consulta.estado == "Finalizado")
                { 
                    if (contador.ContainsKey(consulta.medico.especialidad))
                    {
                        contador[consulta.medico.especialidad] += 1;
                    }
                    else
                    {
                        contador.Add(consulta.medico.especialidad, 1);
                    }
                }

                // agrego especialidades que no tengan consultas realizados 


                foreach (Medico medico in medicos)
                {
                    bool bandera = false;
                    foreach (KeyValuePair<String, int> par in contador)
                    {
                        bandera = (medico.especialidad == par.Key) ? true : bandera;

                    }

                    if (bandera == false)
                    {
                        contador.Add(medico.especialidad, 0);
                    }

                }

            }

            return contador;


        }

        /// <summary>
        /// Ordeno los medicos segun la cantidad de consultas
        /// </summary>
        /// <returns>Una coleccion de pares ORDENADAS de forma DESCENDENTE, de MEDICOS por su cantidad</returns>
        public Dictionary<Medico, int> devolverMedicosOrdenadosPorConsulta()
        {
            Dictionary<Medico, int> medicosContabilizadosOrdenados = ContabilizarMedicosPorConsulta();

             medicosContabilizadosOrdenados.OrderByDescending(medico => medico.Value);
            
            return medicosContabilizadosOrdenados;
        }
        /// <summary>
        /// Busco cualquier medico que trabaje con la especialidad requerida
        /// </summary>
        /// <param name="especialidad"></param>
        /// <returns>El medico que trabaje con dicha especialidad</returns>
        public Medico devolverMedicoDisponiblePorEspecialidad(string especialidad)
        {
            Medico medicoDisponible = null; 

            foreach(Medico medico in listaMedicosDisponibles())
            {

                medicoDisponible = (medico.especialidad == especialidad) ? medico : medicoDisponible;
               
            }

            return medicoDisponible;
        }

        /// <summary>
        /// Busco un medico a traves de su apellido y nombre
        /// </summary>
        /// <param name="apellidoYnombre"></param>
        /// <returns>Medico que cumpla con las condiciones establecidas</returns>       
        public Medico devolverMedicoDisponiblePorApellidoYNombre(string apellidoYnombre)
        {
            Medico medicoDisponible = null;

            foreach (Medico medico in listaMedicosDisponibles())
            {

                medicoDisponible = (medico.apellidoYnombre == apellidoYnombre) ? medico : medicoDisponible;

            }

            return medicoDisponible;
        }

        /// <summary>
        /// Devuelvo a la consulta realizada por un paciente a una hora determinada
        /// </summary>
        /// <param name="apellidoYnombre"></param>
        /// <param name="fecha_hora"></param>
        /// <returns>consulta perteneciente que cumple con dichos parametros</returns>
        public Consulta devolverConsultaSegunPacienteYHora(string apellidoYnombre, DateTime fecha_hora)
        {
            Consulta consultaSolicitada = null;
            foreach(Consulta consulta in consultas)
            {
                consultaSolicitada = (

                    consulta.paciente.apellidoYnombre == apellidoYnombre
                    && consulta.fecha_hora.ToString() == fecha_hora.ToString()

                    ) ? consulta : consultaSolicitada;
            }

            return consultaSolicitada;
        }

        /// <summary>
        /// devuelvo la ultima consulta en espera perteneciente a un paciente
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public Consulta devolverConsultaSegunPaciente(string dni)
        {
            List<Consulta> consultasEnEspera = devolverConsultasEnEsperaOrdenadosPorHoraSinMedico();

            return consultasEnEspera
                .Select(consulta => consulta)
                .Where(consulta => consulta.paciente.dni == dni)
                .First();
        }
        
        
        /// <summary>
        /// Busco el medico con MAS atenciones segun la cantidad de consultas
        /// </summary>
        /// <returns>Medico con MAS atenciones junto ala cantidad de atenciones que realizo</returns>
        public Dictionary<Medico, int> DevolverMedicoConMasAtenciones()
        {
         
            Dictionary<Medico, int> contador = ContabilizarMedicosPorConsulta();
            Medico medicoConMasAtenciones = null;
            int cantidadDeAtenciones = 0;
            foreach (KeyValuePair<Medico, int> par in contador)
            {
                if (cantidadDeAtenciones <= par.Value)
                {
                    cantidadDeAtenciones = par.Value;
                    medicoConMasAtenciones = par.Key;
                }
            }
            contador.Clear();
            contador.Add(medicoConMasAtenciones, cantidadDeAtenciones);

            return contador;

        }

        /// <summary>
        /// Busco el medico con MENOS atenciones segun la cantidad de consultas
        /// </summary>
        /// <returns>Medico con MENOS atenciones junto a la cantidad de atenciones que realizo</returns>
        public Dictionary<Medico, int> DevolverMedicoConMenosAtenciones()
        {
            Dictionary<Medico, int> contador = ContabilizarMedicosPorConsulta();
            
            Medico medicoConMenosAtenciones = null;
            int cantidadDeAtenciones = contador.First().Value;

            foreach (KeyValuePair<Medico, int> par in contador)
            {
                if (par.Value <= cantidadDeAtenciones)
                {
                    cantidadDeAtenciones = par.Value;
                    medicoConMenosAtenciones = par.Key;
                }
            }
            contador.Clear();
            contador.Add(medicoConMenosAtenciones, cantidadDeAtenciones);

            return contador;
        }
        /// <summary>
        /// Busco la especialidad con MAS consultas 
        /// </summary>
        /// <returns>Especialidad junto a la cantidad de consultas</returns>
        public Dictionary<string, int> DevolverEspecialidadConMasAtenciones()
        {

            Dictionary<string, int> contador = ContabilizarEspecialidadesPorConsulta();
            string especialidadConMasConsultas = null;
            int cantidadDeAtenciones = -1;
            foreach (KeyValuePair<string, int> par in contador)
            {
                if (cantidadDeAtenciones < par.Value)
                {
                    cantidadDeAtenciones = par.Value;
                    especialidadConMasConsultas = par.Key;
                }
            } 

            contador.Clear();
            contador.Add(especialidadConMasConsultas, cantidadDeAtenciones);

            return contador;

        }

        /// <summary>
        /// Busca las consultas en espera, sin medicos asignados y los ordeno
        /// </summary>
        /// <returns>lista de consultas ordenadas en espera y sin medicos asignados</returns>
        public List<Consulta> devolverConsultasEnEsperaOrdenadosPorHoraSinMedico()
        {
            List<Consulta> consultasEnEspera = new List<Consulta>();

            foreach (Consulta consulta in consultas)
            {
                if (consulta.estado == "En espera" && consulta.medico == null)
                {
                    consultasEnEspera.Add(consulta);
                }
            }

            consultasEnEspera = consultasEnEspera.OrderBy(consulta => consulta.fecha_hora).ToList();
           
            return consultasEnEspera;
        }


        /// <summary>
        /// Busco la cantidad de consultas con estado "Finalizada"
        /// </summary>
        /// <returns>Lista de consultas finalizadas</returns>
        public List<Consulta> DevolverConsultasFinalizadas()
        {
            List<Consulta> consultasFinalizadas = new List<Consulta>();

            return consultasFinalizadas;
        }
     
        /// <summary>
        /// Busca de un medico todas las consultas no atendidas
        /// </summary>
        /// <param name="medico"></param>
        /// <returns>Lista de consultas en espera</returns>
        public List<Consulta> devolverListaDeEsperaDeMedico(Medico medico)
        {
            List<Consulta> consultasEnEspera = new List<Consulta>();

            foreach (Consulta consulta in consultas)
            {
                if (consulta.medico == medico && consulta.estado == "En espera")
                {
                    consultasEnEspera.Add(consulta);
                }

            }

            return consultasEnEspera;
        }
        

    }
}
